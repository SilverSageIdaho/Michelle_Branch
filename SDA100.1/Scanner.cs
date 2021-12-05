using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace SDA100._1
{
    class Scanner
    {
        public string InData { get; set; }
        public string[] RecipeData { get; set; }  //<-- I created this for the FindComPorts method below. However, is this the right place to store it?
        public string ScanTrack { get; set; }
        public string StatusMessage { get; set; }
        public string ScanReply { get; set; }
        public string ScanUnknownMessage { get; set; }
        //teensy properties
        public string TeensyComPort { get; set; }
        private bool teensyComPortOK;
        public bool TeensyComPortOK
        {
            get
            {
                teensyComPortOK = true;
                return teensyComPortOK;
            }
            set
            {
                value = teensyComPortOK;
            }
        }

        public string IniOID { get; set; }
        public int MapRes { get; set; }
        public int WaferDiam { get; set; }
        public int EdgeRej { get; set; }
        public string SectorSteps { get; set; }
        public string TrackSteps { get; set; }
        public string ParkY { get; set; }
        public string ParkX { get; set; }
        public string ParkZ { get; set; }
        public string PreFocusX { get; set; }
        public string PreFocusY { get; set; }
        public string PreFocusZ { get; set; }
        public string PSize1Label { get; set; }
        public string PSize2Label { get; set; }
        public string PSize3Label { get; set; }
        public string PSize4Label { get; set; }
        public string PSize5Label { get; set; }
        public string PSize6Label { get; set; }
        public string PSize7Label { get; set; }
        public string AfTimeOut { get; set; }
        public string DirData { get; set; }
        public string DirRecipe { get; set; }
        public string DirINI { get; set; }
        public string DirErrorLog { get; set; }
        //which part of the machine do these properties belong to?
        public int MxFrontLimitFlag { get; set; }
        public int MxBackLimitFlag { get; set; }
        public int MyLeftLimitFlag { get; set; }
        public int MyRightLimitFlag { get; set; }
        public int MzTopLimitFlag { get; set; }
        public int MzBottomLimitFlag { get; set; }
        public int DoorOpenFlag { get; set; }
        public int DoorCloseFlag { get; set; }
        public int DoorOKFlag { get; set; }
        public int VacMainFlag { get; set; }
        public int VacChuckFlag { get; set; }
        public int ChuckValveFlag { get; set; }
        public int ScanStopFlag { get; set; }
        public int MxPosAbsVal { get; set; }
        public int MyPosAbsVal { get; set; }
        public int MzPosAbsVal { get; set; }
        public int MxScanTrackWidthVal { get; set; }
        public int MyScanSectorWidthVal { get; set; }
        public double PercentScanVal { get; set; }
        public int HomeNotOK { get; set; }
        public int ZHomeNotOK { get; set; }
        public int AutoFocusOK { get; set; }
        public int AutoFocusVal { get; set; }
        public int SpeedVal { get; set; }
        public int MaxSpeed { get; set; }
        public int WaferRadius { get; set; }
        public int WaferEdgeReject { get; set; }
        public int CountAbort { get; set; }
        public int SysError { get; set; }
        public string ErrorMessage { get; set; } //<-- I created this
        public bool IsError { get; set; }  //<-- I created this to use with StartPage.cs line 107

        //results of scan <-- should this become a new object?
        public int TrackDefectCnt1 { get; set; }
        public int TrackDefectCnt2 { get; set; }
        public int TrackDefectCnt3 { get; set; }
        public int TrackDefectCnt4 { get; set; }
        public int TrackDefectCnt5 { get; set; }
        public int TrackDefectCnt6 { get; set; }
        public int TrackDefectCnt7 { get; set; }

        public int ScanDefectCnt1 { get; set; }
        public int ScanDefectCnt2 { get; set; }
        public int ScanDefectCnt3 { get; set; }
        public int ScanDefectCnt4 { get; set; }
        public int ScanDefectCnt5 { get; set; }
        public int ScanDefectCnt6 { get; set; }
        public int ScanDefectCnt7 { get; set; }

        //double prctComplete;

        public void UpdateStatus()
        {
            const char DELIM = ',';
            //InData = InData.Remove(0, 1);
            //InData = InData.Remove(InData.Length - 3, 3);
            string[] fields = StatusMessage.Split(DELIM);
            int length = fields.Length;
            if (length >= 29)
            {
                MxFrontLimitFlag = Convert.ToInt32(fields[0]);
                MxBackLimitFlag = Convert.ToInt32(fields[1]);
                MyLeftLimitFlag = Convert.ToInt32(fields[2]);
                MyRightLimitFlag = Convert.ToInt32(fields[3]);
                MzTopLimitFlag = Convert.ToInt32(fields[4]);
                MzBottomLimitFlag = Convert.ToInt32(fields[5]);
                DoorOpenFlag = Convert.ToInt32(fields[6]);
                DoorCloseFlag = Convert.ToInt32(fields[7]);
                DoorOKFlag = Convert.ToInt32(fields[8]);
                VacMainFlag = Convert.ToInt32(fields[9]);
                VacChuckFlag = Convert.ToInt32(fields[10]);
                ChuckValveFlag = Convert.ToInt32(fields[11]);
                ScanStopFlag = Convert.ToInt32(fields[12]);
                MxPosAbsVal = Convert.ToInt32(fields[13]);
                MyPosAbsVal = Convert.ToInt32(fields[14]);
                MzPosAbsVal = Convert.ToInt32(fields[15]);
                MxScanTrackWidthVal = Convert.ToInt32(fields[16]);
                MyScanSectorWidthVal = Convert.ToInt32(fields[17]);
                PercentScanVal = Convert.ToDouble(fields[18]);
                HomeNotOK = Convert.ToInt32(fields[19]);
                ZHomeNotOK = Convert.ToInt32(fields[20]);
                AutoFocusOK = Convert.ToInt32(fields[21]);
                AutoFocusVal = Convert.ToInt32(fields[22]);
                SpeedVal = Convert.ToInt32(fields[23]);
                MaxSpeed = Convert.ToInt32(fields[24]);
                WaferRadius = Convert.ToInt32(fields[25]);
                WaferEdgeReject = Convert.ToInt32(fields[26]);
                CountAbort = Convert.ToInt32(fields[27]);
                SysError = Convert.ToInt32(fields[28]);      //<-- what is this used for? (Jac's error handling??)
            }
            else
            {
                MessageBox.Show("The file you are trying to access has insuffient information on it to complete this request.");
            }
        }

        public void ScanComPorts() //THIS CAN RETURN AN OBJECT TO BE CALLED FROM THE INDIVIDUAL PAGES
        {   
            SerialPort serialPort = new SerialPort();
            string[] ports = SerialPort.GetPortNames();
            int length = ports.Length;
            

            for (int px = 0; px < length; px++)
            {
                Console.WriteLine(ports[px]);  //<-- is this for debugging or does it need to display on the monitor for the operator?
            }

            for (int x = 0; x < length; x++)
            {
                try
                {
                    serialPort.PortName = ports[x];
                    serialPort.BaudRate = 115200;
                    serialPort.DataBits = 8;
                    serialPort.StopBits = StopBits.One;
                    serialPort.Parity = Parity.None;
                    serialPort.Open();

                    serialPort.Write("?");
                    int portTestCount = 0;
                    string portTest = "";

                    while ((portTest == "") && (portTestCount < 100))
                    {
                        portTest = serialPort.ReadExisting();
                        portTestCount++;
                    }

                    if (portTest.Contains("!"))
                    {
                        Console.WriteLine("Found the ! Flag on ComPort: " + ports[x].ToString());  //<-- is this for debugging or does it need to display on the monitor for the operator?
                        TeensyComPort = Convert.ToString(ports[x]);
                        x = length;
                        serialPort.Close();
                    }
                    else
                    {
                        serialPort.Close();
                    }
                    if (x == (length - 1))
                    {
                        TeensyComPortOK = false;
                    }
                    else  //<-- do we need this else clause? (I added it)
                    {
                        TeensyComPortOK = true;
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine(ports[x].ToString() + " Is NOT OK" + "\n" + e.Message);  //<-- is this for debugging or does it need to display on the monitor for the operator?
                }
            }
        }
        public void FindComPort()
        {
            // *** Find the Scanner Com Port by testing for "?" => "!" ****

            ScanComPorts();

            SerialPort serialPort = new SerialPort();

            if (!TeensyComPortOK)
            {
                MessageBox.Show("Error - No COM port found!");
            }
            else
            {
                serialPort.PortName = TeensyComPort;
                serialPort.BaudRate = 115200;
                serialPort.DataBits = 8;
                serialPort.StopBits = StopBits.One;
                serialPort.Parity = Parity.None;
                serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler); //<-- new event handler
                serialPort.ReadBufferSize = 16384;                                                                         
                serialPort.Open();

                string iniString = System.IO.File.ReadAllText(@"C:\ScanBeta\SDA100ini.txt");  //<-- what object is this file coming from?
                string[] iniData = iniString.Split(',');
                if (iniData.Length > 23)
                {
                    IniOID = iniData[0];
                    MapRes = int.Parse(iniData[1]);
                    WaferDiam = int.Parse(iniData[2]);
                    EdgeRej = int.Parse(iniData[3]);
                    SectorSteps = iniData[4];
                    TrackSteps = iniData[5];
                    ParkY = iniData[6];
                    ParkX = iniData[7];
                    ParkZ = iniData[8];
                    PreFocusX = iniData[9];
                    PreFocusY = iniData[10];
                    PreFocusZ = iniData[11];
                    PSize1Label = iniData[12];
                    PSize2Label = iniData[13];
                    PSize3Label = iniData[14];
                    PSize4Label = iniData[15];
                    PSize5Label = iniData[16];
                    PSize6Label = iniData[17];
                    PSize7Label = iniData[18];
                    AfTimeOut = iniData[19];
                    DirData = iniData[20];
                    DirRecipe = iniData[21];
                    DirINI = iniData[22];
                    DirErrorLog = iniData[23];
                }
                else
                {
                    MessageBox.Show("The file you are trying to use does not contain enough data to proceed.");
                }

                serialPort.Write("." + MapRes + "r");
                Console.WriteLine("." + MapRes + "r");   //NEW CODE FROM JAC  <-- is this for debugging?
                //autoReset.WaitOne(); //Crap Dustin is messing with 

                serialPort.Write("." + WaferDiam + "d");
                Console.WriteLine("." + WaferDiam + "d"); //NEW CODE FROM JAC  <-- is this for debugging?

            //lblCCWaferSize_Current.Text = "." + WaferDiam + "d";   <-- SET THIS ON MAIN MENU PAGE USING GETTER                 

                serialPort.Write("." + EdgeRej + "e");
                Console.WriteLine("." + EdgeRej + "e");   //NEW CODE FROM JAC  <-- is this for debugging?

            //lblCCEdgeReject_Current.Text = "." + EdgeRej + "e";   <-- SET THIS ON MAIN MENU PAGE USING GETTER

                serialPort.Write("." + SectorSteps + "S");
                Console.WriteLine("." + SectorSteps + "S");  //NEW CODE FROM JAC  <-- is this for debugging?

                serialPort.Write("." + TrackSteps + "T");
                Console.WriteLine("." + TrackSteps + "T");  //< --is this for debugging?

                serialPort.Write("." + ParkY + "y");
                Console.WriteLine("." + ParkY + "y");         //< --is this for debugging?
                serialPort.Write("." + ParkX + "x");
                Console.WriteLine("." + ParkX + "x");       //  <-- is this for debugging?
                serialPort.Write("." + ParkZ + "z");
                Console.WriteLine("." + ParkZ + "z");       //  <-- is this for debugging?
                serialPort.Write("." + PreFocusZ + "u");
                Console.WriteLine("." + PreFocusZ + "u");       //  <-- is this for debugging?
                serialPort.Write("." + PreFocusX + "v");
                Console.WriteLine("." + PreFocusX + "v");       //  <-- is this for debugging?
                serialPort.Write("." + PreFocusY + "w");
                Console.WriteLine("." + PreFocusY + "w");       //  <-- is this for debugging?

                serialPort.Write("h");
                serialPort.Write("H");
                serialPort.Write("m");

                //btnRun.Enabled = false;           <-- THE RUN BUTTON IS ALREADY DISABLED ON THE MAINMENU PAGE
                //need to add the autofocus time out here when the command is available

                //string recString = System.IO.File.ReadAllText(@"C:\ScanBeta\SDA100rec.txt");
                //string[] recData = iniString.Split(',');
                //Globals.recLines = System.IO.File.ReadAllLines(@"C:\ScanBeta\SDA100rec.txt");

                const string FILENAME = @"C:\ScanBeta\SDA100rec.txt";
                try
                {
                    FileStream fileStream = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
                    StreamReader reader = new StreamReader(fileStream);
                    string recString = reader.ReadToEnd();
                    //make sure there is data in the file
                    if (recString != null)
                    {
                        //split the file up into lines and save it to this scanner's RecipeData property for easy retrieval
                        RecipeData = recString.Split(',');
                    }
                    reader.Close();
                    fileStream.Close();
                }
                catch (FileNotFoundException e)
                {
                    //display an error message to the operator
                    MessageBox.Show(e.Message + " The file you are trying to access has no data.");
                }
                //if (VacMainFlag == 0)
                //{
                //    MessageBox.Show("IMPORTANT! No Vacuum present. Must Home X,Y,Z motors before scanning.");
                //}

                //lbxLoadBox.Text = "New Recipe";                                               //<-- ALL OF THIS CODE SHOULD BE ON THE PAGE WHERE IT IS LOCATED'S CS FILE
                /*lbxLoadBox.DataSource = System.IO.File.ReadAllLines(@"C:\ScanBeta\SDA100rec.txt");            //IS THIS FOR THE RECIPE PAGE or the index page?
                dataGridView1.Hide();
                dataGridView1.ColumnCount = 3;
                dataGridView1.Columns[0].Name = "Recipe Name";
                dataGridView1.Columns[1].Name = "Edit Date";
                dataGridView1.Columns[2].Name = "User ID";
                //dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(2, 255, 0, 0);  
                PopulateRecipeList();
                lbxScanDataFiles.DataSource = System.IO.Directory.GetFiles(@"C:\ScanBeta\", "Scan*.txt");*/
            }
        }

        //THIS IS ATTACHED TO THE SERIAL PORT OBJECT AS AN EVENT HANDLER
        public void DataReceivedHandler(object sender, SerialDataReceivedEventArgs a)  //<-- triggered anytime data hits the serialPort/comPort
        {
            //SerialDataReceivedEventHandler eventHandler = (SerialDataReceivedEventHandler)sender;
            if (InData.Contains("<"))
            {
       //CreateFile(recipe);  
            }

            else if (InData.Contains("$"))
            {
                ScanTrack = InData;

                /*using (System.IO.StreamWriter sw = System.IO.File.AppendText(filePath))
                {
                    sw.WriteLine(Globals.scanTrack);
                }*/
         //BeginInvoke(new EventHandler(MapDefectData));  <--what component is calling this?
            }
            //NEW CODE FROM JAC BELOW
            else if (InData.Contains("!"))
            {
                if (InData.Substring(0, 2) == "!f")
                {
                    Console.WriteLine("inData FOCUS: {0}", InData);   //<-- does this need to display to operator?
            //Z_focus = InData.Substring(2, InData.Length - 2);                                             <--WHERE IS Z_FOCUS COMING FROM??
                }
                else if (InData.Contains("!H"))
                {
            //serialPort.Write("m");
                }
                //Errors will match this regular expression
                //Regex regex = new Regex("^![A-Za-z]{1}0{1}\r{1}$");

                //if(regex.IsMatch(Globals.inData))
                //{
                //    Console.WriteLine("Indata error: {0}", Globals.inData);
                //    char letter = Globals.inData[1];
                //    //int maxFailedAttempts = 3;
                //    switch (letter)
                //    {
                //        case 'O': serialPort1.Write("N");
                //                  //Globals.vacChuckFlag = 0;
                //                  Globals.errorMessage = "No wafer detected";
                //            break;
                //        case 'o': Globals.errorMessage = "Door failed to open";
                //                  Globals.doorCloseFlag = 1;
                //            Console.WriteLine("ERROR o");
                //                  //serialPort1.Write("n");
                //            break;
                //        case 'n': Globals.errorMessage = "Door failed to close";
                //                  Globals.doorCloseFlag = 0;
                //                  //serialPort1.Write("o"); //Open door if failed to close?
                //            break;
                //        case 'H': Globals.errorMessage = "Failed to get to Home";
                //            break;
                //        default: Globals.errorMessage = "Unknown error";
                //            break;
                //    }

                //} //else
                //{
                ScanReply = InData;
                //autoReset.Set(); //Crap Dustin is messing with
                //Console.WriteLine("Inside \"!\":" + Thread.CurrentThread.ManagedThreadId);
                //Console.WriteLine("Thread Name: " + Thread.CurrentThread.Name);
                //BeginInvoke?
            //BeginInvoke(new EventHandler(ResponseData));                                    <-- I COMMENTED OUT THIS LINE - 
                //}

                //OLD CODE BELOW
                //*************************************
                //ERROR HANDLING Globals.inData[2] == '0' 
                // Globals.inData.IndexOf('0') == 2
                //*************************************
                if (InData.Contains("0") && InData.Length == 4)
                {
                    Console.WriteLine("ERRRR inData contains Data: {0} 0 Length: {1}", InData, InData.Length);    //<-- is this for debugging?
                    MessageBox.Show("Error - Something failed!");
                }
                else
                {
                    ScanReply = InData;
               //BeginInvoke(new EventHandler(ResponseData));
                }
            }
            else if (InData.Contains("*"))
            {
                StatusMessage = InData;
            //BeginInvoke(new EventHandler(MachineStatus));
            }
            else if (InData.Contains(">"))
            {
                Console.WriteLine("Saw the >!");        //<-- is this for debugging?
                //NEW CODE FROM JAC
             //string csvData = scanRecipe.RecipeTime + "," + scanRecipe.RecipeName + "," + scanRecipe.ScanID + "," + ScanDefectCnt1 + ","
            //               + ScanDefectCnt2 + "," + ScanDefectCnt3 + "," + ScanDefectCnt4 + "," + ScanDefectCnt5 + "," + ScanDefectCnt6 + "," + ScanDefectCnt7;

                string fileName = @"C:\ScanBeta\SDA100rec.txt";
                try
                {
                    FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(fileStream);

           //writer.WriteLine("\n" + csvData);

                    writer.Close();
                    fileStream.Close();
                }
                catch (Exception e)
                {
                    //display an error message to the operator
                    MessageBox.Show(e.Message);
                }
                /*using (System.IO.StreamWriter sw = System.IO.File.CreateText(Globals.filePath + ".csv"))
                {
                    sw.WriteLine();
                    sw.WriteLine(csvData);
                }*/
                //OLD CODE
                /*serialPort.Write("P");
                serialPort.Write("o");
                serialPort.Write("N");*/

            }
            else if (InData.Contains("%"))
            {
   //BeginInvoke(new EventHandler(ProgressBarStatus));
            }
            else
            {
     //BeginInvoke(new EventHandler(DisplayErrorMessage));
            }
        }

        //new event handler (what object calls it?)
        /*private Bitmap MapDefectData(object sender, EventArgs e)             //<-- WE ALREADY HAVE ALL THESE METHODS IN THE EMULATOR CLASS  (which class should have them?)
        {
            //how do we pass this method the IndexPage's component names?
            Bitmap bmp = new Bitmap(500, 500); //<-- my new code
            const char DELIM = ';';
            string[] sectors = ScanTrack.Split(DELIM);
            for (int y = 0; y < (sectors.Length - 1); y++)
            {
                string[] DefectVal = sectors[y].Split(',');
                int[] DefectValInt = Array.ConvertAll(DefectVal, int.Parse);
                for (int z = 0; z < DefectVal.Length; z++)
                {
                    switch (DefectValInt[2])
                    {
                        case 0:
                            break;
                        case 1:
                            bmp.SetPixel(DefectValInt[1], DefectValInt[0], Color.Blue);
                            TrackDefectCnt1++;
                            break;
                        case 2:
                            bmp.SetPixel(DefectValInt[1], DefectValInt[0], Color.BlueViolet);
                            TrackDefectCnt2++;
                            break;
                        case 3:
                            bmp.SetPixel(DefectValInt[1], DefectValInt[0], Color.Fuchsia);
                            TrackDefectCnt3++;
                            break;
                        case 4:
                            bmp.SetPixel(DefectValInt[1], DefectValInt[0], Color.Red);
                            TrackDefectCnt4++;
                            break;
                        case 5:
                            bmp.SetPixel(DefectValInt[1], DefectValInt[0], Color.Orange);
                            TrackDefectCnt5++;
                            break;
                        case 6:
                            bmp.SetPixel(DefectValInt[1], DefectValInt[0], Color.Yellow);
                            TrackDefectCnt6++;
                            break;
                        case 7:
                            bmp.SetPixel(DefectValInt[1], DefectValInt[0], Color.LightGreen);
                            TrackDefectCnt7++;
                            break;
                    }
                }
                return bmp;                 //<-- if this method is called on the index page it will return the Bitmap that can be displayed in pictureBox1
                //pictureBox1.Image = bmp;
            }
            // total track counts into the wafer scan counts after
            // each track is processed. Then clear track counts
            // and update Histogram bars.
            // scanDefectCnt passes values to the MaxHeight calculator 
            ScanDefectCnt1 += TrackDefectCnt1;
            ScanDefectCnt2 += TrackDefectCnt2;
            ScanDefectCnt3 += TrackDefectCnt3;
            ScanDefectCnt4 += TrackDefectCnt4;
            ScanDefectCnt5 += TrackDefectCnt5;
            ScanDefectCnt6 += TrackDefectCnt6;
            ScanDefectCnt7 += TrackDefectCnt7;

            TrackDefectCnt1 = 0;
            TrackDefectCnt2 = 0;
            TrackDefectCnt3 = 0;
            TrackDefectCnt4 = 0;
            TrackDefectCnt5 = 0;
            TrackDefectCnt6 = 0;
            TrackDefectCnt7 = 0;

            //PostHistData(def1, def2, def3,
            //                        def4, def5, def6, def7, maxHeightLabel, midHeightLabel, minHeightLabel,
             //                       scanDefectCountLabel1, size1CountLabel, scanDefectCountLabel2, size2CountLabel, scanDefectCountLabel3,
             //                       size3CountLabel, scanDefectCountLabel4, size4CountLabel, scanDefectCountLabel5, size5CountLabel,
              //                      scanDefectCountLabel6, size6CountLabel, scanDefectCountLabel7, size7CountLabel, totalSizeCountLabel,
              //                      DisHis);
        }

        public void CreateFile(ScanRecipe scanRecipe)       //pass recipe from RecipePage instead??
        {
            const string FOLDERNAME = @"C:\ScanBeta";
            string fileName = "\\Scan" + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + ".txt"; //<-- this will only print one forwardslash
            string filePath = FOLDERNAME + fileName;
            try
            {
                FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter writer = new StreamWriter(fileStream);

                writer.WriteLine(scanRecipe);
                //first line of the iniFile (i.e. the entire file) + the recipe used
                writer.WriteLine(ReadINIFile());

                writer.Close();
                fileStream.Close();
            }
            catch (Exception e)
            {
                //display an error message to the operator
                MessageBox.Show(e.Message);
            }
        }

        public string ReadINIFile()
        {
            const string FILENAME = @"C:\ScanBeta\SDA100ini.txt";
            string firstLine = "";
            try
            {
                FileStream fileStream = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(fileStream);

                firstLine = reader.ReadToEnd();   //<-- this file only has one long line of text; it gets called in CreateFile()

                reader.Close();
                fileStream.Close();
            }
            catch (Exception e)
            {
                //display an error message to the operator
                MessageBox.Show("This file doesn't exist. \n" + e.Message);
            }
            return firstLine;
        }

        public void UpdateSystemStatusLabels(Label lblSyS_FrontLimitX_Display, Label lblSyS_BackLimitX_Display, Label lblSyS_LeftLimitY_Display,
                                            Label lblSyS_RightLimitY_Display, Label lblSyS_TopLimitZ_Display, Label lblSyS_BottomLimitZ_Display,
                                            Label lblSyS_MainVacuum_Display, Label lblSyS_ChuckVacuum_Display, Label lblSys_DoorStatus_Display,
                                            Button doorStatusButton, TextBox txtSyS_XStagePosition, TextBox txtSyS_YStagePosition, TextBox txtSyS_ZStagePosition)
        {
            if (MxFrontLimitFlag == 0)
            {
                lblSyS_FrontLimitX_Display.BackColor = Color.Red;
            }
            else
            {
                lblSyS_FrontLimitX_Display.BackColor = Color.LawnGreen;
            }

            if (MxBackLimitFlag == 0)
            {
                lblSyS_BackLimitX_Display.BackColor = Color.Red;
            }
            else
            {
                lblSyS_BackLimitX_Display.BackColor = Color.LawnGreen;
            }
            if (MyLeftLimitFlag == 0)
            {
                lblSyS_LeftLimitY_Display.BackColor = Color.Red;
            }
            else
            {
                lblSyS_LeftLimitY_Display.BackColor = Color.LawnGreen;
            }

            if (MyRightLimitFlag == 0)
            {
                lblSyS_RightLimitY_Display.BackColor = Color.Red;
            }
            else
            {
                lblSyS_RightLimitY_Display.BackColor = Color.LawnGreen;
            }

            if (MzTopLimitFlag == 0)
            {
                lblSyS_TopLimitZ_Display.BackColor = Color.Red;
            }
            else
            {
                lblSyS_TopLimitZ_Display.BackColor = Color.LawnGreen;
            }

            if (MzBottomLimitFlag == 0)
            {
                lblSyS_BottomLimitZ_Display.BackColor = Color.Red;
            }
            else
            {
                lblSyS_BottomLimitZ_Display.BackColor = Color.LawnGreen;
            }

            if (VacMainFlag == 0)
            {
                lblSyS_MainVacuum_Display.Text = "Off";
                lblSyS_MainVacuum_Display.BackColor = Color.Red;
            }
            else
            {
                lblSyS_MainVacuum_Display.Text = "On";
                lblSyS_MainVacuum_Display.BackColor = Color.LawnGreen;
            }

            if (VacChuckFlag == 0)
            {
                lblSyS_ChuckVacuum_Display.Text = "Off";
                lblSyS_ChuckVacuum_Display.BackColor = Color.Red;
            }
            else
            {
                lblSyS_ChuckVacuum_Display.Text = "On";
                lblSyS_ChuckVacuum_Display.BackColor = Color.LawnGreen;

            }

            if (DoorOpenFlag == 0)
            {
                lblSys_DoorStatus_Display.Text = "Open";
                lblSys_DoorStatus_Display.BackColor = Color.Red;
                doorStatusButton.Text = "Close Door";
            }
            else
            {
                lblSys_DoorStatus_Display.Text = "Closed";
                lblSys_DoorStatus_Display.BackColor = Color.LawnGreen;
                doorStatusButton.Text = "Open Door";
            }

            txtSyS_XStagePosition.Text = Convert.ToString(MxPosAbsVal);
            txtSyS_YStagePosition.Text = Convert.ToString(MyPosAbsVal);
            txtSyS_ZStagePosition.Text = Convert.ToString(MzPosAbsVal);
        }*/

        /*public void MachineStatus(Label lblSyS_FrontLimitX_Display, Label lblSyS_BackLimitX_Display, Label lblSyS_LeftLimitY_Display,
                                            Label lblSyS_RightLimitY_Display, Label lblSyS_TopLimitZ_Display, Label lblSyS_BottomLimitZ_Display,
                                            Label lblSyS_MainVacuum_Display, Label lblSyS_ChuckVacuum_Display, Label lblSys_DoorStatus_Display,
                                            Button doorStatusButton, TextBox txtSyS_XStagePosition, TextBox txtSyS_YStagePosition, TextBox txtSyS_ZStagePosition)
        {
            UpdateStatus();
            UpdateSystemStatusLabels(lblSyS_FrontLimitX_Display, lblSyS_BackLimitX_Display, lblSyS_LeftLimitY_Display,
                                     lblSyS_RightLimitY_Display, lblSyS_TopLimitZ_Display, lblSyS_BottomLimitZ_Display,
                                            lblSyS_MainVacuum_Display, lblSyS_ChuckVacuum_Display, lblSys_DoorStatus_Display,
                                            doorStatusButton, txtSyS_XStagePosition, txtSyS_YStagePosition, txtSyS_ZStagePosition);
            Console.WriteLine("Machine Status: " + StatusMessage);                                                   //<-- is this for debugging?
        }*/

        public int GetMax(int val1, int val2)
        {
            if (val1 > val2)
            {
                return val1;
            }
            return val2;
        }
       /* public void PostHistData(TextBox def1, TextBox def2, TextBox def3,
                                    TextBox def4, TextBox def5, TextBox def6, TextBox def7, Label maxHeightLabel, Label midHeightLabel, Label minHeightLabel,
                                    Label scanDefectCountLabel1, Label size1CountLabel, Label scanDefectCountLabel2, Label size2CountLabel, Label scanDefectCountLabel3,
                                    Label size3CountLabel, Label scanDefectCountLabel4, Label size4CountLabel, Label scanDefectCountLabel5, Label size5CountLabel,
                                    Label scanDefectCountLabel6, Label size6CountLabel, Label scanDefectCountLabel7, Label size7CountLabel, Label totalSizeCountLabel,
                                    TextBox DisHis)
        {
            const int maxTextHeight = 100;
            int maxHeight = 0;
            int maxHeightBar = 0;


            def1.Size = new Size(50, ScanDefectCnt1);
            maxHeight = def1.Height;

            def2.Size = new Size(50, ScanDefectCnt2);
            maxHeight = GetMax(maxHeight, def2.Height);

            def3.Size = new Size(50, ScanDefectCnt3);
            maxHeight = GetMax(maxHeight, def3.Height);

            def4.Size = new Size(50, ScanDefectCnt4);
            maxHeight = GetMax(maxHeight, def4.Height);

            def5.Size = new Size(50, ScanDefectCnt5);
            maxHeight = GetMax(maxHeight, def5.Height);

            def6.Size = new Size(50, ScanDefectCnt6);
            maxHeight = GetMax(maxHeight, def6.Height);

            def7.Size = new Size(50, ScanDefectCnt7);
            maxHeight = GetMax(maxHeight, def7.Height);

            // processor to SNAP histogram Y Axis to fixed ranges
            if (maxHeight <= 50)
            {
                maxHeightBar = 50;
            }
            else if ((maxHeight > 50) && (maxHeight <= 100))
            {
                maxHeightBar = 100;
            }
            else if ((maxHeight > 100) && (maxHeight <= 250))
            {
                maxHeightBar = 250;
            }

            else if ((maxHeight > 250) && (maxHeight <= 500))
            {
                maxHeightBar = 500;
            }
            else if ((maxHeight > 500) && (maxHeight <= 1000))
            {
                maxHeightBar = 1000;
            }

            else if ((maxHeight > 1000) && (maxHeight <= 2500))
            {
                maxHeightBar = 2500;
            }
            else if ((maxHeight > 2500) && (maxHeight <= 5000))
            {
                maxHeightBar = 5000;
            }
            else if ((maxHeight > 5000) && (maxHeight <= 10000))
            {
                maxHeightBar = 10000;
            }
            else if ((maxHeight > 1000) && (maxHeight <= 25000))
            {
                maxHeightBar = 25000;
            }
            else if ((maxHeight > 25000) && (maxHeight <= 50000))
            {
                maxHeightBar = 50000;
            }
            else
            {
                maxHeightBar = 100000;
            }

            maxHeightLabel.Text = maxHeightBar.ToString();
            midHeightLabel.Text = (maxHeightBar / 2).ToString();
            minHeightLabel.Text = ("0");

            scanDefectCountLabel1.Text = ScanDefectCnt1.ToString();
            size1CountLabel.Text = ScanDefectCnt1.ToString();
            if (ScanDefectCnt1 > int.Parse(RejectLimitS1))
            {
                size1CountLabel.ForeColor = Color.Red;
            }
            scanDefectCountLabel2.Text = ScanDefectCnt2.ToString();
            size2CountLabel.Text = ScanDefectCnt2.ToString();
            if (ScanDefectCnt2 > int.Parse(Globals.rejectLimitS2))
            {
                lblSizeClass_PSize2_Limit.ForeColor = Color.Red;
            }
            lblScanDefectCnt3.Text = scanDefectCnt3.ToString();
            lblSizeClass_PSize3_Count.Text = scanDefectCnt3.ToString();
            if (scanDefectCnt3 > int.Parse(Globals.rejectLimitS3))
            {
                lblSizeClass_PSize3_Limit.ForeColor = Color.Red;
            }
            lblScanDefectCnt4.Text = scanDefectCnt4.ToString();
            lblSizeClass_PSize4_Count.Text = scanDefectCnt4.ToString();
            if (scanDefectCnt4 > int.Parse(Globals.rejectLimitS4))
            {
                lblSizeClass_PSize4_Limit.ForeColor = Color.Red;
            }
            lblScanDefectCnt5.Text = scanDefectCnt5.ToString();
            lblSizeClass_PSize5_Count.Text = scanDefectCnt5.ToString();
            if (scanDefectCnt5 > int.Parse(Globals.rejectLimitS5))
            {
                lblSizeClass_PSize5_Limit.ForeColor = Color.Red;
            }
            lblScanDefectCnt6.Text = scanDefectCnt6.ToString();
            lblSizeClass_PSize6_Count.Text = scanDefectCnt6.ToString();
            if (scanDefectCnt6 > int.Parse(Globals.rejectLimitS6))
            {
                lblSizeClass_PSize6_Limit.ForeColor = Color.Red;
            }
            lblScanDefectCnt7.Text = scanDefectCnt7.ToString();
            lblSizeClass_PSize7_Count.Text = scanDefectCnt7.ToString();
            if (scanDefectCnt7 > int.Parse(Globals.rejectLimitS7))
            {
                lblSizeClass_PSize7_Limit.ForeColor = Color.Red;
            }
            lblSizeClass_Total_Count.Text = (scanDefectCnt1 + scanDefectCnt2 + scanDefectCnt3
                + scanDefectCnt4 + scanDefectCnt5 + scanDefectCnt6 + scanDefectCnt7).ToString();
            if ((scanDefectCnt1 + scanDefectCnt2 + scanDefectCnt3
                + scanDefectCnt4 + scanDefectCnt5 + scanDefectCnt6 + scanDefectCnt7)
                > int.Parse(Globals.rejectLimitTotal))
            {
                lblSizeClass_PSize1_Limit.ForeColor = Color.Red;
            }

            //good to scale now replace def height with scaled height
            def1.Height = def1.Height * maxTextHeight / maxHeightBar;
            def2.Height = def2.Height * maxTextHeight / maxHeightBar;
            def3.Height = def3.Height * maxTextHeight / maxHeightBar;
            def4.Height = def4.Height * maxTextHeight / maxHeightBar;
            def5.Height = def5.Height * maxTextHeight / maxHeightBar;
            def6.Height = def6.Height * maxTextHeight / maxHeightBar;
            def7.Height = def7.Height * maxTextHeight / maxHeightBar;

            int disHisx = disHis.Location.X;
            int disHisy = disHis.Location.Y;
            int disHisHeight = disHis.Size.Height;
            int disHisWidth = disHis.Size.Width;

            int def1Am = def1.Size.Height;
            int def1x = def1.Location.X;
            int def1y = def1.Location.Y;

            int def2Am = def2.Size.Height;
            int def2x = def2.Location.X;
            int def2y = def2.Location.Y;

            int def3Am = def3.Size.Height;
            int def3x = def3.Location.X;
            int def3y = def3.Location.Y;

            int def4Am = def4.Size.Height;
            int def4x = def4.Location.X;
            int def4y = def4.Location.Y;

            int def5Am = def5.Size.Height;
            int def5x = def5.Location.X;
            int def5y = def5.Location.Y;

            int def6Am = def6.Size.Height;
            int def6x = def6.Location.X;
            int def6y = def6.Location.Y;

            int def7Am = def7.Size.Height;
            int def7x = def7.Location.X;
            int def7y = def7.Location.Y;

            int disYPoint = disHisy + disHisHeight;

            int bSyPoint1 = disYPoint - def1Am;
            int bSyPoint2 = disYPoint - def2Am;
            int bSyPoint3 = disYPoint - def3Am;
            int bSyPoint4 = disYPoint - def4Am;
            int bSyPoint5 = disYPoint - def5Am;
            int bSyPoint6 = disYPoint - def6Am;
            int bSyPoint7 = disYPoint - def7Am;

            def1.Location = new Point(def1x, bSyPoint1);
            def2.Location = new Point(def2x, bSyPoint2);
            def3.Location = new Point(def3x, bSyPoint3);
            def4.Location = new Point(def4x, bSyPoint4);
            def5.Location = new Point(def5x, bSyPoint5);
            def6.Location = new Point(def6x, bSyPoint6);
            def7.Location = new Point(def7x, bSyPoint7);

        }*/

        /*public void EdgeReject(PictureBox pictureBox1)
        {
            //int SizeofWaferMM = 125;
            //int EdgeRejctMM = 5;
            //int MapResolutionPixels = 500;
            int MapRadiusPixels;
            int PixelsPerMM;
            int EdgeRejectPixels;
            int WaferDiamPixels;
            int xPixelLoc;
            int yPixelLoc;
            int ZoneCenterPoint;

            // **** Setup all the variables for calculations - Second the DOUBLES for TRIG Math ****
            double j, i;
            double degrees;
            double angle;
            double sinAngle;
            double cosAngle;
            double ZoneRadiusPixels;

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            // **** Setup all the variables for calculations - Third the STRINGS ****
            // **** Initial Calculations ****
            PixelsPerMM = MapRes / WaferDiam;
            EdgeRejectPixels = PixelsPerMM * EdgeRej;
            WaferDiamPixels = PixelsPerMM * (WaferDiam);
            MapRadiusPixels = MapRes / 2;

            ZoneRadiusPixels = WaferDiamPixels / 2;
            ZoneCenterPoint = Convert.ToInt32(ZoneRadiusPixels) + EdgeRejectPixels;



            // **** TRIG Calculations to draw wafer edge line ****
            for (i = 0; i < 3; i++)
            {
                for (j = 0.2; j < 360;)
                {
                    degrees = j;
                    angle = Math.PI * degrees / 180.0;
                    sinAngle = Math.Sin(angle);
                    cosAngle = Math.Cos(angle);
                    xPixelLoc = MapRadiusPixels + Convert.ToInt32(MapRadiusPixels * cosAngle);
                    yPixelLoc = MapRadiusPixels + Convert.ToInt32(MapRadiusPixels * sinAngle);

                    ((Bitmap)pictureBox1.Image).SetPixel(xPixelLoc, yPixelLoc, Color.Black);
                    //bmp.SetPixel(xPixelLoc, yPixelLoc, Color.Black);
                    j = j + 0.2;
                }
            }

            for (i = 2; i < (EdgeRejectPixels + 2); i++)
            {
                for (j = 0.2; j < 360;)
                {
                    degrees = j;
                    angle = Math.PI * degrees / 180.0;
                    sinAngle = Math.Sin(angle);
                    cosAngle = Math.Cos(angle);
                    xPixelLoc = MapRadiusPixels + Convert.ToInt32((MapRadiusPixels - i) * cosAngle);
                    yPixelLoc = MapRadiusPixels + Convert.ToInt32((MapRadiusPixels - i) * sinAngle);

                    ((Bitmap)pictureBox1.Image).SetPixel(xPixelLoc, yPixelLoc, Color.DarkGray);
                    j = j + 0.2;
                }
            }
            bmp = pictureBox1.Image;
        }*/
    }
}
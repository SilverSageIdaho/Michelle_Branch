using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SDA100._1
{
    public partial class IndexPage : Form
    {
        //navbar objects
        public ConsolePage consolePage;
        public RecipePage recipePage;
        public StartPage startPage;
        public ScanDataPage scanDataPage;
        public IniFilesPage iniFilesPage;
        public MaintenancePage maintenancePage;
        //Emulator object
        Emulator emulator = new Emulator();
        //Bitmap objects
        Bitmap bmp = new Bitmap(500, 500);
        Bitmap ebmp = new Bitmap(500, 500);
        //Scanner object
        Scanner scanner = new Scanner();
        //SerialPort object//NEW CODE FROM JAC       
        SerialPort serialPort = new SerialPort();
        public IndexPage()
        {
            InitializeComponent();
            mainMenuTab.BackColor = Color.FromKnownColor(KnownColor.Highlight); 
            scanner.ScanComPorts();
                 //lbxLoadBox.Text = "New Recipe";
            //lbxLoadBox.DataSource = System.IO.File.ReadAllLines(@"C:\ScanBeta\SDA100rec.txt");
            //dataGridView1.Hide();
            //dataGridView1.ColumnCount = 3;
            //dataGridView1.Columns[0].Name = "Recipe Name";
            //dataGridView1.Columns[1].Name = "Edit Date";
            //dataGridView1.Columns[2].Name = "User ID";
                ///dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(2, 255, 0, 0);
            //PopulateRecipeList();
            //lbxScanDataFiles.DataSource = System.IO.Directory.GetFiles(@"C:\ScanBeta\", "Scan*.txt");
        }
        private void IndexPage_Load(object sender, EventArgs e)
        {
        }

        private void MainMenuTab_Click(object sender, EventArgs e)
        {
            //this is the current page
        }

        private void ConsoleTab_Click(object sender, EventArgs e)
        {
            this.Close();            //how do I count if there are more than 1 page open and close the previous ones? OR should I save (somehow) and then close?
            consolePage = new ConsolePage();
            consolePage.StartPosition = this.StartPosition;
            //set current tab back to original color
            mainMenuTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            consolePage.Show();          
        }

        private void StartupTab_Click(object sender, EventArgs e)
        {
            this.Close();
            startPage = new StartPage();
            startPage.StartPosition = this.StartPosition;
            //set current tab back to original color
            mainMenuTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            startPage.Show();
        }

        private void RecipeTab_Click(object sender, EventArgs e)
        {
            this.Close();            
            recipePage = new RecipePage();
            recipePage.StartPosition = this.StartPosition;
            recipePage.BringToFront();                              //<-- THIS IS NEW CODE
            //set current tab back to original color
            mainMenuTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            recipePage.Show();
        }

        private void ScanDataTab_Click(object sender, EventArgs e)
        {
            //lbxScanDataFiles.DataSource = System.IO.Directory.GetFiles(@"C:\ScanBeta\", "Scan*.txt");

            this.Close();
            scanDataPage = new ScanDataPage();
            scanDataPage.StartPosition = this.StartPosition;
            //set current tab back to original color
            mainMenuTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            scanDataPage.Show();
        }

        private void IniFilesTab_Click(object sender, EventArgs e)
        {
            this.Close();
            iniFilesPage = new IniFilesPage();
            iniFilesPage.StartPosition = this.StartPosition;
            //set current tab back to original color
            mainMenuTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            iniFilesPage.Show();
        }

        private void MaintenanceTab_Click(object sender, EventArgs e)
        {
            this.Close();
            maintenancePage = new MaintenancePage();
            maintenancePage.StartPosition = this.StartPosition;
            //set current tab back to original color
            mainMenuTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            maintenancePage.Show();
        }

        private void ProgressBarStatus(object sender, EventArgs e)
        {
            string prctComplete = scanner.InData.Remove(scanner.InData.Length - 2, 2);
            //prctComplete = Convert.ToDouble(scanner.InData) * 100;
            Console.WriteLine(prctComplete);
            scanProgressBar.Value = Convert.ToInt32(prctComplete);
        }
        private void DisplayErrorMessage(object sender, EventArgs e)
        {
            Console.WriteLine("Unknown Response: " + scanner.ScanUnknownMessage);
        }

        /*private void MachineStatus(Label lblSyS_FrontLimitX_Display, Label lblSyS_BackLimitX_Display, Label lblSyS_LeftLimitY_Display,
                                            Label lblSyS_RightLimitY_Display, Label lblSyS_TopLimitZ_Display, Label lblSyS_BottomLimitZ_Display,
                                            Label lblSyS_MainVacuum_Display, Label lblSyS_ChuckVacuum_Display, Label lblSys_DoorStatus_Display,
                                            Button doorStatusButton, TextBox txtSyS_XStagePosition, TextBox txtSyS_YStagePosition, TextBox txtSyS_ZStagePosition)
        {
            scanner.UpdateStatus();
            scanner.UpdateSystemStatusLabels(lblSyS_FrontLimitX_Display, lblSyS_BackLimitX_Display, lblSyS_LeftLimitY_Display,  //<-- do we really need to this here or should it be called from the scanner object
                                            lblSyS_RightLimitY_Display, lblSyS_TopLimitZ_Display, lblSyS_BottomLimitZ_Display,
                                            lblSyS_MainVacuum_Display, lblSyS_ChuckVacuum_Display, lblSys_DoorStatus_Display,
                                            doorStatusButton, txtSyS_XStagePosition, txtSyS_YStagePosition, txtSyS_ZStagePosition);
            Console.WriteLine("Machine Status: " + scanner.StatusMessage);                                                   //<-- is this for debugging?
        }*/

        /*
        private void ResponseData(object sender, EventArgs e)
        {
            //Console.WriteLine("Inside Response Data: " + Thread.CurrentThread.ManagedThreadId);
            //Console.WriteLine("Thread Name: " + Thread.CurrentThread.Name);
            Console.WriteLine("Response Data: " + Globals.scanReply); 
                        
            label16.Text = Globals.z_focus;

            if(Globals.errorMessage != null)
            {
                string title = "ERROR";
                MessageBox.Show(Globals.errorMessage, title);
                Globals.errorMessage = null;
            }
         //OLD CODE
            //if (Globals.scanReply == "!m\r")
            //{
                Console.WriteLine("Response Data: " + Globals.scanReply);                                
            //}
            //else
            //{
            //    Console.WriteLine("Response Data: " + Globals.scanReply);
            //    //serialPort1.Write("m");
            //}
    }*/      

        /*private void btnRun_Click(object sender, EventArgs e)
        {
            if (lblCCRecipeName_Current.Text == "None")
            {
                string message = "Clint! Until I'm smarter...you gotta select a recipe first!";
                string title = "Dustin Says";
                MessageBox.Show(message, title);
            }
            else
            {
                EdgeReject();

                trackDefectCnt1 = 0;
                trackDefectCnt2 = 0;
                trackDefectCnt3 = 0;
                trackDefectCnt4 = 0;
                trackDefectCnt5 = 0;
                trackDefectCnt6 = 0;
                trackDefectCnt7 = 0;

                scanDefectCnt1 = 0;
                scanDefectCnt2 = 0;
                scanDefectCnt3 = 0;
                scanDefectCnt4 = 0;
                scanDefectCnt5 = 0;
                scanDefectCnt6 = 0;
                scanDefectCnt7 = 0;

                PostHistData();
                serialPort1.Write("O"); //Turn chuck vac on
                CheckForComResponse("O");
                serialPort1.Write("n"); //Close door
                CheckForComResponse("n");
                serialPort1.Write("i"); //copy ini(uvw) to XYZ
                CheckForComResponse("i");
                serialPort1.Write("I"); //moves XY stage to chuck center and Z to prefocus
                CheckForComResponse("I");
                serialPort1.Write("f"); //focus Z
                CheckForComResponse("f");
                serialPort1.Write("G"); //Start scan                 
            }
        }*/

        /*private void btnStop_Click(object sender, EventArgs e)
        {
            serialPort1.Write("g"); // STOP Stage
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            if (btnLoad.Text == "LOAD")
            {            
                serialPort1.Write("P");   // Park Stage at preScan position
                CheckForComResponse("P");
                serialPort1.Write("o");     // Open door
                CheckForComResponse("o");
                serialPort1.Write("N");     //Turn chuck vac off
                CheckForComResponse("N");
                btnLoad.Text = "Rdy";
                btnRun.Enabled = true;
            }
            
        }
                private void button2_Click(object sender, EventArgs e) <-- DOOR BUTTON
        {
            if (Globals.doorCloseFlag == 0)
            {
                serialPort1.Write("n");
                Globals.doorCloseFlag = 1;
            }
            else
            {
                serialPort1.Write("o");
                Globals.doorCloseFlag = 0;
            }
        }
         */
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace SDA100._1
{
    class Emulator
    {
        /**************************/
        /*    CLASS PROPERTIES   */
        /************************/
        //scanner info?
        public string EiniOID { get; set; }
        public int EmapRes { get; set; }
        public int EwaferDiam { get; set; }
        public int EedgeRej { get; set; }
        public string EsectorSteps { get; set; }
        public string EtrackSteps { get; set; }
        public string EparkY { get; set; }
        public string EparkX { get; set; }
        public string EparkZ { get; set; }
        public string EcenterY { get; set; }
        public string EcenterX { get; set; }
        public string EpSize1Label { get; set; }
        public string EpSize2Label { get; set; }
        public string EpSize3Label { get; set; }
        public string EpSize4Label { get; set; }
        public string EpSize5Label { get; set; }
        public string EpSize6Label { get; set; }
        public string EpSize7Label { get; set; }
        public string EafTimeOut { get; set; }
        public string EdirData { get; set; }
        public string EdirRecipe { get; set; }
        public string EdirINI { get; set; }
        public string EdirErrorLog { get; set; }
        //recipe information
        public string ErecipeOID { get; set; }
        public string EeditDateTime { get; set; }
        public string ErecipeStatus { get; set; }
        public string ErecipeName { get; set; }
        public string EuserName { get; set; }
        public string EscanID { get; set; }
        public string EscanArea { get; set; }
        public string EzoneType { get; set; }
        public string EautoSave { get; set; }
        public string ErecipeNameDefault { get; set; } //is this still necessary?
        public string ErejectLimitS1 { get; set; }
        public string ErejectLimitS2 { get; set; }
        public string ErejectLimitS3 { get; set; }
        public string ErejectLimitS4 { get; set; }
        public string ErejectLimitS5 { get; set; }
        public string ErejectLimitS6 { get; set; }
        public string ErejectLimitS7 { get; set; }
        public string ErejectLimitTotal { get; set; }
        public string ErecipeComments { get; set; }
        //track defect counts
        public int EtrackDefectCnt1 { get; set; }
        public int EtrackDefectCnt2 { get; set; }
        public int EtrackDefectCnt3 { get; set; }
        public int EtrackDefectCnt4 { get; set; }
        public int EtrackDefectCnt5 { get; set; }
        public int EtrackDefectCnt6 { get; set; }
        public int EtrackDefectCnt7 { get; set; }
        //scan defect counts
        public int EscanDefectCnt1 { get; set; }
        public int EscanDefectCnt2 { get; set; }
        public int EscanDefectCnt3 { get; set; }
        public int EscanDefectCnt4 { get; set; }
        public int EscanDefectCnt5 { get; set; }
        public int EscanDefectCnt6 { get; set; }
        public int EscanDefectCnt7 { get; set; }

        /***********************/
        /*    CLASS METHODS   */
        /**********************/
        public int GetMax(int val1, int val2)
        {
            if (val1 > val2)
            {
                return val1;
            }
            return val2;
        }

        public void EMapDefectData(string[] eScanData, PictureBox eScanDataImage, TextBox edef1, TextBox edef2, TextBox edef3,
                                    TextBox edef4, TextBox edef5, TextBox edef6, TextBox edef7, Label maxHeightLabel, Label midHeightLabel, Label minHeightLabel,
                                    Label scanDefectCountLabel1, Label size1CountLabel, Label scanDefectCountLabel2, Label size2CountLabel, Label scanDefectCountLabel3,
                                    Label size3CountLabel, Label scanDefectCountLabel4, Label size4CountLabel, Label scanDefectCountLabel5, Label size5CountLabel,
                                    Label scanDefectCountLabel6, Label size6CountLabel, Label scanDefectCountLabel7, Label size7CountLabel, Label totalSizeCountLabel,
                                    TextBox eDisHis)
        {
            Bitmap ebmp = new Bitmap(500, 500);
            for (int x = 4; x < eScanData.Length; x++)
            {
                string eScanTrack = eScanData[x];
                const char DELIM = ';';
                string[] esectors = eScanTrack.Split(DELIM);
                for (int y = 0; y < (esectors.Length - 1); y++)
                {
                    string[] eDefectVal = esectors[y].Split(',');
                    int[] eDefectValInt = Array.ConvertAll(eDefectVal, int.Parse);
                    for (int z = 0; z < eDefectVal.Length; z++)
                    {
                        switch (eDefectValInt[2])
                        {
                            case 0:
                                break;
                            case 1:
                                ebmp.SetPixel(eDefectValInt[1], eDefectValInt[0], Color.Blue);
                                EtrackDefectCnt1++;
                                break;
                            case 2:
                                ebmp.SetPixel(eDefectValInt[1], eDefectValInt[0], Color.BlueViolet);
                                EtrackDefectCnt2++;
                                break;
                            case 3:
                                ebmp.SetPixel(eDefectValInt[1], eDefectValInt[0], Color.Fuchsia);
                                EtrackDefectCnt3++;
                                break;
                            case 4:
                                ebmp.SetPixel(eDefectValInt[1], eDefectValInt[0], Color.Red);
                                EtrackDefectCnt4++;
                                break;
                            case 5:
                                ebmp.SetPixel(eDefectValInt[1], eDefectValInt[0], Color.Orange);
                                EtrackDefectCnt5++;
                                break;
                            case 6:
                                ebmp.SetPixel(eDefectValInt[1], eDefectValInt[0], Color.Yellow);
                                EtrackDefectCnt6++;
                                break;
                            case 7:
                                ebmp.SetPixel(eDefectValInt[1], eDefectValInt[0], Color.LightGreen);
                                EtrackDefectCnt7++;
                                break;
                        }
                    }
                    eScanDataImage.Image = ebmp;

                }
                // total track counts into the wafer scan counts after
                // each track is processes. Then clear track counts
                // and update Histogram bars.
                // scanDefectCnt passes values to the MaxHeight calculator 
                EscanDefectCnt1 += EtrackDefectCnt1;
                EscanDefectCnt2 += EtrackDefectCnt2;
                EscanDefectCnt3 += EtrackDefectCnt3;
                EscanDefectCnt4 += EtrackDefectCnt4;
                EscanDefectCnt5 += EtrackDefectCnt5;
                EscanDefectCnt6 += EtrackDefectCnt6;
                EscanDefectCnt7 += EtrackDefectCnt7;

                EtrackDefectCnt1 = 0;
                EtrackDefectCnt2 = 0;
                EtrackDefectCnt3 = 0;
                EtrackDefectCnt4 = 0;
                EtrackDefectCnt5 = 0;
                EtrackDefectCnt6 = 0;
                EtrackDefectCnt7 = 0;

                EPostHistData(edef1, edef2, edef3, edef4, edef5, edef6, edef7, maxHeightLabel, midHeightLabel, minHeightLabel, scanDefectCountLabel1,
                                size1CountLabel, scanDefectCountLabel2, size2CountLabel, scanDefectCountLabel3, size3CountLabel, scanDefectCountLabel4, size4CountLabel,
                                scanDefectCountLabel5, size5CountLabel, scanDefectCountLabel6, size6CountLabel, scanDefectCountLabel7, size7CountLabel, totalSizeCountLabel, eDisHis);
            }
        }

        public void EPostHistData(TextBox edef1, TextBox edef2, TextBox edef3,
                                    TextBox edef4, TextBox edef5, TextBox edef6, TextBox edef7, Label maxHeightLabel, Label midHeightLabel, Label minHeightLabel,
                                    Label scanDefectCountLabel1, Label size1CountLabel, Label scanDefectCountLabel2, Label size2CountLabel, Label scanDefectCountLabel3,
                                    Label size3CountLabel, Label scanDefectCountLabel4, Label size4CountLabel, Label scanDefectCountLabel5, Label size5CountLabel,
                                    Label scanDefectCountLabel6, Label size6CountLabel, Label scanDefectCountLabel7, Label size7CountLabel, Label totalSizeCountLabel,
                                    TextBox eDisHis)
        {
            const int maxTextHeight = 100;
            int maxHeight = 0;
            int maxHeightBar = 0;


            edef1.Size = new Size(50, EscanDefectCnt1);
            maxHeight = edef1.Height;

            edef2.Size = new Size(50, EscanDefectCnt2);
            maxHeight = GetMax(maxHeight, edef2.Height);

            edef3.Size = new Size(50, EscanDefectCnt3);
            maxHeight = GetMax(maxHeight, edef3.Height);

            edef4.Size = new Size(50, EscanDefectCnt4);
            maxHeight = GetMax(maxHeight, edef4.Height);

            edef5.Size = new Size(50, EscanDefectCnt5);
            maxHeight = GetMax(maxHeight, edef5.Height);

            edef6.Size = new Size(50, EscanDefectCnt6);
            maxHeight = GetMax(maxHeight, edef6.Height);

            edef7.Size = new Size(50, EscanDefectCnt7);
            maxHeight = GetMax(maxHeight, edef7.Height);

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

            scanDefectCountLabel1.Text = EscanDefectCnt1.ToString();
            size1CountLabel.Text = EscanDefectCnt1.ToString();
            scanDefectCountLabel2.Text = EscanDefectCnt2.ToString();
            size2CountLabel.Text = EscanDefectCnt2.ToString();
            scanDefectCountLabel3.Text = EscanDefectCnt3.ToString();
            size3CountLabel.Text = EscanDefectCnt3.ToString();
            scanDefectCountLabel4.Text = EscanDefectCnt4.ToString();
            size4CountLabel.Text = EscanDefectCnt4.ToString();
            scanDefectCountLabel5.Text = EscanDefectCnt5.ToString();
            size5CountLabel.Text = EscanDefectCnt5.ToString();
            scanDefectCountLabel6.Text = EscanDefectCnt6.ToString();
            size6CountLabel.Text = EscanDefectCnt6.ToString();
            scanDefectCountLabel7.Text = EscanDefectCnt7.ToString();
            size7CountLabel.Text = EscanDefectCnt7.ToString();
            totalSizeCountLabel.Text = (EscanDefectCnt1 + EscanDefectCnt2 +
                EscanDefectCnt3 + EscanDefectCnt4 + EscanDefectCnt5
                + EscanDefectCnt6 + EscanDefectCnt7).ToString();

            //good to scale now replace def height with scaled height
            edef1.Height = edef1.Height * maxTextHeight / maxHeightBar;
            edef2.Height = edef2.Height * maxTextHeight / maxHeightBar;
            edef3.Height = edef3.Height * maxTextHeight / maxHeightBar;
            edef4.Height = edef4.Height * maxTextHeight / maxHeightBar;
            edef5.Height = edef5.Height * maxTextHeight / maxHeightBar;
            edef6.Height = edef6.Height * maxTextHeight / maxHeightBar;
            edef7.Height = edef7.Height * maxTextHeight / maxHeightBar;

            int edisHisx = eDisHis.Location.X;
            int edisHisy = eDisHis.Location.Y;
            int edisHisHeight = eDisHis.Size.Height;
            int edisHisWidth = eDisHis.Size.Width;

            int edef1Am = edef1.Size.Height;
            int edef1x = edef1.Location.X;
            int edef1y = edef1.Location.Y;

            int edef2Am = edef2.Size.Height;
            int edef2x = edef2.Location.X;
            int edef2y = edef2.Location.Y;

            int edef3Am = edef3.Size.Height;
            int edef3x = edef3.Location.X;
            int edef3y = edef3.Location.Y;

            int edef4Am = edef4.Size.Height;
            int edef4x = edef4.Location.X;
            int edef4y = edef4.Location.Y;

            int edef5Am = edef5.Size.Height;
            int edef5x = edef5.Location.X;
            int edef5y = edef5.Location.Y;

            int edef6Am = edef6.Size.Height;
            int edef6x = edef6.Location.X;
            int edef6y = edef6.Location.Y;

            int edef7Am = edef7.Size.Height;
            int edef7x = edef7.Location.X;
            int edef7y = edef7.Location.Y;

            int edisYPoint = edisHisy + edisHisHeight;

            int ebSyPoint1 = edisYPoint - edef1Am;
            int ebSyPoint2 = edisYPoint - edef2Am;
            int ebSyPoint3 = edisYPoint - edef3Am;
            int ebSyPoint4 = edisYPoint - edef4Am;
            int ebSyPoint5 = edisYPoint - edef5Am;
            int ebSyPoint6 = edisYPoint - edef6Am;
            int ebSyPoint7 = edisYPoint - edef7Am;

            edef1.Location = new Point(edef1x, ebSyPoint1);
            edef2.Location = new Point(edef2x, ebSyPoint2);
            edef3.Location = new Point(edef3x, ebSyPoint3);
            edef4.Location = new Point(edef4x, ebSyPoint4);
            edef5.Location = new Point(edef5x, ebSyPoint5);
            edef6.Location = new Point(edef6x, ebSyPoint6);
            edef7.Location = new Point(edef7x, ebSyPoint7);
        }
        public void EEdgeReject(Emulator emulator, Bitmap ebmp, PictureBox eScanDataImage)
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

            eScanDataImage.Image = new Bitmap(eScanDataImage.Width, eScanDataImage.Height);

            // **** Setup all the variables for calculations - Third the STRINGS ****
            // **** Initial Calculations ****
            PixelsPerMM = emulator.EmapRes / emulator.EwaferDiam;
            EdgeRejectPixels = PixelsPerMM * emulator.EedgeRej;
            WaferDiamPixels = PixelsPerMM * (emulator.EwaferDiam);
            MapRadiusPixels = emulator.EmapRes / 2;
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
                    ((Bitmap)eScanDataImage.Image).SetPixel(xPixelLoc, yPixelLoc, Color.Black);
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
                    ((Bitmap)eScanDataImage.Image).SetPixel(xPixelLoc, yPixelLoc, Color.DarkGray);
                    j = j + 0.2;
                }
            }
            ebmp = (Bitmap)eScanDataImage.Image;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDA100._1
{
    public partial class ScanDataPage : Form
    {
        //navbar objects
        public ConsolePage consolePage;
        public IndexPage mainMenuPage;
        public RecipePage recipePage;
        public StartPage startPage;
        public IniFilesPage iniFilesPage;
        public MaintenancePage maintenancePage;
        //class objects
        Emulator emulator = new Emulator();
        //Bitmap objects
        Bitmap bmp = new Bitmap(500, 500);
        Bitmap ebmp = new Bitmap(500, 500);

        public ScanDataPage()
        {
            InitializeComponent();
            //CreateScanMenu():  //<-- need to write method that gets list of all past scan results and displays it in the top left box (and they are clickable)
            scanDataTab.BackColor = Color.FromKnownColor(KnownColor.Highlight);
            //eScanData list
            /*string[] eScanData = System.IO.File.ReadAllLines(scanDataFilesBox.SelectedItem.ToString());  //<-- this is created on the index page (mainMenuPage) ERROR MESSAGE on page load!! = so I commented it out
            emulator.EMapDefectData(eScanData, emulator, ebmp, eScanDataImage, edef1, edef2, edef3,
                        edef4, edef5, edef6, edef7, maxHeightLabel, midHeightLabel, minHeightLabel,
                        scanDefectCountLabel1, size1CountLabel, scanDefectCountLabel2, size2CountLabel, scanDefectCountLabel3,
                        size3CountLabel, scanDefectCountLabel4, size4CountLabel, scanDefectCountLabel5, size5CountLabel,
                        scanDefectCountLabel6, size6CountLabel, scanDefectCountLabel7, size7CountLabel, totalSizeCountLabel,
                        eDisHis);
            emulator.EPostHistData(emulator, ebmp, edef1, edef2, edef3, edef4, edef5, edef6, edef7, maxHeightLabel, midHeightLabel, minHeightLabel,
                        scanDefectCountLabel1, size1CountLabel, scanDefectCountLabel2, size2CountLabel, scanDefectCountLabel3,
                        size3CountLabel, scanDefectCountLabel4, size4CountLabel, scanDefectCountLabel5, size5CountLabel,
                        scanDefectCountLabel6, size6CountLabel, scanDefectCountLabel7, size7CountLabel, totalSizeCountLabel,
                        eDisHis);
            emulator.EEdgeReject(emulator, ebmp, eScanDataImage);*/
        }
         
        private void ScanDataPage_Load(object sender, EventArgs e)
        {
        }

        private void MainMenuTab_Click(object sender, EventArgs e)
        {
            this.Close();
            mainMenuPage = new IndexPage();
            mainMenuPage.StartPosition = this.StartPosition;
            //set current tab back to original color
            scanDataTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            mainMenuPage.Show();
        }

        private void ConsoleTab_Click(object sender, EventArgs e)
        {
            this.Close();
            consolePage = new ConsolePage();
            consolePage.StartPosition = this.StartPosition;
            //set current tab back to original color
            scanDataTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            consolePage.Show();
        }

        private void StartTab_Click(object sender, EventArgs e)
        {
            this.Close();
            startPage = new StartPage();
            startPage.StartPosition = this.StartPosition;
            //set current tab back to original color
            scanDataTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            startPage.Show();
        }

        private void RecipeTab_Click(object sender, EventArgs e)
        {
            this.Close();
            recipePage = new RecipePage();
            recipePage.StartPosition = this.StartPosition;
            //set current tab back to original color
            scanDataTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            recipePage.Show();
        }

        private void ScanDataTab_Click(object sender, EventArgs e)
        {
            //this is the current page
        }

        private void IniFilesTab_Click(object sender, EventArgs e)
        {
            this.Close();
            iniFilesPage = new IniFilesPage();
            iniFilesPage.StartPosition = this.StartPosition;
            //set current tab back to original color
            scanDataTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            iniFilesPage.Show();
        }

        private void MaintenanceTab_Click(object sender, EventArgs e)
        {
            this.Close();
            maintenancePage = new MaintenancePage();
            maintenancePage.StartPosition = this.StartPosition;
            //set current tab back to original color
            scanDataTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            maintenancePage.Show();
        }

        private void ScanDataFilesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] eScanData = System.IO.File.ReadAllLines(scanDataFilesBox.SelectedItem.ToString());
            if (eScanData.Length > 0)      //<-- do we actually need this if statement?
            {
                string[] erecData = eScanData[0].Split(',');
                if (erecData.Length >= 21)
                {
                    emulator.ErecipeOID = erecData[0];
                    emulator.EeditDateTime = erecData[1];
                    emulator.ErecipeStatus = erecData[2];
                    emulator.ErecipeName = erecData[3];
                    emulator.EuserName = erecData[4];
                    emulator.EscanID = erecData[5];
                    emulator.EwaferDiam = int.Parse(erecData[6]);
                    emulator.EedgeRej = int.Parse(erecData[7]);
                    emulator.EscanArea = erecData[8];
                    emulator.EzoneType = erecData[9];
                    emulator.EautoSave = erecData[10];
                    emulator.ErecipeNameDefault = erecData[11]; //is this still necessary?
                    emulator.ErejectLimitS1 = erecData[12];
                    emulator.ErejectLimitS2 = erecData[13];
                    emulator.ErejectLimitS3 = erecData[14];
                    emulator.ErejectLimitS4 = erecData[15];
                    emulator.ErejectLimitS5 = erecData[16];
                    emulator.ErejectLimitS6 = erecData[17];
                    emulator.ErejectLimitS7 = erecData[18];
                    emulator.ErejectLimitTotal = erecData[19];
                    emulator.ErecipeComments = erecData[20];

                    size1LimitLabel.Text = emulator.ErejectLimitS1;
                    size2LimitLabel.Text = emulator.ErejectLimitS2;
                    size3LimitLabel.Text = emulator.ErejectLimitS3;
                    size4LimitLabel.Text = emulator.ErejectLimitS4;
                    size5LimitLabel.Text = emulator.ErejectLimitS5;
                    size6LimitLabel.Text = emulator.ErejectLimitS6;
                    size7LimitLabel.Text = emulator.ErejectLimitS7;
                    totalSizeLimitLabel.Text = emulator.ErejectLimitTotal;
                    /*lbleCCRecipeName_Value.Text = emulator.ErecipeName;        //<-- where are these labels used? (what tab) I can't find them on the data tab)
                    lbleCCWaferSize_Value.Text = emulator.EwaferDiam + "mm";

                    lbleCCEdgeReject_Value.Text = cbxSSEdgeReject_Set.Text + "mm";
                    lbleCCUserID_Value.Text = emulator.EuserName;
                    lbleCCScanID_Value.Text = emulator.EscanID;*/
                }
                else
                {
                    //<-- need error message to operator
                }
            }

            if (eScanData.Length > 1)
            {
                string[] einiData = eScanData[1].Split(',');
                if(einiData.Length >= 23)
                {
                    emulator.EiniOID = einiData[0];
                    emulator.EmapRes = int.Parse(einiData[1]);
                    //Emulator.ewaferDiam = int.Parse(einiData[2]); //Supplied with the recipe data
                    //Emulator.eedgeRej = int.Parse(einiData[3]);
                    emulator.EsectorSteps = einiData[4];
                    emulator.EtrackSteps = einiData[5];
                    emulator.EparkY = einiData[6];
                    emulator.EparkX = einiData[7];
                    emulator.EparkZ = einiData[8];
                    emulator.EcenterY = einiData[9];
                    emulator.EcenterX = einiData[10];
                    emulator.EpSize1Label = einiData[11];
                    emulator.EpSize2Label = einiData[12];
                    emulator.EpSize3Label = einiData[13];
                    emulator.EpSize4Label = einiData[14];
                    emulator.EpSize5Label = einiData[15];
                    emulator.EpSize6Label = einiData[16];
                    emulator.EpSize7Label = einiData[17];
                    emulator.EafTimeOut = einiData[18];
                    emulator.EdirData = einiData[19];
                    emulator.EdirRecipe = einiData[20];
                    emulator.EdirINI = einiData[21];
                    emulator.EdirErrorLog = einiData[22];
                    emulator.EEdgeReject(emulator, ebmp, eScanDataImage);
                    emulator.EMapDefectData(eScanData, eScanDataImage, edef1, edef2, edef3, edef4, edef5, edef6, edef7, maxHeightLabel,
                                            midHeightLabel, minHeightLabel, scanDefectCountLabel1, size1CountLabel, scanDefectCountLabel2, size2CountLabel,
                                            scanDefectCountLabel3, size3CountLabel, scanDefectCountLabel4, size4CountLabel, scanDefectCountLabel5,
                                            size5CountLabel, scanDefectCountLabel6, size6CountLabel, scanDefectCountLabel7, size7CountLabel,
                                            totalSizeCountLabel, eDisHis);
                }
                else
                {
                    //<-- do we need an error message here?
                }
            }
            else
            {
                //<-- do we need an error message here?
            }
        }
    }
}

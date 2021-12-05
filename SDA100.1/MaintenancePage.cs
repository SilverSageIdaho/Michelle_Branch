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
    public partial class MaintenancePage : Form
    {
        //navbar objects
        public IndexPage mainMenuPage;
        public ConsolePage consolePage;
        public RecipePage recipePage;
        public StartPage startPage;
        public ScanDataPage scanDataPage;
        public IniFilesPage iniFilesPage;
        //Scanner object
        Scanner scanner = new Scanner();
        //SerialPort object
        SerialPort serialPort = new SerialPort();
        public MaintenancePage()
        {
            InitializeComponent();
            maintenanceTab.BackColor = Color.FromKnownColor(KnownColor.Highlight);
            /*scanner.UpdateSystemStatusLabels(lblSyS_FrontLimitX_Display, lblSyS_BackLimitX_Display, lblSyS_LeftLimitY_Display,
                                            lblSyS_RightLimitY_Display, lblSyS_TopLimitZ_Display, lblSyS_BottomLimitZ_Display,
                                            lblSyS_MainVacuum_Display, lblSyS_ChuckVacuum_Display, lblSys_DoorStatus_Display,
                                            doorStatusButton, txtSyS_XStagePosition, txtSyS_YStagePosition, txtSyS_ZStagePosition);*/
        }

        private void MaintenancePage_Load(object sender, EventArgs e)
        {
        }

        private void MainMenuTab_Click(object sender, EventArgs e)
        {
            this.Close();
            mainMenuPage = new IndexPage();
            mainMenuPage.StartPosition = this.StartPosition;
            //set current tab back to original color
            maintenanceTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            mainMenuPage.Show();
        }

        private void ConsoleTab_Click(object sender, EventArgs e)
        {
            this.Close();
            consolePage = new ConsolePage();
            consolePage.StartPosition = this.StartPosition;
            //set current tab back to original color
            maintenanceTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            consolePage.Show();
        }

        private void StartTab_Click(object sender, EventArgs e)
        {
            this.Close();
            startPage = new StartPage();
            startPage.StartPosition = this.StartPosition;
            //set current tab back to original color
            maintenanceTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            startPage.Show();
        }

        private void RecipeTab_Click(object sender, EventArgs e)
        {
            this.Close();
            recipePage = new RecipePage();
            recipePage.StartPosition = this.StartPosition;
            //set current tab back to original color
            maintenanceTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            recipePage.Show();
        }

        private void ScanDataTab_Click(object sender, EventArgs e)
        {
            this.Close();
            scanDataPage = new ScanDataPage();
            scanDataPage.StartPosition = this.StartPosition;
            //set current tab back to original color
            maintenanceTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            scanDataPage.Show();
        }

        private void IniFilesTab_Click(object sender, EventArgs e)
        {
            this.Close();
            iniFilesPage = new IniFilesPage();
            iniFilesPage.StartPosition = this.StartPosition;
            //set current tab back to original color
            maintenanceTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            iniFilesPage.Show();
        }

        private void MaintenanceTab_Click(object sender, EventArgs e)
        {
            //this is the current page
        }
       
        /********************************************/
        /*    SYSTEM STATUS BUTTON CLICK EVENTS    */
        /******************************************/
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            serialPort.Write("m");
        }

        private void ReadPhaButton_Click(object sender, EventArgs e)
        {
            //<-- no code yet that I could find
        }
        /*****************************************/
        /*    XY MOTIONS BUTTON CLICK EVENTS    */
        /***************************************/
        private void FrontButton_Click(object sender, EventArgs e)
        {
            serialPort.Write("." + txtXYM_Set.Text + "F");
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            serialPort.Write("." + txtXYM_Set.Text + "R");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            serialPort.Write("." + txtXYM_Set.Text + "B");
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            serialPort.Write("." + txtXYM_Set.Text + "L");
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            serialPort.Write("H");
        }

        private void ParkButton_Click(object sender, EventArgs e)
        {
            serialPort.Write("P");
        }

        private void CenterButton_Click(object sender, EventArgs e)
        {
            serialPort.Write("i");
            serialPort.Write("I");
        }

        private void DoorStatusButton_Click(object sender, EventArgs e)
        {
            if (scanner.DoorOpenFlag == 1)
            {
                serialPort.Write("o");
                doorStatusButton.Text = "Close Door";
                scanner.DoorOpenFlag = 0;
                scanner.DoorCloseFlag = 1;
            }
            else
            {
                serialPort.Write("n");
                doorStatusButton.Text = "Open Door";
                scanner.DoorOpenFlag = 1;
                scanner.DoorCloseFlag = 0;
            }
        }

        private void VacuumStatusButton_Click(object sender, EventArgs e)
        {
            if (scanner.VacChuckFlag == 0)
            {
                serialPort.Write("O");
                vacuumStatusButton.Text = "Chuck Vac Off";
                //scanner.VacChuckFlag = 1;

            }
            else
            {
                serialPort.Write("N");
                vacuumStatusButton.Text = "Chuck Vac On";
                //scanner.VacChuckFlag = 0;

            }
        }
        /**************************************************/
        /*    XYZ ABS POSITIONING BUTTON CLICK EVENTS    */
        /************************************************/

        private void SetXButton_Click(object sender, EventArgs e)
        {
            serialPort.Write("." + txtXYM_SetX.Text + "X");
        }

        private void SetYButton_Click(object sender, EventArgs e)
        {
            serialPort.Write("." + txtXYM_SetY.Text + "Y");
        }

        private void SetZButton_Click(object sender, EventArgs e)
        {
            serialPort.Write("." + txtXYM_SetZ.Text + "Z");
        }
        /*****************************************/
        /*    Z MOTIONS BUTTON CLICK EVENTS     */
        /***************************************/
        private void UpButton_Click(object sender, EventArgs e)
        {
            serialPort.Write("." + txtZM_Set.Text + "U");
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            serialPort.Write("." + txtZM_Set.Text + "D");
        }
        /***************************************************/
        /*    UPDATE CONFIG VALUES BUTTON CLICK EVENTS    */
        /*************************************************/
        private void SaveXYInitButton_Click(object sender, EventArgs e) //these buttons are disabled until their click events are written
        {
            //<-- no code yet that I could find
        }

        private void SaveXYCenterButton_Click(object sender, EventArgs e)
        {
            //<-- no code yet that I could find
        }

        private void SaveXYParkButton_Click(object sender, EventArgs e)
        {
            //<-- no code yet that I could find
        }

        private void SaveZParkButton_Click(object sender, EventArgs e)
        {
            //<-- no code yet that I could find
        }
    }
}

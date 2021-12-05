using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDA100._1
{
    public partial class StartPage : Form
    {
        //navbar objects
        public IndexPage mainMenuPage;
        public ConsolePage consolePage;
        public RecipePage recipePage;
        public ScanDataPage scanDataPage;
        public IniFilesPage iniFilesPage;
        public MaintenancePage maintenancePage;
        //scanner object
        Scanner scanner = new Scanner();
        public StartPage()
        {
            InitializeComponent();
            startupTab.BackColor = Color.FromKnownColor(KnownColor.Highlight);
            SystemStartupCheck();
            //CREATE A SCANNER OBJECT HERE THAT WILL BE PASSED FROM FORM TO FORM?
        }

        private void StartPage_Load(object sender, EventArgs e)
        {
        }

        private void MainMenuTab_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenuPage = new IndexPage();
            mainMenuPage.StartPosition = this.StartPosition;
            //set current tab back to original color
            startupTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            mainMenuPage.Show();
        }

        private void ConsoleTab_Click(object sender, EventArgs e)
        {
            this.Hide();
            consolePage = new ConsolePage();
            consolePage.StartPosition = this.StartPosition;
            //set current tab back to original color
            startupTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            consolePage.Show();
        }

        private void StartTab_Click(object sender, EventArgs e)
        {
            //this is the current page
        }

        private void RecipeTab_Click(object sender, EventArgs e)
        {
            this.Hide();
            recipePage = new RecipePage();
            recipePage.StartPosition = this.StartPosition;
            //set current tab back to original color
            startupTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            recipePage.Show();
        }

        private void ScanDataTab_Click(object sender, EventArgs e)
        {
            this.Hide();
            scanDataPage = new ScanDataPage();
            scanDataPage.StartPosition = this.StartPosition;
            //set current tab back to original color
            startupTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            scanDataPage.Show();
        }

        private void IniFilesTab_Click(object sender, EventArgs e)
        {
            this.Hide();
            iniFilesPage = new IniFilesPage();
            iniFilesPage.StartPosition = this.StartPosition;
            //set current tab back to original color
            startupTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            iniFilesPage.Show();
        }

        private void MaintenanceTab_Click(object sender, EventArgs e)
        {
            this.Hide();
            maintenancePage = new MaintenancePage();
            maintenancePage.StartPosition = this.StartPosition;
            //set current tab back to original color
            startupTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            maintenancePage.Show();
        }

        private void SystemStartupCheck()
        {
            // loop through all the steps
            for (int x = 0; x <= 10; x++)
            {
                // perform each step and then increment the ProgressBar
                if (true == true)
                {
                    // perform the increment on the ProgressBar
                    startupProgressBar.PerformStep();
                }
            }
        }

        /*public static string CheckForErrors()
        {
            Scanner scanner = new Scanner();
            //Errors will match this regular expression
            Regex regex = new Regex("^![A-Za-z]{1}0{1}\r{1}$");
            string returnString = "";
            if (regex.IsMatch(scanner.InData) && scanner.IsError != true) //<-- I changed this to a new scanner boolean property; where is errorMessageDislayed coming from?
            {
                string[] letters = scanner.InData.Split(',');
                string letter = letters[1];
                //int maxFailedAttempts = 3;
                switch (letter)
                {
                    case "O":
                        returnString = "N";
                        //scanner.VacChuckFlag = 0;
                        scanner.ErrorMessage = "No wafer detected";
                        break;
                    case "o":
                        scanner.ErrorMessage = "Door failed to open";
                        scanner.DoorCloseFlag = 1;
                        Console.WriteLine("ERROR o");     //<-- does this need to display on the screen to the operator?
                        break;
                    case "n":
                        scanner.ErrorMessage = "Door failed to close";
                        scanner.DoorCloseFlag = 0;
                        break;
                    case "H":
                        scanner.ErrorMessage = "Failed to get to Home";
                        break;
                    default:
                        scanner.ErrorMessage = "Unknown error";
                        break;
                }
            }
            return returnString;
        }*/
    }
}

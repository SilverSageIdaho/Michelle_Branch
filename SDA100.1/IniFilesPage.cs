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
    public partial class IniFilesPage : Form
    {
        //navbar objects
        public ConsolePage consolePage;
        public IndexPage mainMenuPage;
        public RecipePage recipePage;
        public StartPage startPage;
        public ScanDataPage scanDataPage;
        public MaintenancePage maintenancePage;
        public IniFilesPage()
        {
            InitializeComponent();
            iniFilesTab.BackColor = Color.FromKnownColor(KnownColor.Highlight);
        }

        private void IniFilesPage_Load(object sender, EventArgs e)
        {
        }

        private void MainMenuTab_Click(object sender, EventArgs e)
        {
            this.Close();
            mainMenuPage = new IndexPage();
            mainMenuPage.StartPosition = this.StartPosition;
            //set current tab back to original color
            iniFilesTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            mainMenuPage.Show();
        }

        private void ConsoleTab_Click(object sender, EventArgs e)
        {
            this.Close();
            consolePage = new ConsolePage();
            consolePage.StartPosition = this.StartPosition;
            //set current tab back to original color
            iniFilesTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            consolePage.Show();
        }

        private void StartTab_Click(object sender, EventArgs e)
        {
            this.Close();
            startPage = new StartPage();
            startPage.StartPosition = this.StartPosition;
            //set current tab back to original color
            iniFilesTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            startPage.Show();
        }

        private void RecipeTab_Click(object sender, EventArgs e)
        {
            this.Close();
            recipePage = new RecipePage();
            recipePage.StartPosition = this.StartPosition;
            //set current tab back to original color
            iniFilesTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            recipePage.Show();
        }

        private void ScanDataTab_Click(object sender, EventArgs e)
        {
            this.Close();
            scanDataPage = new ScanDataPage();
            scanDataPage.StartPosition = this.StartPosition;
            //set current tab back to original color
            iniFilesTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            scanDataPage.Show();
        }

        private void IniFilesTab_Click(object sender, EventArgs e)
        {
            //this is the current page
        }

        private void MaintenanceTab_Click(object sender, EventArgs e)
        {
            this.Close();
            maintenancePage = new MaintenancePage();
            maintenancePage.StartPosition = this.StartPosition;
            //set current tab back to original color
            iniFilesTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            maintenancePage.Show();
        }
    }
}

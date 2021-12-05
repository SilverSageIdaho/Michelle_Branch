using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SDA100._1
{
    public partial class EditPage : Form
    {
        public RecipePage recipePage;
        public EditPage editPage;

        //variables to save required recipe info in and then display on the page
        string recipeTime = "";
        string name = "";
        string userId = "";
        string scanId = "";
        string autoSave = "";
        string description = "";
        string size1 = "";
        string size2 = "";
        string size3 = "";
        string size4 = "";
        string size5 = "";
        string size6 = "";
        string size7 = "";
        string totalSize = "";
        string areaScan = "";
        string edgeReject = "";
        string waferSize = "";
        //string zoneType = "";
        public EditPage()
        {
            InitializeComponent();

            ShowRecipeOnPage();
        }
        private void EditPage_Load(object sender, EventArgs e)
        {
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            recipePage = new RecipePage();
            recipePage.StartPosition = this.StartPosition;
            recipePage.Show();
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            this.Close();
            editPage = new EditPage();
            editPage.StartPosition = this.StartPosition;
            editPage.Show();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //update the old recipe to this new version
            //assign the new values on the page to an updated recipe string (should the date remain the same or be changed to today's date?)
            string editedRecipe = EditedRecipeString();
            //use the EDIT text file to file the old version on the master file
            const string FILENAME = @"C:\ScanBeta\SDA100recEDIT.txt";
            FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.ReadWrite);
            StreamReader reader = new StreamReader(inFile);
            StreamWriter writer = new StreamWriter(inFile);
            string recipeLine = reader.ReadLine();

            const string MASTERFILENAME = @"C:\ScanBeta\SDA100recEDIT.txt";
            FileStream masterInFile = new FileStream(MASTERFILENAME, FileMode.Open, FileAccess.ReadWrite);
            StreamReader masterReader = new StreamReader(masterInFile);
            StreamWriter masterWriter = new StreamWriter(masterInFile);
            string masterRecipeLine = masterReader.ReadLine();

            while(masterRecipeLine != null && masterRecipeLine != "")
            {
                if(masterRecipeLine == recipeLine)
                {
                    masterWriter.WriteLine(editedRecipe);
                }
                else
                {
                    masterWriter.WriteLine(masterRecipeLine);
                }
                masterRecipeLine = masterReader.ReadLine();
            }

            //delete the recipe in the edit file so it's ready for the next edit
            while(recipeLine != null)
            {
                writer.Write("");                   //<--I'm not 100% sure this will delete the contents correctly
                recipeLine = reader.ReadLine();
            }

            //close all readers, writers, and filestreams
            masterWriter.Close();
            masterReader.Close();
            masterInFile.Close();
            writer.Close();
            reader.Close();
            inFile.Close();

            //close this page and open back up the recipe page
            this.Close();
            recipePage = new RecipePage();
            recipePage.StartPosition = this.StartPosition;
            recipePage.Show();
        }


        private void ShowRecipeOnPage()
        {
            //open recipe file and retrieve the recipe
            const string FILENAME = @"C:\ScanBeta\SDA100recEDIT.txt";
            FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);
            string recipeLine = reader.ReadLine();

            //make sure there is a recipe in the file
            while (recipeLine != null)
            {
                //split up the recipe into individual parts
                string[] fields = recipeLine.Split(',');
                //store the fields we need to display in our variables
                recipeTime = fields[0];
                name = fields[2];
                userId = fields[3];
                scanId = fields[4];
                autoSave = fields[9];
                description = fields[19];
                size1 = fields[11];
                size2 = fields[12];
                size3 = fields[13];
                size4 = fields[14];
                size5 = fields[15];
                size6 = fields[16];
                size7 = fields[17];
                totalSize = fields[18];
                areaScan = fields[7];
                edgeReject = fields[6];
                waferSize = fields[5];
                //zoneType = fields[8];
                recipeLine = reader.ReadLine();
            }
            reader.Close();
            inFile.Close();

            //now display recipe's values in the text boxes
            recipeNameTextBox.Text = name;
            userIdTextBox.Text = userId;
            scanIdTextBox.Text = scanId;
            descriptionTextBox.Text = description;
            size1TextBox.Text = size1;
            size2TextBox.Text = size2;
            size3TextBox.Text = size3;
            size4TextBox.Text = size4;
            size5TextBox.Text = size5;
            size6TextBox.Text = size6;
            size7TextBox.Text = size7;
            sizeTotalTextBox.Text = totalSize;
            //display selected recipe's values in the combo boxes
            areaScanOptionBox.SelectedItem = areaScan;
            edgeRejectOptionBox.SelectedItem = edgeReject;
            waferSizeOptionBox.SelectedItem = waferSize;
            //zoneTypeOptionBox.SelectedItem = fields[8];  
        }

        private string EditedRecipeString()
        {
            string editedRecipe = "";

            editedRecipe += recipeTime + "," + "Active," + recipeNameTextBox.Text + ","
                            + userIdTextBox.Text + "," + scanIdTextBox.Text + "," + waferSizeOptionBox.SelectedItem + "," + edgeRejectOptionBox.SelectedItem + ","
                            + areaScanOptionBox.SelectedItem + "," + "0,"  //static value since the option box is currently disabled                       
                            + autoSave + "Text,";  //static value since we are deciding on if this is useful or not
            editedRecipe += size1TextBox.Text + "," + size2TextBox.Text + "," + size3TextBox.Text + ","
                        + size4TextBox.Text + "," + size5TextBox.Text + "," + size6TextBox.Text + ","
                        + size7TextBox.Text + "," + sizeTotalTextBox.Text + "," + descriptionTextBox.Text;

            return editedRecipe;
        }

        private void RecipeNameTextBox_Click(object sender, EventArgs e)
        {
            StartOSK();
        }

        private void UserIdTextBox_Click(object sender, EventArgs e)
        {
            StartOSK();
        }

        private void ScanIdTextBox_Click(object sender, EventArgs e)
        {
            StartOSK();
        }

        private void DescriptionTextBox_Click(object sender, EventArgs e)
        {
            StartOSK();
        }

        private void Size1TextBox_Click(object sender, EventArgs e)
        {
            StartOSK();
        }

        static void StartOSK()
        {
            if (Process.Start(@"C:\Windows\WinSxS\amd64_microsoft-windows-osk_31bf3856ad364e35_10.0.19041.1_none_60ade0eff94c37fc\osk.exe").Equals(Process.Start(@"C:\Windows\WinSxS\amd64_microsoft-windows-osk_31bf3856ad364e35_10.0.19041.1_none_60ade0eff94c37fc\osk.exe")))
            {
                //do nothing because a keyboard already exists
            }
            else
            {
                Process.Start(@"C:\Windows\WinSxS\amd64_microsoft-windows-osk_31bf3856ad364e35_10.0.19041.1_none_60ade0eff94c37fc\osk.exe");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDA100._1
{
    public partial class AddRecipePage : Form
    {
        public RecipePage recipePage;
        public AddRecipePage addRecipePage;

        //new recipe object
        ScanRecipe newRecipe = new ScanRecipe();

        public AddRecipePage()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                //add new recipe to the master recipe file
                newRecipe.SaveRecipe(CreateNewRecipeString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //finally we close this page and open back up the recipe page
            this.Close();
            recipePage = new RecipePage();
            recipePage.StartPosition = this.StartPosition;
            recipePage.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //close this page and go back to the Recipe page
            this.Close();
            recipePage = new RecipePage();
            recipePage.StartPosition = this.StartPosition;
            recipePage.Show();
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            //closes current screen and opens a new one
            this.Close();
            addRecipePage = new AddRecipePage();
            addRecipePage.StartPosition = this.StartPosition;
            addRecipePage.Show();
        }

        private string CreateNewRecipeString()
        {
            string thisRecipeString = "";
            thisRecipeString += DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + "," + "Active," + recipeNameTextBox.Text + ","
                        + userIdTextBox.Text + "," + scanIdTextBox.Text + "," + waferSizeOptionBox.SelectedItem + "," + edgeRejectOptionBox.SelectedItem + ","
                         + areaScanOptionBox.SelectedItem + "," + "0,";   //static value since the option box is currently disabled                       
            if (autoSaveCheckBox.Checked == true)
            {
                thisRecipeString += "true,";
            }
            else
            {
                thisRecipeString += "false,";
            }
            thisRecipeString += "Text,";   //static value since we are deciding on if this is useful or not
            thisRecipeString += size1TextBox.Text + "," + size2TextBox.Text + "," + size3TextBox.Text + ","
                        + size4TextBox.Text + "," + size5TextBox.Text + "," + size6TextBox.Text + ","
                        + size7TextBox.Text + "," + sizeTotalTextBox.Text + "," + descriptionTextBox.Text;
            return thisRecipeString;
        }

        private void AutoSaveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //checking this button saves the scans that WILL BE performed using the selected recipe
            if (autoSaveCheckBox.Checked == true)
            {
                newRecipe.AutoSave = "true";   //<-- DO I NEED TO SEND THIS VALUE TO THE SCANNER OBJECT OR WAFER SCAN OBJECT? 
            }
            else
            {
                newRecipe.AutoSave = "false";
            }
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
            if(Process.Start(@"C:\Windows\WinSxS\amd64_microsoft-windows-osk_31bf3856ad364e35_10.0.19041.1_none_60ade0eff94c37fc\osk.exe").Equals(Process.Start(@"C:\Windows\WinSxS\amd64_microsoft-windows-osk_31bf3856ad364e35_10.0.19041.1_none_60ade0eff94c37fc\osk.exe")))
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

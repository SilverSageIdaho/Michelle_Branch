using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Microsoft.VisualBasic.FileIO;

namespace SDA100._1
{
    public partial class RecipePage : Form
    {
        //navbar pages
        public IndexPage mainMenuPage;
        public ConsolePage consolePage;
        public StartPage startPage;
        public ScanDataPage scanDataPage;
        public IniFilesPage iniFilesPage;
        public MaintenancePage maintenancePage;
        //edit recipe page
        public EditPage editPage;
        //add recipe page
        public AddRecipePage addRecipePage;

        //lists to populate info boxes on the recipe page
        List<string> recipeNames = new List<string>();
        List<string> userIds = new List<string>();
        List<string> scanIds = new List<string>();
        List<string> waferSizes = new List<string>();
        List<string> edgeRejects = new List<string>();
        List<string> areaScans = new List<string>();
        List<string> zoneTypes = new List<string>();
        List<bool>   autoSaveChecks = new List<bool>();
        List<string> rejectLimits1 = new List<string>();
        List<string> rejectLimits2 = new List<string>();
        List<string> rejectLimits3 = new List<string>();
        List<string> rejectLimits4 = new List<string>();
        List<string> rejectLimits5 = new List<string>();
        List<string> rejectLimits6 = new List<string>();
        List<string> rejectLimits7 = new List<string>();
        List<string> rejectLimitsTotal = new List<string>();
        List<string> recipeComments = new List<string>();
        //lists to search through to find certain recipeMenu items
        List<ToolStripMenuItem> items = new List<ToolStripMenuItem>();
        List<string> recipeTimes = new List<string>();

        //ScanRecipe object
        ScanRecipe scanRecipe = new ScanRecipe();
        
        public RecipePage()
        {
            InitializeComponent();
            CreateRecipeMenu();    
            recipeTab.BackColor = Color.FromKnownColor(KnownColor.Highlight);
            recipeMenu.CanOverflow = true;
        }

        private void RecipePage_Load(object sender, EventArgs e)
        {
        }

        private void MainMenuTab_Click(object sender, EventArgs e)
        {
            this.Close();
            mainMenuPage = new IndexPage();
            mainMenuPage.StartPosition = this.StartPosition;
            //set current tab back to original color
            recipeTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            mainMenuPage.Show();
        }

        private void ConsoleTab_Click(object sender, EventArgs e)
        {
            this.Close();
            consolePage = new ConsolePage();
            consolePage.StartPosition = this.StartPosition;
            //set current tab back to original color
            consoleTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            consolePage.Show();
        }

        private void StartTab_Click(object sender, EventArgs e)
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
            //this is the current page
        }

        private void ScanDataTab_Click(object sender, EventArgs e)
        {
            this.Close();
            scanDataPage = new ScanDataPage();
            scanDataPage.StartPosition = this.StartPosition;
            //set current tab back to original color
            scanDataTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            scanDataPage.Show();
        }

        private void IniFilesTab_Click(object sender, EventArgs e)
        {
            this.Close();
            iniFilesPage = new IniFilesPage();
            iniFilesPage.StartPosition = this.StartPosition;
            //set current tab back to original color
            iniFilesTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            iniFilesPage.Show();
        }

        private void MaintenanceTab_Click(object sender, EventArgs e)
        {
            this.Close();
            maintenancePage = new MaintenancePage();
            maintenancePage.StartPosition = this.StartPosition;
            //set current tab back to original color
            maintenanceTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            maintenancePage.Show();
        }


        private void AutoSaveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //checking this button saves the scans that WILL BE performed using the selected recipe
            if (autoSaveCheckBox.Checked == true)
            {
                scanRecipe.AutoSave = "true";   //<-- DO I NEED TO SEND THIS VALUE TO THE SCANNER OBJECT OR WAFER SCAN OBJECT? 
            }
            else
            {
                scanRecipe.AutoSave = "false";
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            //first we need to save the selected recipe to a variable
            string recipeToLoad = CreateSelectedRecipeString();

            //then we need to save it to a new file (so it can be easily retrieved on the index page)
            const string FILENAME = @"C:\ScanBeta\SDA100recLOAD.txt";
            try
            {
                FileStream outFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Write);
                StreamWriter writer = new StreamWriter(outFile);
                writer.Write(recipeToLoad);
                writer.Close();
                outFile.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            //finally we close this page and open the index page
            this.Close();
            mainMenuPage = new IndexPage();
            mainMenuPage.StartPosition = this.StartPosition;
            mainMenuPage.Show();

            //DO WE NEED THE CODE BELOW??? DOES IT NEED TO BE MOVED TO THE INDEX PAGE?

            //serialPort1.Write("." + scanRecipe.WaferDiam + "d");  //<-- what is serialPort1 ?    
            //serialPort1.Write("." + scanRecipe.EdgeRej + "e");
        }

        private void SaveButton_Click(object sender, EventArgs e)  //this should really be named CreateNewRecipe_Click (can I rename it w/out deleting the button and remaking it?)
        {                   
                //all this button does is open the addRecipe page
                this.Close();
                AddRecipePage addRecipePage = new AddRecipePage();
                addRecipePage.StartPosition = this.StartPosition;
                addRecipePage.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            //first we need to get the recipe and save it to a variable
            string recipeToEdit = CreateSelectedRecipeString();

            //then we need to save it to a new file (so it can be easily retrieved on the edit page)
            const string FILENAME = @"C:\ScanBeta\SDA100recEDIT.txt";
            try
            {
                FileStream outFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Write);
                StreamWriter writer = new StreamWriter(outFile);
                writer.Write(recipeToEdit);
                writer.Close();
                outFile.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            //finally we close this page and open the edit page
            this.Close();
            editPage = new EditPage();
            editPage.StartPosition = this.StartPosition;            
            editPage.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //first we need to get the recipe and save it to a variable
            string recipeToDelete = CreateSelectedRecipeString();
            //MessageBox.Show(recipeToDelete);      //message box to help debug

            //then we need to erase the recipe from the master file so we open recipe file in ReadWrite Mode
            const string FILENAME = @"C:\ScanBeta\SDA100rec2.txt";
            try
            {
                FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(inFile);
                FileStream outFile = new FileStream(@"C:\ScanBeta\SDA100rec3.txt", FileMode.CreateNew, FileAccess.Write);
                StreamWriter writer = new StreamWriter(outFile);

                string recipeLine = reader.ReadLine();
                //loop through the master file to find this recipe
                while (recipeLine != null)
                {
                    //loop through all the lines to find the one that match the selected recipe
                    if (recipeLine == recipeToDelete)
                    {
                          //we delete the matching recipe by not writing it to the new file
                         //MessageBox.Show("Debug message:" + recipeToDelete + "\n" + recipeLine);            //message box to help debug                       
                    }
                    else
                    {
                        writer.WriteLine(recipeLine);
                    }
                    recipeLine = reader.ReadLine();
                }               
                writer.Close();
                outFile.Close();
                reader.Close();
                inFile.Close();
                //now delete the original file and rename the new file (that doesn't contain the recipe that was selected for deletion)
                FileSystem.DeleteFile(@"C:\ScanBeta\SDA100rec2.txt");
                FileSystem.RenameFile(@"C:\ScanBeta\SDA100rec3.txt", "SDA100rec2.txt");
            }
            catch (Exception error)
            {
                //display an error message to the operator
                MessageBox.Show("Something went wrong. \n" + error.Message);
            }
            //refresh the page to update all the lists and remove the recipe from the recipe menu
            this.Close();
            RecipePage recipePage = new RecipePage();
            recipePage.StartPosition = this.StartPosition;
            recipePage.Show();
        }

        private void ShowRecipeOnPage(int i)
        {
            if (items[i].BackColor == Color.FromKnownColor(KnownColor.Highlight))  //i is being found and passed by the calling method
            {
                //display selected recipe's values in the text boxes
                recipeNameTextBox.Text = recipeNames[i];
                userIdTextBox.Text = userIds[i];
                scanIdTextBox.Text = scanIds[i];
                descriptionTextBox.Text = recipeComments[i];
                size1TextBox.Text = rejectLimits1[i];
                size2TextBox.Text = rejectLimits2[i];
                size3TextBox.Text = rejectLimits3[i];
                size4TextBox.Text = rejectLimits4[i];
                size5TextBox.Text = rejectLimits5[i];
                size6TextBox.Text = rejectLimits6[i];
                size7TextBox.Text = rejectLimits7[i];
                sizeTotalTextBox.Text = rejectLimitsTotal[i];
                //if auto save was originally checked, make sure it is checked now
                if (autoSaveChecks[i] == true)
                {
                    autoSaveCheckBox.Checked = true;
                }
                else
                {
                    autoSaveCheckBox.Checked = false;
                }
                //display selected recipe's values in the combo boxes
                areaScanOptionBox.SelectedItem = areaScans[i];
                edgeRejectOptionBox.SelectedItem = edgeRejects[i];
                waferSizeOptionBox.SelectedItem = waferSizes[i];
                //zoneTypeOptionBox.SelectedItem = zoneTypes[i];
            }
        }

        /*private string CreateNewRecipeString()  
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
        }*/
        private string CreateSelectedRecipeString()
        {
            string thisRecipeString = "";
            string recipeTime = "";
            //retrieve selected recipe's stored creation time
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].BackColor == Color.FromKnownColor(KnownColor.Highlight))
                {
                    recipeTime = recipeTimes[i];
                }
            }
                    thisRecipeString += recipeTime + "," + "Active," + recipeNameTextBox.Text + ","
                        + userIdTextBox.Text + "," + scanIdTextBox.Text + "," + waferSizeOptionBox.SelectedItem + "," + edgeRejectOptionBox.SelectedItem + ","
                         + areaScanOptionBox.SelectedItem + "," + "0,";  //static value since the option box is currently disabled                       
            if (autoSaveCheckBox.Checked == true)
            {
                thisRecipeString += "true,";
            }
            else
            {
                thisRecipeString += "false,";
            }
            thisRecipeString += "Text,";  //static value since we are deciding on if this is useful or not
            thisRecipeString += size1TextBox.Text + "," + size2TextBox.Text + "," + size3TextBox.Text + ","
                        + size4TextBox.Text + "," + size5TextBox.Text + "," + size6TextBox.Text + ","
                        + size7TextBox.Text + "," + sizeTotalTextBox.Text + "," + descriptionTextBox.Text;
            return thisRecipeString;
        }

        private void Recipe_Click(object sender, EventArgs e)
        {
            //need a var to hold the index number of the sending recipe so we can pass it to ShowRecipeOnPage()
            int itemIndex = 0;
            //need to loop through the list of items to get the item's list index number
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i] == sender)
                {
                    items[i].BackColor = Color.FromKnownColor(KnownColor.Highlight);
                    //changing the color will make this recipe evaluate to true when ShowRecipeOnPage() is called
                    itemIndex = i;
                }
                else
                {
                    //make sure the other buttons have the regular background color
                    items[i].BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
                }
                ShowRecipeOnPage(itemIndex);
            }
        }      
        
        private void CreateRecipeMenu()
        {
            //open recipe file
            const string FILENAME = @"C:\ScanBeta\SDA100rec2.txt";
            FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);
            string recipeLine = reader.ReadLine();

            //make sure there are recipes in the file
            while (recipeLine != null && recipeLine != "")
            {
                //split up the recipe into individual parts
                string[] fields = recipeLine.Split(',');
                //add the recipe to the ListView 
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.AutoSize = false;
                item.Size = new Size(600, 20);
                item.Alignment = ToolStripItemAlignment.Left;              
                item.Text = fields[2] + "    " + fields[3] + "    " + fields[0];  //recipe name + userID + DateTime string
                item.TextAlign = ContentAlignment.MiddleCenter;
                item.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
                item.Margin = new Padding(0, 0, 0, 20);
                item.DisplayStyle = ToolStripItemDisplayStyle.Text;
                //need to add a DateTime property to the item so we can sort by DateTime and I'm STORING IT IN the Name property
                item.Name = fields[0];
                string itemTime = item.Name;
                recipeTimes.Add(itemTime);
                //item needs a click event
                item.Click += Recipe_Click;
                //item needs overflow property
                item.Overflow = ToolStripItemOverflow.AsNeeded;
                //add new item to the recipeMenu item list BUT wait to add them to the recipeMenu
                items.Add(item);
                //add all of the other recipe information to corresponding lists for later use
                string recipeName = fields[2];
                recipeNames.Add(recipeName);
                string userId = fields[3];
                userIds.Add(userId);
                string scanId = fields[4];
                scanIds.Add(scanId);
                string waferSize = fields[5];
                waferSizes.Add(waferSize);
                string edgeReject = fields[6];
                edgeRejects.Add(edgeReject);
                string scanArea = fields[7];
                areaScans.Add(scanArea);
                string zoneType = fields[8];
                zoneTypes.Add(zoneType);
                string autoSaveCheck = fields[9];
                if (autoSaveCheck == "true")
                {
                    autoSaveChecks.Add(true);
                }
                else
                {
                    autoSaveChecks.Add(false);
                }
                //what is index 10 going to be used for?
                string rejectLimit1 = fields[11];
                rejectLimits1.Add(rejectLimit1);
                string rejectLimit2 = fields[12];
                rejectLimits2.Add(rejectLimit2);
                string rejectLimit3 = fields[13];
                rejectLimits3.Add(rejectLimit3);
                string rejectLimit4 = fields[14];
                rejectLimits4.Add(rejectLimit4);
                string rejectLimit5 = fields[15];
                rejectLimits5.Add(rejectLimit5);
                string rejectLimit6 = fields[16];
                rejectLimits6.Add(rejectLimit6);
                string rejectLimit7 = fields[17];
                rejectLimits7.Add(rejectLimit7);
                string rejectLimitTotal = fields[18];
                rejectLimitsTotal.Add(rejectLimitTotal);
                string recipeComment = fields[19];
                recipeComments.Add(recipeComment);
                //continue to next recipe
                recipeLine = reader.ReadLine();
            }
            reader.Close();
            inFile.Close();
            //sort the items List before adding them to the recipeMenu; since the last recipe read by the stream reader should be the most recent recipe, we can just reverse the List
            items.Reverse();
            //reverse all of the other lists so their index numbers still correspond
            recipeNames.Reverse();
            userIds.Reverse();
            scanIds.Reverse();
            waferSizes.Reverse();
            edgeRejects.Reverse();
            areaScans.Reverse();
            zoneTypes.Reverse();
            autoSaveChecks.Reverse();
            rejectLimits1.Reverse();
            rejectLimits2.Reverse();
            rejectLimits3.Reverse();
            rejectLimits4.Reverse();
            rejectLimits5.Reverse();
            rejectLimits6.Reverse();
            rejectLimits7.Reverse();
            rejectLimitsTotal.Reverse();
            recipeComments.Reverse();
            recipeTimes.Reverse();
            //now we add the recipe items one by one to the recipeMenu
            for (int i = 0; i < items.Count; i++)
            {
                //finally, we need to change the first item's background color so it can be loaded onto the page right after the page is initialized
                if (i == 0)
                {
                    items[i].BackColor = Color.FromKnownColor(KnownColor.Highlight);
                }
                recipeMenu.Items.Add(items[i]);
            }
            //call ShowRecipeOnPage() and pass it the first array index so the most recent recipe is pre-loaded into the text boxes
            if(items.Count > 0)
            {
                ShowRecipeOnPage(0);
            }
        }
    }
}

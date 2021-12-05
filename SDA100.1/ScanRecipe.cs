using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace SDA100._1
{
    class ScanRecipe
    {
        /**************************/
        /*   CLASS CONSTRUCTORS  */
        /************************/

        //constructor that takes 0 arguments = "empty" recipe that can be "filled"
        public ScanRecipe()
        {
        }

        //constructor that takes 20 arguments <-- I don't think we'll need to use this
        public ScanRecipe(string recipeName, string userID, string scanID, string description, string waferSize, string edgeReject, string scanArea, string autoSave, string rejectLimit1, 
                            string rejectLimit2, string rejectLimit3, string rejectLimit4, string rejectLimit5, string rejectLimit6,  string rejectLimit7, string rejectLimitTotal)
        {
            //default value
            string time = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            time = RecipeTime;
            //default value
            string status = "Active";
            status = RecipeStatus;
            recipeName = RecipeName;
            userID = UserID;
            scanID = ScanID;
            description = RecipeComments;
            waferSize = WaferSize;
            edgeReject = EdgeReject;
            scanArea = ScanArea;
            //default value for now
            string zoneType = "5";
            zoneType = ZoneType;
            autoSave = AutoSave;
            //default value
            string defaultName = "unNamedScan";
            defaultName = RecipeNameDefault;
            rejectLimit1 = RejectLimit1;
            rejectLimit2 = RejectLimit2;
            rejectLimit3 = RejectLimit3;
            rejectLimit4 = RejectLimit4;
            rejectLimit5 = RejectLimit5;
            rejectLimit6 = RejectLimit6;
            rejectLimit7 = RejectLimit7;
            rejectLimitTotal = RejectLimitTotal;
        }

        /***********************/
        /*   CLASS PROPERTIES  */
        /***********************/

        public string RecipeTime { get; set; }
        public string RecipeStatus { get; set; }
        public string RecipeName { get; set; }
        public string UserID { get; set; }
        public string ScanID { get; set; }
        public string RecipeComments { get; set; }
        public string EdgeReject { get; set; }
        public string ScanArea { get; set; }
        public string WaferSize { get; set; }
        public string ZoneType { get; set; }
        public string AutoSave { get; set; }
        public string RecipeNameDefault { get; set; }
        public string RejectLimit1 { get; set; }
        public string RejectLimit2 { get; set; }
        public string RejectLimit3 { get; set; }
        public string RejectLimit4 { get; set; }
        public string RejectLimit5 { get; set; }
        public string RejectLimit6 { get; set; }
        public string RejectLimit7 { get; set; }
        public string RejectLimitTotal { get; set; }

        /***********************/
        /*    CLASS METHODS   */
        /**********************/

        public void SaveRecipe(string recipeString)
        {
            //open recipe master file on local storage
            //const string FILENAME = @"C:\ScanBeta\SDA100rec.txt";
            const string FILENAME = @"C:\ScanBeta\SDA100rec2.txt";  //<-- delete after testing
            //check to see if the file is empty
            FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);
            string recipeLine = reader.ReadLine();
            if(recipeLine == null)
            {
                reader.Close();
                inFile.Close();
                try
                {
                    FileStream fileStream = new FileStream(FILENAME, FileMode.Append, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(fileStream);
                    //if this is the first recipe in the file we need to save it WITHOUT a newline character
                    writer.Write(recipeString);
                    //make sure to close recipe master file
                    writer.Close();
                    fileStream.Close();
                }
                catch (FileNotFoundException e)
                {
                    //send message to operator
                    MessageBox.Show(e.Message + " The file you are trying to save to does not exist.");
                }
            }
            else
            {
                reader.Close();
                inFile.Close();
                //otherwise we want to save it WITH a newline character before the recipe string
                try
                {
                    FileStream fileStream = new FileStream(FILENAME, FileMode.Append, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(fileStream);
                    //save new recipe by appending it to the bottom of the file
                    writer.Write("\n" + recipeString);
                    //make sure to close recipe master file
                    writer.Close();
                    fileStream.Close();
                }
                catch(FileNotFoundException e)
                {
                    //send message to operator
                    MessageBox.Show(e.Message + " The file you are trying to save to does not exist.");
                }
            }
        }
    }
}

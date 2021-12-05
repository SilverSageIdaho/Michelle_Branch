using MindFusion.UI.Wpf;
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
    public partial class ConsolePage : Form
    {
        //navbar objects
        public IndexPage mainMenuPage;
        public RecipePage recipePage;
        public StartPage startPage;
        public ScanDataPage scanDataPage;
        public IniFilesPage iniFilesPage;
        public MaintenancePage maintenancePage;

        public ConsolePage()
        {
            InitializeComponent();
            consoleTab.BackColor = Color.FromKnownColor(KnownColor.Highlight);
        }

        private void ConsolePage_Load(object sender, EventArgs e)
        {
        }

        private void MainMenuTab_Click(object sender, EventArgs e)
        {
            this.Close();
            mainMenuPage = new IndexPage();
            mainMenuPage.StartPosition = this.StartPosition;
            //set current tab back to original color
            consoleTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            mainMenuPage.Show();
        }

        private void ConsoleTab_Click(object sender, EventArgs e)
        {
            //this is the current page
        }

        private void StartTab_Click(object sender, EventArgs e)
        {
            this.Close();
            startPage = new StartPage();
            startPage.StartPosition = this.StartPosition;
            //set current tab back to original color
            consoleTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            startPage.Show();
        }

        private void RecipeTab_Click(object sender, EventArgs e)
        {
            this.Close();
            recipePage = new RecipePage();
            recipePage.StartPosition = this.StartPosition;
            //set current tab back to original color
            consoleTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            recipePage.Show();
        }

        private void ScanDataTab_Click(object sender, EventArgs e)
        {
            this.Close();
            scanDataPage = new ScanDataPage();
            scanDataPage.StartPosition = this.StartPosition;
            //set current tab back to original color
            consoleTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            scanDataPage.Show();
        }

        private void IniFilesTab_Click(object sender, EventArgs e)
        {
            this.Close();
            iniFilesPage = new IniFilesPage();
            iniFilesPage.StartPosition = this.StartPosition;
            //set current tab back to original color
            consoleTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            iniFilesPage.Show();
        }

        private void MaintenanceTab_Click(object sender, EventArgs e)
        {
            this.Close();
            maintenancePage = new MaintenancePage();//can I save any current changes to the page and then pass them to this constructor?
            maintenancePage.StartPosition = this.StartPosition;
            //set current tab back to original color
            consoleTab.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            maintenancePage.Show();
        }


        private void TeensyCommandsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ALL OF THESE ACTIONS NEED TO WAIT TO EXECUTE UNTIL THE SEND BUTTON IS CLICKED
            //so the switch cases have been moved into the SubmitButton_Click Event Handler
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            sender = teensyCommandsComboBox.SelectedItem;
            //GetScanner();  <--NEED TO CODE THIS because this page needs to communicate with the current scanner object
            Scanner scanner = new Scanner();  //this is temporary to prevent errors at runtime
            switch (sender)
            {
                case ".":
                    //Note: scanner.NumVal = 0;  <--I can't find a NumVal property on Scanner.cs
                    //resets number counter for Number Value inputs
                    consoleTextBox.Text = ".";
                    break;
                case "?":
                    consoleTextBox.Text = "?";
                    //response = !?
                    break;
                case "A":
                    //Gets the home status & current position of XYZ stages
                    consoleTextBox.Text = "A";
                    //response = !Hh,A,X,Y,Z
                    break;
                case "B":
                    //Note: BACK -  the X Stage moves towards the stepper motor
                    //Move back Relative.nnnnB steps
                    consoleTextBox.Text = "B";
                    //response = !Bnnnn
                    break;
                case "C":
                    //Clear Hyper Terminal Display
                    consoleTextBox.Text = "C";
                    //response = !C
                    break;
                case "D":
                    //Move Z-Focus DOWN Relative (.nnnnD) steps
                    consoleTextBox.Text = "D";
                    //response = !Dnnnn
                    break;
                case "E":
                    consoleTextBox.Text = "E";
                    //response =
                    break;
                case "F":
                    //Note: FRONT -  the X Stage moves away from the stepper motor
                    //Move Front Relative .nnnnF steps
                    consoleTextBox.Text = "F";
                    //response = !Fnnnn
                    break;
                case "G":
                    //Note: Sends scan line data to Com Port #1 as formatted strings
                    //Raster Scan the XY stages and collect DATA
                    consoleTextBox.Text = "G";
                    //response =
                    break;
                case "H":
                    //Note: Open loop command, goes until Opto or STOP button
                    //Moves FRONT/RIGHT to opto detectors set stage XY position to one
                    consoleTextBox.Text = "H";
                    //response = !H
                    break;
                case "I":
                    //Moves XYZ stages to position defined by .nnnnX and .nnnnY and .nnnnZ values
                    consoleTextBox.Text = "I";
                    //response = !I
                    break;
                case "J":
                    consoleTextBox.Text = "J";
                    //response =
                    break;
                case "K":
                    consoleTextBox.Text = "K";
                    //response =
                    break;
                case "L":
                    //Note: LEFT -  the Y Stage moves towards the stepper motor
                    //Move Left Relative.nnnnL steps
                    consoleTextBox.Text = "L";
                    //response = !Lnnnn
                    break;
                case ".1M":
                    //Note: Sends all system parameters to terminal
                    //Verbose 1 of 2 lists of Scanner Parameters
                    consoleTextBox.Text = ".1M";
                    //response = !M1
                    break;
                case ".2M":
                    //Note: Sends all system parameters to terminal
                    //Verbose 1 of 2 lists of Scanner Parameters
                    consoleTextBox.Text = ".2M";
                    //response = !M2
                    break;
                case ".3M":
                    //Verbose 1 of 2 lists of Scanner Commands
                    consoleTextBox.Text = ".3M";
                    //response = !M3
                    break;
                case ".4M":
                    //Verbose 1 of 2 lists of Scanner Commands
                    consoleTextBox.Text = ".4M";
                    //response = !M4
                    break;
                case "N":
                    //Note: VAC Ralay/24V Valve  is OFF
                    //Release Vacuum to Sample Chuck/ ChuckVac Valve OF
                    consoleTextBox.Text = "N";
                    //response = !N
                    break;
                case "O":
                    //Note: VAC Ralay/24V Valve  is ON
                    //Apply Vacuum to Sample Chuck / ChuckVac Valve ON
                    consoleTextBox.Text = "O";
                    //response = !O
                    break;
                case "P":
                    //Note: use after scan to move stages back to load port
                    //Move XY stage to load port position .nnnnx and .nnnny
                    consoleTextBox.Text = "P";
                    //response = !P
                    break;
                case "Q":
                    //Note: RESPONSE includes the PHA value read by Q cmd
                    //Reads PHA output and displayes value
                    consoleTextBox.Text = "Q";
                    //response = !Qnnnn
                    break;
                case "R":
                    //Note: RIGHT -  the Y Stage moves away from the stepper motor
                    //Move Right Relative .nnnnR steps
                    consoleTextBox.Text = "R";
                    //response = !Rnnnn
                    break;
                case "S":
                    //Note: The PHA is active from start to end of each sector
                    // # of ABS steps to form a SECTOR .nnnnS
                    consoleTextBox.Text = "S";
                    //response = !Snnnn
                    break;
                case "T":
                    //Note: The Mx steps the # to start new My scan
                    // # of ABS steps to move to form a TRACK .nnnnT
                    consoleTextBox.Text = "T";
                    //response = !Tnnnn
                    break;
                case "U":
                    //Move Z-Focus UP Relative (.nnnnU) steps
                    consoleTextBox.Text = "U";
                    //response = !Unnnn
                    break;
                case "V":
                    consoleTextBox.Text = "V";
                    //response =
                    break;
                case "W":
                    consoleTextBox.Text = "W";
                    //response =
                    break;
                case "X":
                    //Note: Pre-position stage to XY location with "I" command
                    //Input of ABS value of Mx position .nnnnX steps
                    consoleTextBox.Text = "X";
                    //response = !Xnnnn
                    break;
                case "Y":
                    //Note: Pre-position stage to XY location with "I" command
                    //Input of ABS value of My position .nnnnY steps
                    consoleTextBox.Text = "Y";
                    //response = !Ynnnn
                    break;
                case "Z":
                    //Note: Pre-position stage to XY location with "z*" command
                    //Input of ABS value of Mz position .nnnnZ steps
                    consoleTextBox.Text = "Z";
                    //response = !Znnnn
                    break;
                case "a":
                    //Note: in machine message
                    //SET Max raw defect count to stop scan .nnnna
                    consoleTextBox.Text = "a";
                    //response = !a
                    break;
                case "b":
                    consoleTextBox.Text = "b";
                    //response =
                    break;
                case "c":
                    //Note: just for system trouble shooting
                    //CLEAR -  STOP/ Move/Home flags
                    consoleTextBox.Text = "c";
                    //response = !c
                    break;
                case "d":
                    //Note: SETS value of ScanWaferRadius, in machine message
                    //Calculates and converts mm to steps for  wafer radius value
                    consoleTextBox.Text = "d";
                    //response = !dnnn
                    break;
                case "e":
                    //Note: SETS value of ScanEdgeReject, in machine message
                    //Calculates and converts mm to steps for wafer edge reject val
                    consoleTextBox.Text = "e";
                    //response = !ennn
                    break;
                case "f":
                    //Read auto Focus A/D value 0-1024
                    consoleTextBox.Text = "f";
                    //response = !f
                    break;
                case "g":
                    //all stage movement flags are set to false (zero) to stop machine movements
                    consoleTextBox.Text = "g";
                    //response = !g
                    break;
                case "h":
                    //MOVE - Z-Stage to TOP/UP HOME opto stop and set position to one
                    consoleTextBox.Text = "h";
                    //response = !h
                    break;
                case "i":
                    //Note: Transfers (lc)uvw to (uc)XYZ for motion command (uc)I
                    //SETS -  I to default position of stage chuck center
                    consoleTextBox.Text = "i";
                    //response = !i
                    break;
                case "j":
                    consoleTextBox.Text = "j";
                    //response =
                    break;
                case "k":
                    consoleTextBox.Text = "k";
                    //response =
                    break;
                case "l":
                    consoleTextBox.Text = "l";
                    //response =
                    break;
                case "m":
                    //SEND scanner parameters to host in machine format
                    consoleTextBox.Text = "m";
                    //response = !m
                    break;
                case "n":
                    consoleTextBox.Text = "n";
                    //response = !n
                    break;
                case "o":
                    consoleTextBox.Text = "o";
                    //response = !o
                    break;
                case "p":
                    //Move Z stage to load port position .nnnnz
                    consoleTextBox.Text = "p";
                    //response = !p
                    break;
                case "q":
                    consoleTextBox.Text = "q";
                    //response = 
                    break;
                case "r":
                    //SET Host defect map resolution used to calculate scan data compression
                    consoleTextBox.Text = "r";
                    //response = !rnnn
                    break;
                case "s":
                    consoleTextBox.Text = "s";
                    //response = !s
                    break;
                case "t":
                    //Test code and output to treminal
                    consoleTextBox.Text = "t";
                    //response = !t
                    break;
                case "u":
                    //Note: Used to set focus position value.
                    //SET the optics head above the focus detector point .nnnnz steps
                    consoleTextBox.Text = "u";
                    //response = !unnn
                    break;
                case "v":
                    //Note: Used to set focus position value.
                    //SET the mechanical center of chuck X value  .nnnnv
                    consoleTextBox.Text = "v";
                    //response = !vnnn
                    break;
                case "w":
                    //Note: Used to set focus position value.
                    //SET the mechanical center of chuck Y value  .nnnnw
                    consoleTextBox.Text = "w";
                    //response = !wnnn
                    break;
                case "x":
                    //Note: Used to set park values.
                    //SET the chuck load position X value  .nnnnx
                    consoleTextBox.Text = "x";
                    //response = !xnnn
                    break;
                case "y":
                    //Note: Used to set park values.
                    //SET the chuck load position Y value  .nnnny
                    consoleTextBox.Text = "y";
                    //response = !ynnn
                    break;
                case "z":
                    //Note: Used to set park values.
                    //SET the chuck load position Y value  .nnnny   <-- SHOULD THIS BE THEY Z VALUE?
                    consoleTextBox.Text = "z";
                    //response = !znnn
                    break;
                default:
                    MessageBox.Show("Please make a valid selection.");
                    break;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            consoleTextBox.Text = "";
        }

        private void KeyboardToggleButton_Click(object sender, EventArgs e)  //<--NEED TO DELETE!
        {
        }
    }
}

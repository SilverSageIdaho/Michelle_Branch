
namespace SDA100._1
{
    partial class ConsolePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startupTab = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuTab = new System.Windows.Forms.ToolStripMenuItem();
            this.recipeTab = new System.Windows.Forms.ToolStripMenuItem();
            this.iniFilesTab = new System.Windows.Forms.ToolStripMenuItem();
            this.scanDataTab = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleTab = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceTab = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleTextBox = new System.Windows.Forms.RichTextBox();
            this.teensyCommandsComboBox = new System.Windows.Forms.ComboBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startupTab,
            this.mainMenuTab,
            this.recipeTab,
            this.iniFilesTab,
            this.scanDataTab,
            this.consoleTab,
            this.maintenanceTab});
            this.menuStrip1.Location = new System.Drawing.Point(1154, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(110, 761);
            this.menuStrip1.TabIndex = 4;
            // 
            // startupTab
            // 
            this.startupTab.AutoSize = false;
            this.startupTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.startupTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.startupTab.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startupTab.Margin = new System.Windows.Forms.Padding(0, 50, 5, 50);
            this.startupTab.Name = "startupTab";
            this.startupTab.Size = new System.Drawing.Size(100, 45);
            this.startupTab.Text = "Startup";
            this.startupTab.Click += new System.EventHandler(this.StartTab_Click);
            // 
            // mainMenuTab
            // 
            this.mainMenuTab.AutoSize = false;
            this.mainMenuTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainMenuTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mainMenuTab.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuTab.Margin = new System.Windows.Forms.Padding(0, 5, 5, 50);
            this.mainMenuTab.Name = "mainMenuTab";
            this.mainMenuTab.Size = new System.Drawing.Size(100, 45);
            this.mainMenuTab.Text = "Main Menu";
            this.mainMenuTab.Click += new System.EventHandler(this.MainMenuTab_Click);
            // 
            // recipeTab
            // 
            this.recipeTab.AutoSize = false;
            this.recipeTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.recipeTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.recipeTab.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeTab.Margin = new System.Windows.Forms.Padding(0, 5, 5, 50);
            this.recipeTab.Name = "recipeTab";
            this.recipeTab.Size = new System.Drawing.Size(100, 45);
            this.recipeTab.Text = "Recipes";
            this.recipeTab.Click += new System.EventHandler(this.RecipeTab_Click);
            // 
            // iniFilesTab
            // 
            this.iniFilesTab.AutoSize = false;
            this.iniFilesTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.iniFilesTab.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniFilesTab.Margin = new System.Windows.Forms.Padding(0, 5, 5, 50);
            this.iniFilesTab.Name = "iniFilesTab";
            this.iniFilesTab.Size = new System.Drawing.Size(100, 45);
            this.iniFilesTab.Text = "INI Files";
            this.iniFilesTab.Click += new System.EventHandler(this.IniFilesTab_Click);
            // 
            // scanDataTab
            // 
            this.scanDataTab.AutoSize = false;
            this.scanDataTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.scanDataTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.scanDataTab.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanDataTab.Margin = new System.Windows.Forms.Padding(0, 5, 5, 50);
            this.scanDataTab.Name = "scanDataTab";
            this.scanDataTab.Size = new System.Drawing.Size(100, 45);
            this.scanDataTab.Text = "Scan Data";
            this.scanDataTab.Click += new System.EventHandler(this.ScanDataTab_Click);
            // 
            // consoleTab
            // 
            this.consoleTab.AutoSize = false;
            this.consoleTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.consoleTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.consoleTab.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleTab.Margin = new System.Windows.Forms.Padding(0, 5, 5, 50);
            this.consoleTab.Name = "consoleTab";
            this.consoleTab.Size = new System.Drawing.Size(100, 45);
            this.consoleTab.Text = "Console";
            this.consoleTab.Click += new System.EventHandler(this.ConsoleTab_Click);
            // 
            // maintenanceTab
            // 
            this.maintenanceTab.AutoSize = false;
            this.maintenanceTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.maintenanceTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.maintenanceTab.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintenanceTab.Margin = new System.Windows.Forms.Padding(0, 5, 5, 50);
            this.maintenanceTab.Name = "maintenanceTab";
            this.maintenanceTab.Size = new System.Drawing.Size(100, 45);
            this.maintenanceTab.Text = "Maintenance";
            this.maintenanceTab.Click += new System.EventHandler(this.MaintenanceTab_Click);
            // 
            // consoleTextBox
            // 
            this.consoleTextBox.Location = new System.Drawing.Point(226, 177);
            this.consoleTextBox.Name = "consoleTextBox";
            this.consoleTextBox.Size = new System.Drawing.Size(688, 394);
            this.consoleTextBox.TabIndex = 5;
            this.consoleTextBox.Text = "";
            // 
            // teensyCommandsComboBox
            // 
            this.teensyCommandsComboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teensyCommandsComboBox.FormattingEnabled = true;
            this.teensyCommandsComboBox.Items.AddRange(new object[] {
            ".",
            "?",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            ".1M",
            ".2M",
            ".3M",
            ".4M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g",
            "h",
            "i",
            "j",
            "k",
            "l",
            "m",
            "n",
            "o",
            "p",
            "q",
            "r",
            "s",
            "t",
            "u",
            "v",
            "w",
            "x",
            "y",
            "z"});
            this.teensyCommandsComboBox.Location = new System.Drawing.Point(226, 95);
            this.teensyCommandsComboBox.Name = "teensyCommandsComboBox";
            this.teensyCommandsComboBox.Size = new System.Drawing.Size(200, 33);
            this.teensyCommandsComboBox.TabIndex = 7;
            this.teensyCommandsComboBox.SelectedIndexChanged += new System.EventHandler(this.TeensyCommandsComboBox_SelectedIndexChanged);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.LightGreen;
            this.submitButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(474, 87);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(100, 50);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Gold;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(659, 87);
            this.clearButton.Margin = new System.Windows.Forms.Padding(0);
            this.clearButton.Name = "clearButton";
            this.clearButton.Padding = new System.Windows.Forms.Padding(3);
            this.clearButton.Size = new System.Drawing.Size(100, 50);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ConsolePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.teensyCommandsComboBox);
            this.Controls.Add(this.consoleTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ConsolePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ConsolePage";
            this.Load += new System.EventHandler(this.ConsolePage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startupTab;
        private System.Windows.Forms.ToolStripMenuItem mainMenuTab;
        private System.Windows.Forms.ToolStripMenuItem recipeTab;
        private System.Windows.Forms.ToolStripMenuItem iniFilesTab;
        private System.Windows.Forms.ToolStripMenuItem scanDataTab;
        private System.Windows.Forms.ToolStripMenuItem consoleTab;
        private System.Windows.Forms.ToolStripMenuItem maintenanceTab;
        private System.Windows.Forms.RichTextBox consoleTextBox;
        private System.Windows.Forms.ComboBox teensyCommandsComboBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button clearButton;
    }
}
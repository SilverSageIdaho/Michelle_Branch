
namespace SDA100._1
{
    partial class RecipePage
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
            this.section2Label = new System.Windows.Forms.Label();
            this.autoSaveCheckBox = new System.Windows.Forms.CheckBox();
            this.sizeClassLabel = new System.Windows.Forms.Label();
            this.rejectLimitLabel = new System.Windows.Forms.Label();
            this.sizeLabel1 = new System.Windows.Forms.Label();
            this.sizeLabel2 = new System.Windows.Forms.Label();
            this.sizeLabel3 = new System.Windows.Forms.Label();
            this.sizeLabel4 = new System.Windows.Forms.Label();
            this.sizeLabel5 = new System.Windows.Forms.Label();
            this.sizeLabel6 = new System.Windows.Forms.Label();
            this.sizeLabel7 = new System.Windows.Forms.Label();
            this.totalSizeLabel = new System.Windows.Forms.Label();
            this.size1TextBox = new System.Windows.Forms.TextBox();
            this.size2TextBox = new System.Windows.Forms.TextBox();
            this.size3TextBox = new System.Windows.Forms.TextBox();
            this.size4TextBox = new System.Windows.Forms.TextBox();
            this.size5TextBox = new System.Windows.Forms.TextBox();
            this.size6TextBox = new System.Windows.Forms.TextBox();
            this.size7TextBox = new System.Windows.Forms.TextBox();
            this.sizeTotalTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startupTab = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuTab = new System.Windows.Forms.ToolStripMenuItem();
            this.recipeTab = new System.Windows.Forms.ToolStripMenuItem();
            this.iniFilesTab = new System.Windows.Forms.ToolStripMenuItem();
            this.scanDataTab = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleTab = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceTab = new System.Windows.Forms.ToolStripMenuItem();
            this.sendButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.scanIdTextBox = new System.Windows.Forms.TextBox();
            this.scanIdLabel = new System.Windows.Forms.Label();
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.recipeNameTextBox = new System.Windows.Forms.TextBox();
            this.zoneTypeOptionBox = new System.Windows.Forms.ComboBox();
            this.edgeRejectOptionBox = new System.Windows.Forms.ComboBox();
            this.areaScanOptionBox = new System.Windows.Forms.ComboBox();
            this.waferSizeOptionBox = new System.Windows.Forms.ComboBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.recipeNameLabel = new System.Windows.Forms.Label();
            this.zoneTypeLabel = new System.Windows.Forms.Label();
            this.edgeRejectLabel = new System.Windows.Forms.Label();
            this.areaScanLabel = new System.Windows.Forms.Label();
            this.waferSizeLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.recipeMenu = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // section2Label
            // 
            this.section2Label.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.section2Label.Location = new System.Drawing.Point(152, 3);
            this.section2Label.Name = "section2Label";
            this.section2Label.Size = new System.Drawing.Size(200, 25);
            this.section2Label.TabIndex = 11;
            this.section2Label.Text = "Rejects Limit";
            this.section2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // autoSaveCheckBox
            // 
            this.autoSaveCheckBox.AutoSize = true;
            this.autoSaveCheckBox.BackColor = System.Drawing.Color.LightGreen;
            this.autoSaveCheckBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoSaveCheckBox.Location = new System.Drawing.Point(504, 272);
            this.autoSaveCheckBox.Name = "autoSaveCheckBox";
            this.autoSaveCheckBox.Size = new System.Drawing.Size(131, 17);
            this.autoSaveCheckBox.TabIndex = 18;
            this.autoSaveCheckBox.Text = "Auto Save Scan Data";
            this.autoSaveCheckBox.UseVisualStyleBackColor = false;
            this.autoSaveCheckBox.CheckedChanged += new System.EventHandler(this.AutoSaveCheckBox_CheckedChanged);
            // 
            // sizeClassLabel
            // 
            this.sizeClassLabel.AutoSize = true;
            this.sizeClassLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeClassLabel.Location = new System.Drawing.Point(169, 42);
            this.sizeClassLabel.Name = "sizeClassLabel";
            this.sizeClassLabel.Size = new System.Drawing.Size(67, 17);
            this.sizeClassLabel.TabIndex = 19;
            this.sizeClassLabel.Text = "Size Class";
            // 
            // rejectLimitLabel
            // 
            this.rejectLimitLabel.AutoSize = true;
            this.rejectLimitLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rejectLimitLabel.Location = new System.Drawing.Point(271, 42);
            this.rejectLimitLabel.Name = "rejectLimitLabel";
            this.rejectLimitLabel.Size = new System.Drawing.Size(81, 17);
            this.rejectLimitLabel.TabIndex = 20;
            this.rejectLimitLabel.Text = "Reject Limit";
            // 
            // sizeLabel1
            // 
            this.sizeLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeLabel1.Location = new System.Drawing.Point(154, 64);
            this.sizeLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sizeLabel1.Name = "sizeLabel1";
            this.sizeLabel1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.sizeLabel1.Size = new System.Drawing.Size(75, 20);
            this.sizeLabel1.TabIndex = 21;
            this.sizeLabel1.Text = "0.25 um";
            this.sizeLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sizeLabel2
            // 
            this.sizeLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeLabel2.Location = new System.Drawing.Point(154, 96);
            this.sizeLabel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sizeLabel2.Name = "sizeLabel2";
            this.sizeLabel2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.sizeLabel2.Size = new System.Drawing.Size(75, 20);
            this.sizeLabel2.TabIndex = 22;
            this.sizeLabel2.Text = "0.3 um";
            this.sizeLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sizeLabel3
            // 
            this.sizeLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeLabel3.Location = new System.Drawing.Point(154, 129);
            this.sizeLabel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sizeLabel3.Name = "sizeLabel3";
            this.sizeLabel3.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.sizeLabel3.Size = new System.Drawing.Size(75, 20);
            this.sizeLabel3.TabIndex = 23;
            this.sizeLabel3.Text = "0.5 um";
            this.sizeLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sizeLabel4
            // 
            this.sizeLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeLabel4.Location = new System.Drawing.Point(154, 162);
            this.sizeLabel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sizeLabel4.Name = "sizeLabel4";
            this.sizeLabel4.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.sizeLabel4.Size = new System.Drawing.Size(75, 20);
            this.sizeLabel4.TabIndex = 24;
            this.sizeLabel4.Text = "0.7 um";
            this.sizeLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sizeLabel5
            // 
            this.sizeLabel5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeLabel5.Location = new System.Drawing.Point(150, 195);
            this.sizeLabel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sizeLabel5.Name = "sizeLabel5";
            this.sizeLabel5.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.sizeLabel5.Size = new System.Drawing.Size(75, 20);
            this.sizeLabel5.TabIndex = 25;
            this.sizeLabel5.Text = "1.0 um";
            this.sizeLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sizeLabel6
            // 
            this.sizeLabel6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeLabel6.Location = new System.Drawing.Point(150, 228);
            this.sizeLabel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sizeLabel6.Name = "sizeLabel6";
            this.sizeLabel6.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.sizeLabel6.Size = new System.Drawing.Size(75, 20);
            this.sizeLabel6.TabIndex = 26;
            this.sizeLabel6.Text = "3.0 um";
            this.sizeLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sizeLabel7
            // 
            this.sizeLabel7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeLabel7.Location = new System.Drawing.Point(150, 261);
            this.sizeLabel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sizeLabel7.Name = "sizeLabel7";
            this.sizeLabel7.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.sizeLabel7.Size = new System.Drawing.Size(75, 20);
            this.sizeLabel7.TabIndex = 27;
            this.sizeLabel7.Text = "+5.0 um";
            this.sizeLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalSizeLabel
            // 
            this.totalSizeLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSizeLabel.Location = new System.Drawing.Point(150, 294);
            this.totalSizeLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.totalSizeLabel.Name = "totalSizeLabel";
            this.totalSizeLabel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.totalSizeLabel.Size = new System.Drawing.Size(75, 20);
            this.totalSizeLabel.TabIndex = 28;
            this.totalSizeLabel.Text = "Count Limit:";
            this.totalSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // size1TextBox
            // 
            this.size1TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.size1TextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size1TextBox.Location = new System.Drawing.Point(245, 63);
            this.size1TextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.size1TextBox.Name = "size1TextBox";
            this.size1TextBox.Size = new System.Drawing.Size(100, 25);
            this.size1TextBox.TabIndex = 29;
            // 
            // size2TextBox
            // 
            this.size2TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.size2TextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size2TextBox.Location = new System.Drawing.Point(245, 96);
            this.size2TextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.size2TextBox.Name = "size2TextBox";
            this.size2TextBox.Size = new System.Drawing.Size(100, 25);
            this.size2TextBox.TabIndex = 30;
            // 
            // size3TextBox
            // 
            this.size3TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.size3TextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size3TextBox.Location = new System.Drawing.Point(245, 129);
            this.size3TextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.size3TextBox.Name = "size3TextBox";
            this.size3TextBox.Size = new System.Drawing.Size(100, 25);
            this.size3TextBox.TabIndex = 31;
            // 
            // size4TextBox
            // 
            this.size4TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.size4TextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size4TextBox.Location = new System.Drawing.Point(245, 162);
            this.size4TextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.size4TextBox.Name = "size4TextBox";
            this.size4TextBox.Size = new System.Drawing.Size(100, 25);
            this.size4TextBox.TabIndex = 32;
            // 
            // size5TextBox
            // 
            this.size5TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.size5TextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size5TextBox.Location = new System.Drawing.Point(245, 195);
            this.size5TextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.size5TextBox.Name = "size5TextBox";
            this.size5TextBox.Size = new System.Drawing.Size(100, 25);
            this.size5TextBox.TabIndex = 33;
            // 
            // size6TextBox
            // 
            this.size6TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.size6TextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size6TextBox.Location = new System.Drawing.Point(245, 228);
            this.size6TextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.size6TextBox.Name = "size6TextBox";
            this.size6TextBox.Size = new System.Drawing.Size(100, 25);
            this.size6TextBox.TabIndex = 34;
            // 
            // size7TextBox
            // 
            this.size7TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.size7TextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size7TextBox.Location = new System.Drawing.Point(245, 261);
            this.size7TextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.size7TextBox.Name = "size7TextBox";
            this.size7TextBox.Size = new System.Drawing.Size(100, 25);
            this.size7TextBox.TabIndex = 35;
            // 
            // sizeTotalTextBox
            // 
            this.sizeTotalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sizeTotalTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeTotalTextBox.Location = new System.Drawing.Point(245, 294);
            this.sizeTotalTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.sizeTotalTextBox.Name = "sizeTotalTextBox";
            this.sizeTotalTextBox.Size = new System.Drawing.Size(100, 25);
            this.sizeTotalTextBox.TabIndex = 36;
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
            this.menuStrip1.TabIndex = 37;
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
            this.maintenanceTab.Margin = new System.Windows.Forms.Padding(0, 5, 5, 30);
            this.maintenanceTab.Name = "maintenanceTab";
            this.maintenanceTab.Size = new System.Drawing.Size(100, 45);
            this.maintenanceTab.Text = "Maintenance";
            this.maintenanceTab.Click += new System.EventHandler(this.MaintenanceTab_Click);
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.LightGreen;
            this.sendButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.Location = new System.Drawing.Point(969, 427);
            this.sendButton.Name = "sendButton";
            this.sendButton.Padding = new System.Windows.Forms.Padding(5);
            this.sendButton.Size = new System.Drawing.Size(150, 50);
            this.sendButton.TabIndex = 38;
            this.sendButton.Text = "SEND TO SCANNER";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(969, 324);
            this.saveButton.Name = "saveButton";
            this.saveButton.Padding = new System.Windows.Forms.Padding(5);
            this.saveButton.Size = new System.Drawing.Size(150, 50);
            this.saveButton.TabIndex = 39;
            this.saveButton.Text = "CREATE NEW RECIPE";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Gold;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(969, 631);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Padding = new System.Windows.Forms.Padding(5);
            this.deleteButton.Size = new System.Drawing.Size(150, 50);
            this.deleteButton.TabIndex = 40;
            this.deleteButton.Text = "DELETE RECIPE";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Cornsilk;
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(969, 529);
            this.editButton.Name = "editButton";
            this.editButton.Padding = new System.Windows.Forms.Padding(5);
            this.editButton.Size = new System.Drawing.Size(150, 50);
            this.editButton.TabIndex = 42;
            this.editButton.Text = "EDIT RECIPE";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.scanIdTextBox);
            this.groupBox4.Controls.Add(this.scanIdLabel);
            this.groupBox4.Controls.Add(this.userIdTextBox);
            this.groupBox4.Controls.Add(this.userIdLabel);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.descriptionTextBox);
            this.groupBox4.Controls.Add(this.recipeNameTextBox);
            this.groupBox4.Controls.Add(this.zoneTypeOptionBox);
            this.groupBox4.Controls.Add(this.edgeRejectOptionBox);
            this.groupBox4.Controls.Add(this.areaScanOptionBox);
            this.groupBox4.Controls.Add(this.waferSizeOptionBox);
            this.groupBox4.Controls.Add(this.descriptionLabel);
            this.groupBox4.Controls.Add(this.recipeNameLabel);
            this.groupBox4.Controls.Add(this.zoneTypeLabel);
            this.groupBox4.Controls.Add(this.edgeRejectLabel);
            this.groupBox4.Controls.Add(this.areaScanLabel);
            this.groupBox4.Controls.Add(this.waferSizeLabel);
            this.groupBox4.Controls.Add(this.titleLabel);
            this.groupBox4.Controls.Add(this.autoSaveCheckBox);
            this.groupBox4.Location = new System.Drawing.Point(357, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(640, 322);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            // 
            // scanIdTextBox
            // 
            this.scanIdTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanIdTextBox.Location = new System.Drawing.Point(173, 183);
            this.scanIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.scanIdTextBox.Name = "scanIdTextBox";
            this.scanIdTextBox.Size = new System.Drawing.Size(305, 29);
            this.scanIdTextBox.TabIndex = 9;
            // 
            // scanIdLabel
            // 
            this.scanIdLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanIdLabel.Location = new System.Drawing.Point(46, 186);
            this.scanIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scanIdLabel.Name = "scanIdLabel";
            this.scanIdLabel.Size = new System.Drawing.Size(113, 26);
            this.scanIdLabel.TabIndex = 8;
            this.scanIdLabel.Text = "Scan ID:";
            this.scanIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdTextBox.Location = new System.Drawing.Point(173, 150);
            this.userIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.Size = new System.Drawing.Size(305, 29);
            this.userIdTextBox.TabIndex = 7;
            // 
            // userIdLabel
            // 
            this.userIdLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdLabel.Location = new System.Drawing.Point(46, 150);
            this.userIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(113, 26);
            this.userIdLabel.TabIndex = 6;
            this.userIdLabel.Text = "User ID:";
            this.userIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(231, 82);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 25);
            this.label12.TabIndex = 4;
            this.label12.Text = "mm";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(173, 216);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(305, 98);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // recipeNameTextBox
            // 
            this.recipeNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeNameTextBox.Location = new System.Drawing.Point(173, 117);
            this.recipeNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.recipeNameTextBox.Name = "recipeNameTextBox";
            this.recipeNameTextBox.Size = new System.Drawing.Size(389, 29);
            this.recipeNameTextBox.TabIndex = 3;
            // 
            // zoneTypeOptionBox
            // 
            this.zoneTypeOptionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zoneTypeOptionBox.Enabled = false;
            this.zoneTypeOptionBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoneTypeOptionBox.FormattingEnabled = true;
            this.zoneTypeOptionBox.Items.AddRange(new object[] {
            "Full",
            "Half",
            "Quarter"});
            this.zoneTypeOptionBox.Location = new System.Drawing.Point(480, 79);
            this.zoneTypeOptionBox.Margin = new System.Windows.Forms.Padding(2);
            this.zoneTypeOptionBox.Name = "zoneTypeOptionBox";
            this.zoneTypeOptionBox.Size = new System.Drawing.Size(82, 29);
            this.zoneTypeOptionBox.TabIndex = 2;
            // 
            // edgeRejectOptionBox
            // 
            this.edgeRejectOptionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.edgeRejectOptionBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edgeRejectOptionBox.FormattingEnabled = true;
            this.edgeRejectOptionBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.edgeRejectOptionBox.Location = new System.Drawing.Point(173, 79);
            this.edgeRejectOptionBox.Margin = new System.Windows.Forms.Padding(2);
            this.edgeRejectOptionBox.Name = "edgeRejectOptionBox";
            this.edgeRejectOptionBox.Size = new System.Drawing.Size(54, 29);
            this.edgeRejectOptionBox.TabIndex = 2;
            // 
            // areaScanOptionBox
            // 
            this.areaScanOptionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.areaScanOptionBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaScanOptionBox.FormattingEnabled = true;
            this.areaScanOptionBox.Items.AddRange(new object[] {
            "25",
            "50",
            "75",
            "100"});
            this.areaScanOptionBox.Location = new System.Drawing.Point(480, 42);
            this.areaScanOptionBox.Margin = new System.Windows.Forms.Padding(2);
            this.areaScanOptionBox.Name = "areaScanOptionBox";
            this.areaScanOptionBox.Size = new System.Drawing.Size(82, 29);
            this.areaScanOptionBox.TabIndex = 2;
            // 
            // waferSizeOptionBox
            // 
            this.waferSizeOptionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.waferSizeOptionBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waferSizeOptionBox.FormattingEnabled = true;
            this.waferSizeOptionBox.Items.AddRange(new object[] {
            "25",
            "50",
            "75",
            "100",
            "125",
            "150",
            "200"});
            this.waferSizeOptionBox.Location = new System.Drawing.Point(173, 42);
            this.waferSizeOptionBox.Margin = new System.Windows.Forms.Padding(2);
            this.waferSizeOptionBox.Name = "waferSizeOptionBox";
            this.waferSizeOptionBox.Size = new System.Drawing.Size(82, 29);
            this.waferSizeOptionBox.TabIndex = 2;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(46, 243);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(113, 25);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "Description:";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // recipeNameLabel
            // 
            this.recipeNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeNameLabel.Location = new System.Drawing.Point(24, 117);
            this.recipeNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.recipeNameLabel.Name = "recipeNameLabel";
            this.recipeNameLabel.Size = new System.Drawing.Size(135, 26);
            this.recipeNameLabel.TabIndex = 1;
            this.recipeNameLabel.Text = "Recipe Name:";
            this.recipeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // zoneTypeLabel
            // 
            this.zoneTypeLabel.Enabled = false;
            this.zoneTypeLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoneTypeLabel.Location = new System.Drawing.Point(319, 84);
            this.zoneTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.zoneTypeLabel.Name = "zoneTypeLabel";
            this.zoneTypeLabel.Size = new System.Drawing.Size(150, 24);
            this.zoneTypeLabel.TabIndex = 1;
            this.zoneTypeLabel.Text = "Zone Scan Type:";
            this.zoneTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edgeRejectLabel
            // 
            this.edgeRejectLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edgeRejectLabel.Location = new System.Drawing.Point(33, 82);
            this.edgeRejectLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.edgeRejectLabel.Name = "edgeRejectLabel";
            this.edgeRejectLabel.Size = new System.Drawing.Size(126, 26);
            this.edgeRejectLabel.TabIndex = 1;
            this.edgeRejectLabel.Text = "Edge Reject:";
            this.edgeRejectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // areaScanLabel
            // 
            this.areaScanLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaScanLabel.Location = new System.Drawing.Point(329, 43);
            this.areaScanLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.areaScanLabel.Name = "areaScanLabel";
            this.areaScanLabel.Size = new System.Drawing.Size(140, 28);
            this.areaScanLabel.TabIndex = 1;
            this.areaScanLabel.Text = "Scan Area (%):";
            this.areaScanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // waferSizeLabel
            // 
            this.waferSizeLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waferSizeLabel.Location = new System.Drawing.Point(46, 43);
            this.waferSizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.waferSizeLabel.Name = "waferSizeLabel";
            this.waferSizeLabel.Size = new System.Drawing.Size(113, 26);
            this.waferSizeLabel.TabIndex = 1;
            this.waferSizeLabel.Text = "Wafer Size:";
            this.waferSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(210, 3);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(259, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Scan Recipe Manager";
            // 
            // recipeMenu
            // 
            this.recipeMenu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.recipeMenu.AutoSize = false;
            this.recipeMenu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.recipeMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.recipeMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.recipeMenu.Location = new System.Drawing.Point(208, 324);
            this.recipeMenu.Name = "recipeMenu";
            this.recipeMenu.Padding = new System.Windows.Forms.Padding(1, 2, 0, 2);
            this.recipeMenu.Size = new System.Drawing.Size(758, 428);
            this.recipeMenu.TabIndex = 5;
            // 
            // RecipePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.sizeTotalTextBox);
            this.Controls.Add(this.size7TextBox);
            this.Controls.Add(this.size6TextBox);
            this.Controls.Add(this.size5TextBox);
            this.Controls.Add(this.size4TextBox);
            this.Controls.Add(this.size3TextBox);
            this.Controls.Add(this.size2TextBox);
            this.Controls.Add(this.size1TextBox);
            this.Controls.Add(this.totalSizeLabel);
            this.Controls.Add(this.sizeLabel7);
            this.Controls.Add(this.sizeLabel6);
            this.Controls.Add(this.sizeLabel5);
            this.Controls.Add(this.sizeLabel4);
            this.Controls.Add(this.sizeLabel3);
            this.Controls.Add(this.sizeLabel2);
            this.Controls.Add(this.sizeLabel1);
            this.Controls.Add(this.rejectLimitLabel);
            this.Controls.Add(this.sizeClassLabel);
            this.Controls.Add(this.section2Label);
            this.Controls.Add(this.recipeMenu);
            this.Name = "RecipePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RecipePage";
            this.Load += new System.EventHandler(this.RecipePage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label section2Label;
        private System.Windows.Forms.CheckBox autoSaveCheckBox;
        private System.Windows.Forms.Label sizeClassLabel;
        private System.Windows.Forms.Label rejectLimitLabel;
        private System.Windows.Forms.Label sizeLabel1;
        private System.Windows.Forms.Label sizeLabel2;
        private System.Windows.Forms.Label sizeLabel3;
        private System.Windows.Forms.Label sizeLabel4;
        private System.Windows.Forms.Label sizeLabel5;
        private System.Windows.Forms.Label sizeLabel6;
        private System.Windows.Forms.Label sizeLabel7;
        private System.Windows.Forms.Label totalSizeLabel;
        private System.Windows.Forms.TextBox size1TextBox;
        private System.Windows.Forms.TextBox size2TextBox;
        private System.Windows.Forms.TextBox size3TextBox;
        private System.Windows.Forms.TextBox size4TextBox;
        private System.Windows.Forms.TextBox size5TextBox;
        private System.Windows.Forms.TextBox size6TextBox;
        private System.Windows.Forms.TextBox size7TextBox;
        private System.Windows.Forms.TextBox sizeTotalTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startupTab;
        private System.Windows.Forms.ToolStripMenuItem mainMenuTab;
        private System.Windows.Forms.ToolStripMenuItem recipeTab;
        private System.Windows.Forms.ToolStripMenuItem iniFilesTab;
        private System.Windows.Forms.ToolStripMenuItem scanDataTab;
        private System.Windows.Forms.ToolStripMenuItem consoleTab;
        private System.Windows.Forms.ToolStripMenuItem maintenanceTab;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox scanIdTextBox;
        private System.Windows.Forms.Label scanIdLabel;
        private System.Windows.Forms.TextBox userIdTextBox;
        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox recipeNameTextBox;
        private System.Windows.Forms.ComboBox zoneTypeOptionBox;
        private System.Windows.Forms.ComboBox edgeRejectOptionBox;
        private System.Windows.Forms.ComboBox areaScanOptionBox;
        private System.Windows.Forms.ComboBox waferSizeOptionBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label recipeNameLabel;
        private System.Windows.Forms.Label zoneTypeLabel;
        private System.Windows.Forms.Label edgeRejectLabel;
        private System.Windows.Forms.Label areaScanLabel;
        private System.Windows.Forms.Label waferSizeLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.MenuStrip recipeMenu;
    }
}
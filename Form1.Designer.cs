namespace FirstWindowsFormsApp
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, 1000D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageRegistered = new System.Windows.Forms.TabPage();
            this.comboBoxOptions = new System.Windows.Forms.ComboBox();
            this.buttonRegisterNew = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.comboBoxInstrumentName = new System.Windows.Forms.ComboBox();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.buttonOpenFIle = new System.Windows.Forms.Button();
            this.comboBoxMeasureType = new System.Windows.Forms.ComboBox();
            this.buttonSummary = new System.Windows.Forms.Button();
            this.panelUnit = new System.Windows.Forms.Panel();
            this.labelAlarmL = new System.Windows.Forms.Label();
            this.textBoxAlarmL = new System.Windows.Forms.TextBox();
            this.labelAlarmH = new System.Windows.Forms.Label();
            this.textBoxAlarmH = new System.Windows.Forms.TextBox();
            this.textBoxLRV = new System.Windows.Forms.TextBox();
            this.labelLRV = new System.Windows.Forms.Label();
            this.textBoxURV = new System.Windows.Forms.TextBox();
            this.labelUnit = new System.Windows.Forms.Label();
            this.labelURV = new System.Windows.Forms.Label();
            this.textBoxUnit = new System.Windows.Forms.TextBox();
            this.textBoxSummary = new System.Windows.Forms.TextBox();
            this.labelMeasureTime = new System.Windows.Forms.Label();
            this.textBoxRegister = new System.Windows.Forms.TextBox();
            this.statusStripReady = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.maskedTextBoxSerialNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelComment = new System.Windows.Forms.Label();
            this.labelOptions = new System.Windows.Forms.Label();
            this.labelRegistered = new System.Windows.Forms.Label();
            this.labelSignalType = new System.Windows.Forms.Label();
            this.labelRegisterDate = new System.Windows.Forms.Label();
            this.comboBoxSignalType = new System.Windows.Forms.ComboBox();
            this.dateTimePickerRegisterDate = new System.Windows.Forms.DateTimePicker();
            this.checkBoxRegistered = new System.Windows.Forms.CheckBox();
            this.labelSerialNumber = new System.Windows.Forms.Label();
            this.labelSensorName = new System.Windows.Forms.Label();
            this.tabPageConnection = new System.Windows.Forms.TabPage();
            this.buttonReadScaled = new System.Windows.Forms.Button();
            this.buttonReadState = new System.Windows.Forms.Button();
            this.buttonWriteConfiguration = new System.Windows.Forms.Button();
            this.buttonReadConfiguration = new System.Windows.Forms.Button();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelIPAddress = new System.Windows.Forms.Label();
            this.checkBoxCaseSensitive = new System.Windows.Forms.CheckBox();
            this.textBoxCommunication = new System.Windows.Forms.TextBox();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.tabPageLists = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPageChart = new System.Windows.Forms.TabPage();
            this.buttonAddXY = new System.Windows.Forms.Button();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.textBoxYValue = new System.Windows.Forms.TextBox();
            this.textBoxXValue = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timerReadScaled = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageRegistered.SuspendLayout();
            this.panelUnit.SuspendLayout();
            this.statusStripReady.SuspendLayout();
            this.tabPageConnection.SuspendLayout();
            this.tabPageLists.SuspendLayout();
            this.tabPageChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageRegistered);
            this.tabControl1.Controls.Add(this.tabPageConnection);
            this.tabControl1.Controls.Add(this.tabPageLists);
            this.tabControl1.Controls.Add(this.tabPageChart);
            this.tabControl1.Location = new System.Drawing.Point(0, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(963, 461);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.MouseHover += new System.EventHandler(this.tabControl1_MouseHover);
            // 
            // tabPageRegistered
            // 
            this.tabPageRegistered.Controls.Add(this.comboBoxOptions);
            this.tabPageRegistered.Controls.Add(this.buttonRegisterNew);
            this.tabPageRegistered.Controls.Add(this.buttonDelete);
            this.tabPageRegistered.Controls.Add(this.buttonSaveChanges);
            this.tabPageRegistered.Controls.Add(this.comboBoxInstrumentName);
            this.tabPageRegistered.Controls.Add(this.buttonSaveToFile);
            this.tabPageRegistered.Controls.Add(this.buttonOpenFIle);
            this.tabPageRegistered.Controls.Add(this.comboBoxMeasureType);
            this.tabPageRegistered.Controls.Add(this.buttonSummary);
            this.tabPageRegistered.Controls.Add(this.panelUnit);
            this.tabPageRegistered.Controls.Add(this.textBoxSummary);
            this.tabPageRegistered.Controls.Add(this.labelMeasureTime);
            this.tabPageRegistered.Controls.Add(this.textBoxRegister);
            this.tabPageRegistered.Controls.Add(this.statusStripReady);
            this.tabPageRegistered.Controls.Add(this.textBoxComment);
            this.tabPageRegistered.Controls.Add(this.maskedTextBoxSerialNumber);
            this.tabPageRegistered.Controls.Add(this.labelComment);
            this.tabPageRegistered.Controls.Add(this.labelOptions);
            this.tabPageRegistered.Controls.Add(this.labelRegistered);
            this.tabPageRegistered.Controls.Add(this.labelSignalType);
            this.tabPageRegistered.Controls.Add(this.labelRegisterDate);
            this.tabPageRegistered.Controls.Add(this.comboBoxSignalType);
            this.tabPageRegistered.Controls.Add(this.dateTimePickerRegisterDate);
            this.tabPageRegistered.Controls.Add(this.checkBoxRegistered);
            this.tabPageRegistered.Controls.Add(this.labelSerialNumber);
            this.tabPageRegistered.Controls.Add(this.labelSensorName);
            this.tabPageRegistered.Location = new System.Drawing.Point(4, 29);
            this.tabPageRegistered.Name = "tabPageRegistered";
            this.tabPageRegistered.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegistered.Size = new System.Drawing.Size(955, 428);
            this.tabPageRegistered.TabIndex = 0;
            this.tabPageRegistered.Text = "Sensor Data";
            this.tabPageRegistered.UseVisualStyleBackColor = true;
            this.tabPageRegistered.MouseHover += new System.EventHandler(this.tabPage1_MouseHover);
            // 
            // comboBoxOptions
            // 
            this.comboBoxOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOptions.FormattingEnabled = true;
            this.comboBoxOptions.Items.AddRange(new object[] {
            "None",
            "Display",
            "HART Protocol"});
            this.comboBoxOptions.Location = new System.Drawing.Point(159, 253);
            this.comboBoxOptions.Name = "comboBoxOptions";
            this.comboBoxOptions.Size = new System.Drawing.Size(212, 28);
            this.comboBoxOptions.TabIndex = 7;
            this.comboBoxOptions.MouseHover += new System.EventHandler(this.comboBoxOptions_MouseHover);
            // 
            // buttonRegisterNew
            // 
            this.buttonRegisterNew.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonRegisterNew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRegisterNew.Location = new System.Drawing.Point(396, 219);
            this.buttonRegisterNew.Name = "buttonRegisterNew";
            this.buttonRegisterNew.Size = new System.Drawing.Size(131, 39);
            this.buttonRegisterNew.TabIndex = 14;
            this.buttonRegisterNew.Text = "Register New";
            this.buttonRegisterNew.UseVisualStyleBackColor = false;
            this.buttonRegisterNew.Click += new System.EventHandler(this.buttonRegisterNew_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.Location = new System.Drawing.Point(396, 309);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(131, 39);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonSaveChanges.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveChanges.Location = new System.Drawing.Point(396, 264);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(131, 39);
            this.buttonSaveChanges.TabIndex = 15;
            this.buttonSaveChanges.Text = "Save Changes";
            this.buttonSaveChanges.UseVisualStyleBackColor = false;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // comboBoxInstrumentName
            // 
            this.comboBoxInstrumentName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxInstrumentName.FormattingEnabled = true;
            this.comboBoxInstrumentName.Location = new System.Drawing.Point(159, 16);
            this.comboBoxInstrumentName.Name = "comboBoxInstrumentName";
            this.comboBoxInstrumentName.Size = new System.Drawing.Size(212, 36);
            this.comboBoxInstrumentName.TabIndex = 1;
            this.comboBoxInstrumentName.SelectedIndexChanged += new System.EventHandler(this.comboBoxInstrumentName_SelectedIndexChanged);
            this.comboBoxInstrumentName.MouseHover += new System.EventHandler(this.comboBoxInstrumentName_MouseHover);
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonSaveToFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveToFile.Location = new System.Drawing.Point(806, 264);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(143, 39);
            this.buttonSaveToFile.TabIndex = 17;
            this.buttonSaveToFile.Text = "Save to File";
            this.buttonSaveToFile.UseVisualStyleBackColor = false;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            // 
            // buttonOpenFIle
            // 
            this.buttonOpenFIle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonOpenFIle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonOpenFIle.Location = new System.Drawing.Point(806, 309);
            this.buttonOpenFIle.Name = "buttonOpenFIle";
            this.buttonOpenFIle.Size = new System.Drawing.Size(143, 39);
            this.buttonOpenFIle.TabIndex = 18;
            this.buttonOpenFIle.Text = "Open File";
            this.buttonOpenFIle.UseVisualStyleBackColor = false;
            this.buttonOpenFIle.Click += new System.EventHandler(this.buttonOpenFIle_Click);
            // 
            // comboBoxMeasureType
            // 
            this.comboBoxMeasureType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMeasureType.FormattingEnabled = true;
            this.comboBoxMeasureType.Location = new System.Drawing.Point(159, 211);
            this.comboBoxMeasureType.Name = "comboBoxMeasureType";
            this.comboBoxMeasureType.Size = new System.Drawing.Size(212, 28);
            this.comboBoxMeasureType.TabIndex = 6;
            this.comboBoxMeasureType.MouseHover += new System.EventHandler(this.comboBoxMeasureType_MouseHover);
            // 
            // buttonSummary
            // 
            this.buttonSummary.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonSummary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSummary.Location = new System.Drawing.Point(611, 264);
            this.buttonSummary.Name = "buttonSummary";
            this.buttonSummary.Size = new System.Drawing.Size(135, 39);
            this.buttonSummary.TabIndex = 19;
            this.buttonSummary.Text = "Summary";
            this.buttonSummary.UseVisualStyleBackColor = false;
            this.buttonSummary.Click += new System.EventHandler(this.buttonSummary_Click);
            // 
            // panelUnit
            // 
            this.panelUnit.Controls.Add(this.labelAlarmL);
            this.panelUnit.Controls.Add(this.textBoxAlarmL);
            this.panelUnit.Controls.Add(this.labelAlarmH);
            this.panelUnit.Controls.Add(this.textBoxAlarmH);
            this.panelUnit.Controls.Add(this.textBoxLRV);
            this.panelUnit.Controls.Add(this.labelLRV);
            this.panelUnit.Controls.Add(this.textBoxURV);
            this.panelUnit.Controls.Add(this.labelUnit);
            this.panelUnit.Controls.Add(this.labelURV);
            this.panelUnit.Controls.Add(this.textBoxUnit);
            this.panelUnit.Location = new System.Drawing.Point(396, 3);
            this.panelUnit.Name = "panelUnit";
            this.panelUnit.Size = new System.Drawing.Size(209, 182);
            this.panelUnit.TabIndex = 9;
            // 
            // labelAlarmL
            // 
            this.labelAlarmL.AutoSize = true;
            this.labelAlarmL.Location = new System.Drawing.Point(10, 146);
            this.labelAlarmL.Name = "labelAlarmL";
            this.labelAlarmL.Size = new System.Drawing.Size(60, 20);
            this.labelAlarmL.TabIndex = 29;
            this.labelAlarmL.Text = "Alarm L";
            // 
            // textBoxAlarmL
            // 
            this.textBoxAlarmL.Location = new System.Drawing.Point(82, 143);
            this.textBoxAlarmL.MaxLength = 4;
            this.textBoxAlarmL.Name = "textBoxAlarmL";
            this.textBoxAlarmL.Size = new System.Drawing.Size(96, 27);
            this.textBoxAlarmL.TabIndex = 13;
            this.textBoxAlarmL.MouseHover += new System.EventHandler(this.textBoxAlarmL_MouseHover);
            // 
            // labelAlarmH
            // 
            this.labelAlarmH.AutoSize = true;
            this.labelAlarmH.Location = new System.Drawing.Point(12, 113);
            this.labelAlarmH.Name = "labelAlarmH";
            this.labelAlarmH.Size = new System.Drawing.Size(64, 20);
            this.labelAlarmH.TabIndex = 27;
            this.labelAlarmH.Text = "Alarm H";
            // 
            // textBoxAlarmH
            // 
            this.textBoxAlarmH.Location = new System.Drawing.Point(82, 110);
            this.textBoxAlarmH.MaxLength = 4;
            this.textBoxAlarmH.Name = "textBoxAlarmH";
            this.textBoxAlarmH.Size = new System.Drawing.Size(96, 27);
            this.textBoxAlarmH.TabIndex = 12;
            this.textBoxAlarmH.MouseHover += new System.EventHandler(this.textBoxAlarmH_MouseHover);
            // 
            // textBoxLRV
            // 
            this.textBoxLRV.Location = new System.Drawing.Point(82, 3);
            this.textBoxLRV.MaxLength = 1234534;
            this.textBoxLRV.Name = "textBoxLRV";
            this.textBoxLRV.Size = new System.Drawing.Size(96, 27);
            this.textBoxLRV.TabIndex = 9;
            this.textBoxLRV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLRV_KeyPress);
            this.textBoxLRV.MouseHover += new System.EventHandler(this.textBoxLRV_MouseHover);
            // 
            // labelLRV
            // 
            this.labelLRV.AutoSize = true;
            this.labelLRV.Location = new System.Drawing.Point(17, 10);
            this.labelLRV.Name = "labelLRV";
            this.labelLRV.Size = new System.Drawing.Size(34, 20);
            this.labelLRV.TabIndex = 21;
            this.labelLRV.Text = "LRV";
            // 
            // textBoxURV
            // 
            this.textBoxURV.Location = new System.Drawing.Point(82, 36);
            this.textBoxURV.MaxLength = 4555555;
            this.textBoxURV.Name = "textBoxURV";
            this.textBoxURV.Size = new System.Drawing.Size(96, 27);
            this.textBoxURV.TabIndex = 10;
            this.textBoxURV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxURV_KeyPress);
            this.textBoxURV.MouseHover += new System.EventHandler(this.textBoxURV_MouseHover);
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Location = new System.Drawing.Point(17, 77);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(36, 20);
            this.labelUnit.TabIndex = 25;
            this.labelUnit.Text = "Unit";
            // 
            // labelURV
            // 
            this.labelURV.AutoSize = true;
            this.labelURV.Location = new System.Drawing.Point(17, 39);
            this.labelURV.Name = "labelURV";
            this.labelURV.Size = new System.Drawing.Size(37, 20);
            this.labelURV.TabIndex = 24;
            this.labelURV.Text = "URV";
            // 
            // textBoxUnit
            // 
            this.textBoxUnit.Location = new System.Drawing.Point(82, 74);
            this.textBoxUnit.MaxLength = 4;
            this.textBoxUnit.Name = "textBoxUnit";
            this.textBoxUnit.Size = new System.Drawing.Size(96, 27);
            this.textBoxUnit.TabIndex = 11;
            this.textBoxUnit.MouseHover += new System.EventHandler(this.textBoxUnit_MouseHover);
            // 
            // textBoxSummary
            // 
            this.textBoxSummary.Location = new System.Drawing.Point(611, 134);
            this.textBoxSummary.Multiline = true;
            this.textBoxSummary.Name = "textBoxSummary";
            this.textBoxSummary.ReadOnly = true;
            this.textBoxSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSummary.Size = new System.Drawing.Size(338, 122);
            this.textBoxSummary.TabIndex = 22;
            // 
            // labelMeasureTime
            // 
            this.labelMeasureTime.AutoSize = true;
            this.labelMeasureTime.Location = new System.Drawing.Point(10, 219);
            this.labelMeasureTime.Name = "labelMeasureTime";
            this.labelMeasureTime.Size = new System.Drawing.Size(100, 20);
            this.labelMeasureTime.TabIndex = 18;
            this.labelMeasureTime.Text = "Measure Type";
            // 
            // textBoxRegister
            // 
            this.textBoxRegister.Location = new System.Drawing.Point(611, 3);
            this.textBoxRegister.Multiline = true;
            this.textBoxRegister.Name = "textBoxRegister";
            this.textBoxRegister.ReadOnly = true;
            this.textBoxRegister.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRegister.Size = new System.Drawing.Size(338, 125);
            this.textBoxRegister.TabIndex = 20;
            // 
            // statusStripReady
            // 
            this.statusStripReady.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripReady.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStripReady.Location = new System.Drawing.Point(3, 399);
            this.statusStripReady.Name = "statusStripReady";
            this.statusStripReady.Size = new System.Drawing.Size(949, 26);
            this.statusStripReady.TabIndex = 16;
            this.statusStripReady.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.MouseHover += new System.EventHandler(this.FormMain_Load);
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(159, 303);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(212, 45);
            this.textBoxComment.TabIndex = 8;
            this.textBoxComment.MouseHover += new System.EventHandler(this.textBoxComment_MouseHover);
            // 
            // maskedTextBoxSerialNumber
            // 
            this.maskedTextBoxSerialNumber.Location = new System.Drawing.Point(159, 75);
            this.maskedTextBoxSerialNumber.Mask = "000-00-0000";
            this.maskedTextBoxSerialNumber.Name = "maskedTextBoxSerialNumber";
            this.maskedTextBoxSerialNumber.Size = new System.Drawing.Size(212, 27);
            this.maskedTextBoxSerialNumber.TabIndex = 2;
            this.maskedTextBoxSerialNumber.MouseHover += new System.EventHandler(this.maskedTextBoxSerialNumber_MouseHover);
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(10, 303);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(74, 20);
            this.labelComment.TabIndex = 12;
            this.labelComment.Text = "Comment";
            // 
            // labelOptions
            // 
            this.labelOptions.AutoSize = true;
            this.labelOptions.Location = new System.Drawing.Point(10, 262);
            this.labelOptions.Name = "labelOptions";
            this.labelOptions.Size = new System.Drawing.Size(61, 20);
            this.labelOptions.TabIndex = 11;
            this.labelOptions.Text = "Options";
            // 
            // labelRegistered
            // 
            this.labelRegistered.AutoSize = true;
            this.labelRegistered.Location = new System.Drawing.Point(10, 114);
            this.labelRegistered.Name = "labelRegistered";
            this.labelRegistered.Size = new System.Drawing.Size(80, 20);
            this.labelRegistered.TabIndex = 9;
            this.labelRegistered.Text = "Registered";
            // 
            // labelSignalType
            // 
            this.labelSignalType.AutoSize = true;
            this.labelSignalType.Location = new System.Drawing.Point(10, 179);
            this.labelSignalType.Name = "labelSignalType";
            this.labelSignalType.Size = new System.Drawing.Size(85, 20);
            this.labelSignalType.TabIndex = 8;
            this.labelSignalType.Text = "Signal Type";
            // 
            // labelRegisterDate
            // 
            this.labelRegisterDate.AutoSize = true;
            this.labelRegisterDate.Location = new System.Drawing.Point(10, 143);
            this.labelRegisterDate.Name = "labelRegisterDate";
            this.labelRegisterDate.Size = new System.Drawing.Size(99, 20);
            this.labelRegisterDate.TabIndex = 7;
            this.labelRegisterDate.Text = "Register Date";
            // 
            // comboBoxSignalType
            // 
            this.comboBoxSignalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSignalType.FormattingEnabled = true;
            this.comboBoxSignalType.Items.AddRange(new object[] {
            "Analog",
            "Digital",
            "Fieldbus"});
            this.comboBoxSignalType.Location = new System.Drawing.Point(159, 168);
            this.comboBoxSignalType.Name = "comboBoxSignalType";
            this.comboBoxSignalType.Size = new System.Drawing.Size(212, 28);
            this.comboBoxSignalType.TabIndex = 5;
            this.comboBoxSignalType.SelectedIndexChanged += new System.EventHandler(this.comboBoxSignalType_SelectedIndexChanged);
            this.comboBoxSignalType.MouseHover += new System.EventHandler(this.comboBoxSignalType_MouseHover);
            // 
            // dateTimePickerRegisterDate
            // 
            this.dateTimePickerRegisterDate.Location = new System.Drawing.Point(159, 135);
            this.dateTimePickerRegisterDate.Name = "dateTimePickerRegisterDate";
            this.dateTimePickerRegisterDate.Size = new System.Drawing.Size(212, 27);
            this.dateTimePickerRegisterDate.TabIndex = 4;
            this.dateTimePickerRegisterDate.MouseHover += new System.EventHandler(this.dateTimePickerRegisterDate_MouseHover);
            // 
            // checkBoxRegistered
            // 
            this.checkBoxRegistered.AutoSize = true;
            this.checkBoxRegistered.Location = new System.Drawing.Point(159, 111);
            this.checkBoxRegistered.Name = "checkBoxRegistered";
            this.checkBoxRegistered.Size = new System.Drawing.Size(18, 17);
            this.checkBoxRegistered.TabIndex = 3;
            this.checkBoxRegistered.UseVisualStyleBackColor = true;
            this.checkBoxRegistered.MouseHover += new System.EventHandler(this.checkBoxRegistered_MouseHover);
            // 
            // labelSerialNumber
            // 
            this.labelSerialNumber.AutoSize = true;
            this.labelSerialNumber.Location = new System.Drawing.Point(10, 84);
            this.labelSerialNumber.Name = "labelSerialNumber";
            this.labelSerialNumber.Size = new System.Drawing.Size(104, 20);
            this.labelSerialNumber.TabIndex = 3;
            this.labelSerialNumber.Text = "Serial Number";
            // 
            // labelSensorName
            // 
            this.labelSensorName.AutoSize = true;
            this.labelSensorName.Location = new System.Drawing.Point(10, 23);
            this.labelSensorName.Name = "labelSensorName";
            this.labelSensorName.Size = new System.Drawing.Size(123, 20);
            this.labelSensorName.TabIndex = 0;
            this.labelSensorName.Text = "Instrument Name";
            // 
            // tabPageConnection
            // 
            this.tabPageConnection.Controls.Add(this.buttonReadScaled);
            this.tabPageConnection.Controls.Add(this.buttonReadState);
            this.tabPageConnection.Controls.Add(this.buttonWriteConfiguration);
            this.tabPageConnection.Controls.Add(this.buttonReadConfiguration);
            this.tabPageConnection.Controls.Add(this.textBoxSend);
            this.tabPageConnection.Controls.Add(this.textBox3);
            this.tabPageConnection.Controls.Add(this.labelPort);
            this.tabPageConnection.Controls.Add(this.labelIPAddress);
            this.tabPageConnection.Controls.Add(this.checkBoxCaseSensitive);
            this.tabPageConnection.Controls.Add(this.textBoxCommunication);
            this.tabPageConnection.Controls.Add(this.textBoxIP);
            this.tabPageConnection.Controls.Add(this.textBoxPort);
            this.tabPageConnection.Controls.Add(this.buttonSend);
            this.tabPageConnection.Location = new System.Drawing.Point(4, 29);
            this.tabPageConnection.Name = "tabPageConnection";
            this.tabPageConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConnection.Size = new System.Drawing.Size(955, 428);
            this.tabPageConnection.TabIndex = 1;
            this.tabPageConnection.Text = "Connection";
            this.tabPageConnection.UseVisualStyleBackColor = true;
            // 
            // buttonReadScaled
            // 
            this.buttonReadScaled.Location = new System.Drawing.Point(19, 257);
            this.buttonReadScaled.Name = "buttonReadScaled";
            this.buttonReadScaled.Size = new System.Drawing.Size(189, 27);
            this.buttonReadScaled.TabIndex = 12;
            this.buttonReadScaled.Text = "Read Scaled";
            this.buttonReadScaled.UseVisualStyleBackColor = true;
            this.buttonReadScaled.Click += new System.EventHandler(this.buttonReadScaled_Click);
            // 
            // buttonReadState
            // 
            this.buttonReadState.Location = new System.Drawing.Point(19, 224);
            this.buttonReadState.Name = "buttonReadState";
            this.buttonReadState.Size = new System.Drawing.Size(189, 27);
            this.buttonReadState.TabIndex = 11;
            this.buttonReadState.Text = "Read State";
            this.buttonReadState.UseVisualStyleBackColor = true;
            this.buttonReadState.Click += new System.EventHandler(this.buttonReadState_Click);
            // 
            // buttonWriteConfiguration
            // 
            this.buttonWriteConfiguration.Location = new System.Drawing.Point(19, 191);
            this.buttonWriteConfiguration.Name = "buttonWriteConfiguration";
            this.buttonWriteConfiguration.Size = new System.Drawing.Size(189, 27);
            this.buttonWriteConfiguration.TabIndex = 10;
            this.buttonWriteConfiguration.Text = "Write Configuration";
            this.buttonWriteConfiguration.UseVisualStyleBackColor = true;
            // 
            // buttonReadConfiguration
            // 
            this.buttonReadConfiguration.Location = new System.Drawing.Point(19, 158);
            this.buttonReadConfiguration.Name = "buttonReadConfiguration";
            this.buttonReadConfiguration.Size = new System.Drawing.Size(189, 27);
            this.buttonReadConfiguration.TabIndex = 9;
            this.buttonReadConfiguration.Text = "Read Configuration";
            this.buttonReadConfiguration.UseVisualStyleBackColor = true;
            this.buttonReadConfiguration.Click += new System.EventHandler(this.buttonReadConfiguration_Click);
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(189, 95);
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(125, 27);
            this.textBoxSend.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(610, 324);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(195, 81);
            this.textBox3.TabIndex = 7;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(19, 69);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(35, 20);
            this.labelPort.TabIndex = 6;
            this.labelPort.Text = "Port";
            // 
            // labelIPAddress
            // 
            this.labelIPAddress.AutoSize = true;
            this.labelIPAddress.Location = new System.Drawing.Point(19, 22);
            this.labelIPAddress.Name = "labelIPAddress";
            this.labelIPAddress.Size = new System.Drawing.Size(78, 20);
            this.labelIPAddress.TabIndex = 5;
            this.labelIPAddress.Text = "IP Address";
            // 
            // checkBoxCaseSensitive
            // 
            this.checkBoxCaseSensitive.AutoSize = true;
            this.checkBoxCaseSensitive.Location = new System.Drawing.Point(19, 378);
            this.checkBoxCaseSensitive.Name = "checkBoxCaseSensitive";
            this.checkBoxCaseSensitive.Size = new System.Drawing.Size(124, 24);
            this.checkBoxCaseSensitive.TabIndex = 4;
            this.checkBoxCaseSensitive.Text = "Case Sensitive";
            this.checkBoxCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // textBoxCommunication
            // 
            this.textBoxCommunication.Location = new System.Drawing.Point(482, 19);
            this.textBoxCommunication.Multiline = true;
            this.textBoxCommunication.Name = "textBoxCommunication";
            this.textBoxCommunication.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCommunication.Size = new System.Drawing.Size(467, 299);
            this.textBoxCommunication.TabIndex = 3;
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(119, 19);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(195, 27);
            this.textBoxIP.TabIndex = 2;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(119, 62);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(195, 27);
            this.textBoxPort.TabIndex = 1;
            this.textBoxPort.Text = "5000";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(6, 99);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(121, 27);
            this.buttonSend.TabIndex = 0;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // tabPageLists
            // 
            this.tabPageLists.Controls.Add(this.button1);
            this.tabPageLists.Controls.Add(this.textBox1);
            this.tabPageLists.Controls.Add(this.listBox1);
            this.tabPageLists.Location = new System.Drawing.Point(4, 29);
            this.tabPageLists.Name = "tabPageLists";
            this.tabPageLists.Size = new System.Drawing.Size(955, 428);
            this.tabPageLists.TabIndex = 2;
            this.tabPageLists.Text = "Lists";
            this.tabPageLists.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(538, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(669, 47);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 212);
            this.textBox1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(18, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(205, 264);
            this.listBox1.TabIndex = 0;
            // 
            // tabPageChart
            // 
            this.tabPageChart.Controls.Add(this.buttonAddXY);
            this.tabPageChart.Controls.Add(this.labelY);
            this.tabPageChart.Controls.Add(this.labelX);
            this.tabPageChart.Controls.Add(this.textBoxYValue);
            this.tabPageChart.Controls.Add(this.textBoxXValue);
            this.tabPageChart.Controls.Add(this.chart1);
            this.tabPageChart.Location = new System.Drawing.Point(4, 29);
            this.tabPageChart.Name = "tabPageChart";
            this.tabPageChart.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChart.Size = new System.Drawing.Size(955, 428);
            this.tabPageChart.TabIndex = 3;
            this.tabPageChart.Text = "Chart";
            this.tabPageChart.UseVisualStyleBackColor = true;
            // 
            // buttonAddXY
            // 
            this.buttonAddXY.Location = new System.Drawing.Point(805, 158);
            this.buttonAddXY.Name = "buttonAddXY";
            this.buttonAddXY.Size = new System.Drawing.Size(94, 29);
            this.buttonAddXY.TabIndex = 5;
            this.buttonAddXY.Text = "Add Point";
            this.buttonAddXY.UseVisualStyleBackColor = true;
            this.buttonAddXY.Click += new System.EventHandler(this.buttonAddXY_Click);
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(782, 105);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(17, 20);
            this.labelY.TabIndex = 4;
            this.labelY.Text = "Y";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(782, 52);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(18, 20);
            this.labelX.TabIndex = 3;
            this.labelX.Text = "X";
            // 
            // textBoxYValue
            // 
            this.textBoxYValue.Location = new System.Drawing.Point(805, 105);
            this.textBoxYValue.Name = "textBoxYValue";
            this.textBoxYValue.Size = new System.Drawing.Size(125, 27);
            this.textBoxYValue.TabIndex = 2;
            // 
            // textBoxXValue
            // 
            this.textBoxXValue.Location = new System.Drawing.Point(805, 55);
            this.textBoxXValue.Name = "textBoxXValue";
            this.textBoxXValue.Size = new System.Drawing.Size(125, 27);
            this.textBoxXValue.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea1.AxisX.LabelStyle.Format = "mm:ss";
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(-4, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(587, 419);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(975, 28);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // controlToolStripMenuItem1
            // 
            this.controlToolStripMenuItem1.Name = "controlToolStripMenuItem1";
            this.controlToolStripMenuItem1.Size = new System.Drawing.Size(141, 26);
            this.controlToolStripMenuItem1.Text = "&Control";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.closeToolStripMenuItem.Text = "C&lose";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timerReadScaled
            // 
            this.timerReadScaled.Interval = 3000;
            this.timerReadScaled.Tick += new System.EventHandler(this.timerReadScaled_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(975, 504);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip2;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FirstWFA";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormMain_KeyPress);
            this.tabControl1.ResumeLayout(false);
            this.tabPageRegistered.ResumeLayout(false);
            this.tabPageRegistered.PerformLayout();
            this.panelUnit.ResumeLayout(false);
            this.panelUnit.PerformLayout();
            this.statusStripReady.ResumeLayout(false);
            this.statusStripReady.PerformLayout();
            this.tabPageConnection.ResumeLayout(false);
            this.tabPageConnection.PerformLayout();
            this.tabPageLists.ResumeLayout(false);
            this.tabPageLists.PerformLayout();
            this.tabPageChart.ResumeLayout(false);
            this.tabPageChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private StatusStrip statusStripReady;
        private MenuStrip menuStrip2;
        private TabControl tabControl1;
        private TabPage tabPageRegistered;
        private TabPage tabPageConnection;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem controlToolStripMenuItem1;
        private Label labelSensorName;
        private Label labelSerialNumber;
        private CheckBox checkBoxRegistered;
        private DateTimePicker dateTimePickerRegisterDate;
        private Label labelComment;
        private Label labelOptions;
        private Label labelRegistered;
        private Label labelSignalType;
        private Label labelRegisterDate;
        private ComboBox comboBoxSignalType;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TextBox textBoxComment;
        private MaskedTextBox maskedTextBoxSerialNumber;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem closeToolStripMenuItem;
        private TextBox textBoxRegister;
        private TextBox textBoxCommunication;
        private TextBox textBoxIP;
        private TextBox textBoxPort;
        private Button buttonSend;
        private Label labelMeasureTime;
        private Label labelUnit;
        private Label labelURV;
        private TextBox textBoxURV;
        private TextBox textBoxUnit;
        private Label labelLRV;
        private TextBox textBoxLRV;
        private TextBox textBoxSummary;
        private Panel panelUnit;
        private Button buttonRegisterNew;
        private Button buttonSummary;
        private ComboBox comboBoxMeasureType;
        private CheckBox checkBoxCaseSensitive;
        private TabPage tabPageLists;
        private ListBox listBox1;
        private TextBox textBox3;
        private Label labelPort;
        private Label labelIPAddress;
        private TextBox textBoxSend;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        private Button buttonOpenFIle;
        private OpenFileDialog openFileDialog1;
        private Button buttonSaveToFile;
        private ComboBox comboBoxInstrumentName;
        private Button button1;
        private TextBox textBox1;
        private Button buttonDelete;
        private Button buttonSaveChanges;
        private Label labelAlarmL;
        private TextBox textBoxAlarmL;
        private Label labelAlarmH;
        private TextBox textBoxAlarmH;
        private Button buttonReadScaled;
        private Button buttonReadState;
        private Button buttonWriteConfiguration;
        private Button buttonReadConfiguration;
        private TabPage tabPageChart;
        private Button buttonAddXY;
        private Label labelY;
        private Label labelX;
        private TextBox textBoxYValue;
        private TextBox textBoxXValue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timerReadScaled;
        private ComboBox comboBoxOptions;
    }
}
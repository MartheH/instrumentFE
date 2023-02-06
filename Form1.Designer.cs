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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageRegistered = new System.Windows.Forms.TabPage();
            this.comboBoxInstrumentName = new System.Windows.Forms.ComboBox();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.buttonOpenFIle = new System.Windows.Forms.Button();
            this.comboBoxMeasureType = new System.Windows.Forms.ComboBox();
            this.buttonSummary = new System.Windows.Forms.Button();
            this.groupBoxSelect = new System.Windows.Forms.GroupBox();
            this.buttonRegisterNew = new System.Windows.Forms.Button();
            this.radioButtonSaveChanges = new System.Windows.Forms.RadioButton();
            this.radioButtonRegisterNew = new System.Windows.Forms.RadioButton();
            this.radioButtonClear = new System.Windows.Forms.RadioButton();
            this.panelUnit = new System.Windows.Forms.Panel();
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
            this.listboxOptions = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelRegistered = new System.Windows.Forms.Label();
            this.labelSignalType = new System.Windows.Forms.Label();
            this.labelRegisterDate = new System.Windows.Forms.Label();
            this.comboBoxSignalType = new System.Windows.Forms.ComboBox();
            this.dateTimePickerRegisterDate = new System.Windows.Forms.DateTimePicker();
            this.checkBoxRegistered = new System.Windows.Forms.CheckBox();
            this.labelSerialNumber = new System.Windows.Forms.Label();
            this.textBoxLabelSensorName = new System.Windows.Forms.TextBox();
            this.labelSensorName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelIPAddress = new System.Windows.Forms.Label();
            this.checkBoxCaseSensitive = new System.Windows.Forms.CheckBox();
            this.textBoxCommunication = new System.Windows.Forms.TextBox();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPageRegistered.SuspendLayout();
            this.groupBoxSelect.SuspendLayout();
            this.panelUnit.SuspendLayout();
            this.statusStripReady.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageRegistered);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
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
            this.tabPageRegistered.Controls.Add(this.comboBoxInstrumentName);
            this.tabPageRegistered.Controls.Add(this.buttonSaveToFile);
            this.tabPageRegistered.Controls.Add(this.buttonOpenFIle);
            this.tabPageRegistered.Controls.Add(this.comboBoxMeasureType);
            this.tabPageRegistered.Controls.Add(this.buttonSummary);
            this.tabPageRegistered.Controls.Add(this.groupBoxSelect);
            this.tabPageRegistered.Controls.Add(this.panelUnit);
            this.tabPageRegistered.Controls.Add(this.textBoxSummary);
            this.tabPageRegistered.Controls.Add(this.labelMeasureTime);
            this.tabPageRegistered.Controls.Add(this.textBoxRegister);
            this.tabPageRegistered.Controls.Add(this.statusStripReady);
            this.tabPageRegistered.Controls.Add(this.textBoxComment);
            this.tabPageRegistered.Controls.Add(this.maskedTextBoxSerialNumber);
            this.tabPageRegistered.Controls.Add(this.labelComment);
            this.tabPageRegistered.Controls.Add(this.labelOptions);
            this.tabPageRegistered.Controls.Add(this.listboxOptions);
            this.tabPageRegistered.Controls.Add(this.labelRegistered);
            this.tabPageRegistered.Controls.Add(this.labelSignalType);
            this.tabPageRegistered.Controls.Add(this.labelRegisterDate);
            this.tabPageRegistered.Controls.Add(this.comboBoxSignalType);
            this.tabPageRegistered.Controls.Add(this.dateTimePickerRegisterDate);
            this.tabPageRegistered.Controls.Add(this.checkBoxRegistered);
            this.tabPageRegistered.Controls.Add(this.labelSerialNumber);
            this.tabPageRegistered.Controls.Add(this.textBoxLabelSensorName);
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
            // comboBoxInstrumentName
            // 
            this.comboBoxInstrumentName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxInstrumentName.FormattingEnabled = true;
            this.comboBoxInstrumentName.Location = new System.Drawing.Point(159, 33);
            this.comboBoxInstrumentName.Name = "comboBoxInstrumentName";
            this.comboBoxInstrumentName.Size = new System.Drawing.Size(212, 36);
            this.comboBoxInstrumentName.TabIndex = 25;
            this.comboBoxInstrumentName.SelectedIndexChanged += new System.EventHandler(this.comboBoxInstrumentName_SelectedIndexChanged);
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonSaveToFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveToFile.Location = new System.Drawing.Point(611, 260);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(148, 39);
            this.buttonSaveToFile.TabIndex = 24;
            this.buttonSaveToFile.Text = "Save to File";
            this.buttonSaveToFile.UseVisualStyleBackColor = false;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            // 
            // buttonOpenFIle
            // 
            this.buttonOpenFIle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonOpenFIle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonOpenFIle.Location = new System.Drawing.Point(611, 309);
            this.buttonOpenFIle.Name = "buttonOpenFIle";
            this.buttonOpenFIle.Size = new System.Drawing.Size(148, 39);
            this.buttonOpenFIle.TabIndex = 23;
            this.buttonOpenFIle.Text = "Open File";
            this.buttonOpenFIle.UseVisualStyleBackColor = false;
            this.buttonOpenFIle.Click += new System.EventHandler(this.buttonOpenFIle_Click);
            // 
            // comboBoxMeasureType
            // 
            this.comboBoxMeasureType.FormattingEnabled = true;
            this.comboBoxMeasureType.Items.AddRange(new object[] {
            "Analog",
            "Digital",
            "Fieldbus"});
            this.comboBoxMeasureType.Location = new System.Drawing.Point(159, 202);
            this.comboBoxMeasureType.Name = "comboBoxMeasureType";
            this.comboBoxMeasureType.Size = new System.Drawing.Size(212, 28);
            this.comboBoxMeasureType.TabIndex = 6;
            // 
            // buttonSummary
            // 
            this.buttonSummary.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonSummary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSummary.Location = new System.Drawing.Point(810, 253);
            this.buttonSummary.Name = "buttonSummary";
            this.buttonSummary.Size = new System.Drawing.Size(135, 39);
            this.buttonSummary.TabIndex = 18;
            this.buttonSummary.Text = "Summary";
            this.buttonSummary.UseVisualStyleBackColor = false;
            this.buttonSummary.Click += new System.EventHandler(this.buttonSummary_Click);
            // 
            // groupBoxSelect
            // 
            this.groupBoxSelect.Controls.Add(this.buttonRegisterNew);
            this.groupBoxSelect.Controls.Add(this.radioButtonSaveChanges);
            this.groupBoxSelect.Controls.Add(this.radioButtonRegisterNew);
            this.groupBoxSelect.Controls.Add(this.radioButtonClear);
            this.groupBoxSelect.Location = new System.Drawing.Point(396, 164);
            this.groupBoxSelect.Name = "groupBoxSelect";
            this.groupBoxSelect.Size = new System.Drawing.Size(209, 184);
            this.groupBoxSelect.TabIndex = 13;
            this.groupBoxSelect.TabStop = false;
            // 
            // buttonRegisterNew
            // 
            this.buttonRegisterNew.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonRegisterNew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRegisterNew.Location = new System.Drawing.Point(6, 139);
            this.buttonRegisterNew.Name = "buttonRegisterNew";
            this.buttonRegisterNew.Size = new System.Drawing.Size(183, 39);
            this.buttonRegisterNew.TabIndex = 17;
            this.buttonRegisterNew.Text = "Register New";
            this.buttonRegisterNew.UseVisualStyleBackColor = false;
            this.buttonRegisterNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonSaveChanges
            // 
            this.radioButtonSaveChanges.AutoSize = true;
            this.radioButtonSaveChanges.Location = new System.Drawing.Point(6, 61);
            this.radioButtonSaveChanges.Name = "radioButtonSaveChanges";
            this.radioButtonSaveChanges.Size = new System.Drawing.Size(121, 24);
            this.radioButtonSaveChanges.TabIndex = 15;
            this.radioButtonSaveChanges.Text = "Save Changes";
            this.radioButtonSaveChanges.UseVisualStyleBackColor = true;
            this.radioButtonSaveChanges.CheckedChanged += new System.EventHandler(this.radioButtonSaveChanges_CheckedChanged);
            // 
            // radioButtonRegisterNew
            // 
            this.radioButtonRegisterNew.AutoSize = true;
            this.radioButtonRegisterNew.Checked = true;
            this.radioButtonRegisterNew.Location = new System.Drawing.Point(6, 26);
            this.radioButtonRegisterNew.Name = "radioButtonRegisterNew";
            this.radioButtonRegisterNew.Size = new System.Drawing.Size(118, 24);
            this.radioButtonRegisterNew.TabIndex = 14;
            this.radioButtonRegisterNew.TabStop = true;
            this.radioButtonRegisterNew.Text = "Register New";
            this.radioButtonRegisterNew.UseVisualStyleBackColor = true;
            this.radioButtonRegisterNew.CheckedChanged += new System.EventHandler(this.radioButtonRegisterNew_CheckedChanged);
            // 
            // radioButtonClear
            // 
            this.radioButtonClear.AutoSize = true;
            this.radioButtonClear.Location = new System.Drawing.Point(6, 96);
            this.radioButtonClear.Name = "radioButtonClear";
            this.radioButtonClear.Size = new System.Drawing.Size(64, 24);
            this.radioButtonClear.TabIndex = 16;
            this.radioButtonClear.Text = "Clear";
            this.radioButtonClear.UseVisualStyleBackColor = true;
            this.radioButtonClear.CheckedChanged += new System.EventHandler(this.radioButtonDelete_CheckedChanged);
            // 
            // panelUnit
            // 
            this.panelUnit.Controls.Add(this.textBoxLRV);
            this.panelUnit.Controls.Add(this.labelLRV);
            this.panelUnit.Controls.Add(this.textBoxURV);
            this.panelUnit.Controls.Add(this.labelUnit);
            this.panelUnit.Controls.Add(this.labelURV);
            this.panelUnit.Controls.Add(this.textBoxUnit);
            this.panelUnit.Location = new System.Drawing.Point(396, 20);
            this.panelUnit.Name = "panelUnit";
            this.panelUnit.Size = new System.Drawing.Size(202, 138);
            this.panelUnit.TabIndex = 9;
            // 
            // textBoxLRV
            // 
            this.textBoxLRV.Location = new System.Drawing.Point(82, 28);
            this.textBoxLRV.MaxLength = 1234534;
            this.textBoxLRV.Name = "textBoxLRV";
            this.textBoxLRV.Size = new System.Drawing.Size(96, 27);
            this.textBoxLRV.TabIndex = 10;
            this.textBoxLRV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLRV_KeyPress);
            // 
            // labelLRV
            // 
            this.labelLRV.AutoSize = true;
            this.labelLRV.Location = new System.Drawing.Point(17, 35);
            this.labelLRV.Name = "labelLRV";
            this.labelLRV.Size = new System.Drawing.Size(34, 20);
            this.labelLRV.TabIndex = 21;
            this.labelLRV.Text = "LRV";
            // 
            // textBoxURV
            // 
            this.textBoxURV.Location = new System.Drawing.Point(82, 61);
            this.textBoxURV.MaxLength = 4555555;
            this.textBoxURV.Name = "textBoxURV";
            this.textBoxURV.Size = new System.Drawing.Size(96, 27);
            this.textBoxURV.TabIndex = 11;
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Location = new System.Drawing.Point(17, 102);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(36, 20);
            this.labelUnit.TabIndex = 25;
            this.labelUnit.Text = "Unit";
            // 
            // labelURV
            // 
            this.labelURV.AutoSize = true;
            this.labelURV.Location = new System.Drawing.Point(17, 64);
            this.labelURV.Name = "labelURV";
            this.labelURV.Size = new System.Drawing.Size(37, 20);
            this.labelURV.TabIndex = 24;
            this.labelURV.Text = "URV";
            // 
            // textBoxUnit
            // 
            this.textBoxUnit.Location = new System.Drawing.Point(82, 99);
            this.textBoxUnit.MaxLength = 4;
            this.textBoxUnit.Name = "textBoxUnit";
            this.textBoxUnit.Size = new System.Drawing.Size(96, 27);
            this.textBoxUnit.TabIndex = 12;
            // 
            // textBoxSummary
            // 
            this.textBoxSummary.Location = new System.Drawing.Point(797, 23);
            this.textBoxSummary.Multiline = true;
            this.textBoxSummary.Name = "textBoxSummary";
            this.textBoxSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSummary.Size = new System.Drawing.Size(152, 226);
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
            this.textBoxRegister.Location = new System.Drawing.Point(611, 23);
            this.textBoxRegister.Multiline = true;
            this.textBoxRegister.Name = "textBoxRegister";
            this.textBoxRegister.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRegister.Size = new System.Drawing.Size(167, 226);
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
            this.textBoxComment.Size = new System.Drawing.Size(212, 63);
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
            this.labelComment.Location = new System.Drawing.Point(6, 303);
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
            // listboxOptions
            // 
            this.listboxOptions.ContextMenuStrip = this.contextMenuStrip1;
            this.listboxOptions.FormattingEnabled = true;
            this.listboxOptions.ItemHeight = 20;
            this.listboxOptions.Items.AddRange(new object[] {
            "None",
            "Display"});
            this.listboxOptions.Location = new System.Drawing.Point(159, 248);
            this.listboxOptions.Name = "listboxOptions";
            this.listboxOptions.Size = new System.Drawing.Size(212, 44);
            this.listboxOptions.TabIndex = 7;
            this.listboxOptions.MouseHover += new System.EventHandler(this.listboxOptions_MouseHover);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            this.checkBoxRegistered.Location = new System.Drawing.Point(159, 108);
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
            // textBoxLabelSensorName
            // 
            this.textBoxLabelSensorName.Location = new System.Drawing.Point(159, 0);
            this.textBoxLabelSensorName.Name = "textBoxLabelSensorName";
            this.textBoxLabelSensorName.Size = new System.Drawing.Size(212, 27);
            this.textBoxLabelSensorName.TabIndex = 1;
            this.textBoxLabelSensorName.MouseHover += new System.EventHandler(this.textBoxLabelSensorName_MouseHover);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxSend);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.labelPort);
            this.tabPage2.Controls.Add(this.labelIPAddress);
            this.tabPage2.Controls.Add(this.checkBoxCaseSensitive);
            this.tabPage2.Controls.Add(this.textBoxCommunication);
            this.tabPage2.Controls.Add(this.textBoxIP);
            this.tabPage2.Controls.Add(this.textBoxPort);
            this.tabPage2.Controls.Add(this.buttonSend);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(955, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Connection";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.textBox3.Location = new System.Drawing.Point(119, 132);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(195, 147);
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
            this.checkBoxCaseSensitive.Location = new System.Drawing.Point(19, 102);
            this.checkBoxCaseSensitive.Name = "checkBoxCaseSensitive";
            this.checkBoxCaseSensitive.Size = new System.Drawing.Size(124, 24);
            this.checkBoxCaseSensitive.TabIndex = 4;
            this.checkBoxCaseSensitive.Text = "Case Sensitive";
            this.checkBoxCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // textBoxCommunication
            // 
            this.textBoxCommunication.Location = new System.Drawing.Point(387, 22);
            this.textBoxCommunication.Multiline = true;
            this.textBoxCommunication.Name = "textBoxCommunication";
            this.textBoxCommunication.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCommunication.Size = new System.Drawing.Size(235, 299);
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
            this.buttonSend.Location = new System.Drawing.Point(119, 285);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(195, 36);
            this.buttonSend.TabIndex = 0;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(955, 428);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Lists";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1KeyPress);
            this.tabControl1.ResumeLayout(false);
            this.tabPageRegistered.ResumeLayout(false);
            this.tabPageRegistered.PerformLayout();
            this.groupBoxSelect.ResumeLayout(false);
            this.groupBoxSelect.PerformLayout();
            this.panelUnit.ResumeLayout(false);
            this.panelUnit.PerformLayout();
            this.statusStripReady.ResumeLayout(false);
            this.statusStripReady.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
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
        private TabPage tabPage2;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem controlToolStripMenuItem1;
        private TextBox textBoxLabelSensorName;
        private Label labelSensorName;
        private Label labelSerialNumber;
        private CheckBox checkBoxRegistered;
        private DateTimePicker dateTimePickerRegisterDate;
        private Label labelComment;
        private Label labelOptions;
        private ListBox listboxOptions;
        private Label labelRegistered;
        private Label labelSignalType;
        private Label labelRegisterDate;
        private ComboBox comboBoxSignalType;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TextBox textBoxComment;
        private MaskedTextBox maskedTextBoxSerialNumber;
        private RadioButton radioButtonSaveChanges;
        private RadioButton radioButtonClear;
        private RadioButton radioButtonRegisterNew;
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
        private GroupBox groupBoxSelect;
        private Button buttonRegisterNew;
        private Button buttonSummary;
        private ComboBox comboBoxMeasureType;
        private CheckBox checkBoxCaseSensitive;
        private TabPage tabPage1;
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
    }
}
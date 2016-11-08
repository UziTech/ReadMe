namespace ReadMe
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.bResume = new System.Windows.Forms.Button();
            this.bPause = new System.Windows.Forms.Button();
            this.tbOutputType = new System.Windows.Forms.TextBox();
            this.bChangeType = new System.Windows.Forms.Button();
            this.bEditOutput = new System.Windows.Forms.Button();
            this.bEditInput = new System.Windows.Forms.Button();
            this.bRemoveOutput = new System.Windows.Forms.Button();
            this.bAddOutput = new System.Windows.Forms.Button();
            this.bRemoveInput = new System.Windows.Forms.Button();
            this.bAddInput = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bSaveSettings = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tbInterval = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbFromName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbFromAddress = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.bTestSMTP = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbHTML = new System.Windows.Forms.CheckBox();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSSL = new System.Windows.Forms.CheckBox();
            this.tbSMTPPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSMTPAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbOutput = new ToolTipListBox();
            this.lbInput = new ToolTipListBox();
            this.tabControl.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabGeneral);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(0, 25);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(500, 436);
            this.tabControl.TabIndex = 0;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.bResume);
            this.tabGeneral.Controls.Add(this.bPause);
            this.tabGeneral.Controls.Add(this.tbOutputType);
            this.tabGeneral.Controls.Add(this.bChangeType);
            this.tabGeneral.Controls.Add(this.bEditOutput);
            this.tabGeneral.Controls.Add(this.bEditInput);
            this.tabGeneral.Controls.Add(this.bRemoveOutput);
            this.tabGeneral.Controls.Add(this.bAddOutput);
            this.tabGeneral.Controls.Add(this.bRemoveInput);
            this.tabGeneral.Controls.Add(this.bAddInput);
            this.tabGeneral.Controls.Add(this.label3);
            this.tabGeneral.Controls.Add(this.label2);
            this.tabGeneral.Controls.Add(this.label1);
            this.tabGeneral.Controls.Add(this.lbOutput);
            this.tabGeneral.Controls.Add(this.lbInput);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(492, 410);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // bResume
            // 
            this.bResume.Location = new System.Drawing.Point(248, 366);
            this.bResume.Name = "bResume";
            this.bResume.Size = new System.Drawing.Size(75, 23);
            this.bResume.TabIndex = 18;
            this.bResume.Text = "Resume";
            this.bResume.UseVisualStyleBackColor = true;
            this.bResume.Click += new System.EventHandler(this.bResume_Click);
            // 
            // bPause
            // 
            this.bPause.Enabled = false;
            this.bPause.Location = new System.Drawing.Point(167, 366);
            this.bPause.Name = "bPause";
            this.bPause.Size = new System.Drawing.Size(75, 23);
            this.bPause.TabIndex = 17;
            this.bPause.Text = "Pause";
            this.bPause.UseVisualStyleBackColor = true;
            this.bPause.Click += new System.EventHandler(this.bPause_Click);
            // 
            // tbOutputType
            // 
            this.tbOutputType.Location = new System.Drawing.Point(11, 318);
            this.tbOutputType.Name = "tbOutputType";
            this.tbOutputType.ReadOnly = true;
            this.tbOutputType.Size = new System.Drawing.Size(100, 20);
            this.tbOutputType.TabIndex = 13;
            this.tbOutputType.DoubleClick += new System.EventHandler(this.tbOutputType_DoubleClick);
            // 
            // bChangeType
            // 
            this.bChangeType.Enabled = false;
            this.bChangeType.Location = new System.Drawing.Point(10, 345);
            this.bChangeType.Name = "bChangeType";
            this.bChangeType.Size = new System.Drawing.Size(101, 23);
            this.bChangeType.TabIndex = 12;
            this.bChangeType.Text = "Change";
            this.bChangeType.UseVisualStyleBackColor = true;
            this.bChangeType.Click += new System.EventHandler(this.bChangeType_Click);
            // 
            // bEditOutput
            // 
            this.bEditOutput.Enabled = false;
            this.bEditOutput.Location = new System.Drawing.Point(407, 212);
            this.bEditOutput.Name = "bEditOutput";
            this.bEditOutput.Size = new System.Drawing.Size(56, 23);
            this.bEditOutput.TabIndex = 11;
            this.bEditOutput.Text = "Edit";
            this.bEditOutput.UseVisualStyleBackColor = true;
            this.bEditOutput.Click += new System.EventHandler(this.bEditOutput_Click);
            // 
            // bEditInput
            // 
            this.bEditInput.Enabled = false;
            this.bEditInput.Location = new System.Drawing.Point(407, 70);
            this.bEditInput.Name = "bEditInput";
            this.bEditInput.Size = new System.Drawing.Size(56, 23);
            this.bEditInput.TabIndex = 10;
            this.bEditInput.Text = "Edit";
            this.bEditInput.UseVisualStyleBackColor = true;
            this.bEditInput.Click += new System.EventHandler(this.bEditInput_Click);
            // 
            // bRemoveOutput
            // 
            this.bRemoveOutput.Enabled = false;
            this.bRemoveOutput.Location = new System.Drawing.Point(407, 248);
            this.bRemoveOutput.Name = "bRemoveOutput";
            this.bRemoveOutput.Size = new System.Drawing.Size(56, 23);
            this.bRemoveOutput.TabIndex = 9;
            this.bRemoveOutput.Text = "Remove";
            this.bRemoveOutput.UseVisualStyleBackColor = true;
            this.bRemoveOutput.Click += new System.EventHandler(this.bRemoveOutput_Click);
            // 
            // bAddOutput
            // 
            this.bAddOutput.Enabled = false;
            this.bAddOutput.Location = new System.Drawing.Point(407, 176);
            this.bAddOutput.Name = "bAddOutput";
            this.bAddOutput.Size = new System.Drawing.Size(56, 23);
            this.bAddOutput.TabIndex = 8;
            this.bAddOutput.Text = "Add";
            this.bAddOutput.UseVisualStyleBackColor = true;
            this.bAddOutput.Click += new System.EventHandler(this.bAddOutput_Click);
            // 
            // bRemoveInput
            // 
            this.bRemoveInput.Enabled = false;
            this.bRemoveInput.Location = new System.Drawing.Point(407, 106);
            this.bRemoveInput.Name = "bRemoveInput";
            this.bRemoveInput.Size = new System.Drawing.Size(56, 23);
            this.bRemoveInput.TabIndex = 7;
            this.bRemoveInput.Text = "Remove";
            this.bRemoveInput.UseVisualStyleBackColor = true;
            this.bRemoveInput.Click += new System.EventHandler(this.bRemoveInput_Click);
            // 
            // bAddInput
            // 
            this.bAddInput.Location = new System.Drawing.Point(407, 34);
            this.bAddInput.Name = "bAddInput";
            this.bAddInput.Size = new System.Drawing.Size(56, 23);
            this.bAddInput.TabIndex = 6;
            this.bAddInput.Text = "Add";
            this.bAddInput.UseVisualStyleBackColor = true;
            this.bAddInput.Click += new System.EventHandler(this.bAddInput_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Output Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output Directories:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "WatchThese Directories:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bSaveSettings);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.tbInterval);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.tbFromName);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.tbFromAddress);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.tbConfirmPassword);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.tbPassword);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.tbUsername);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.bTestSMTP);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.cbHTML);
            this.tabPage2.Controls.Add(this.tbSubject);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.tbMessage);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cbSSL);
            this.tabPage2.Controls.Add(this.tbSMTPPort);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tbSMTPAddress);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(492, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bSaveSettings
            // 
            this.bSaveSettings.Location = new System.Drawing.Point(264, 377);
            this.bSaveSettings.Name = "bSaveSettings";
            this.bSaveSettings.Size = new System.Drawing.Size(99, 23);
            this.bSaveSettings.TabIndex = 36;
            this.bSaveSettings.Text = "Save Settings";
            this.bSaveSettings.UseVisualStyleBackColor = true;
            this.bSaveSettings.Click += new System.EventHandler(this.bSaveSettings_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Seconds";
            // 
            // tbInterval
            // 
            this.tbInterval.Location = new System.Drawing.Point(12, 310);
            this.tbInterval.Name = "tbInterval";
            this.tbInterval.Size = new System.Drawing.Size(39, 20);
            this.tbInterval.TabIndex = 34;
            this.tbInterval.Text = "5.0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Ineterval:";
            // 
            // tbFromName
            // 
            this.tbFromName.Location = new System.Drawing.Point(130, 183);
            this.tbFromName.Name = "tbFromName";
            this.tbFromName.Size = new System.Drawing.Size(351, 20);
            this.tbFromName.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 186);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "From Name:";
            // 
            // tbFromAddress
            // 
            this.tbFromAddress.Location = new System.Drawing.Point(130, 157);
            this.tbFromAddress.Name = "tbFromAddress";
            this.tbFromAddress.Size = new System.Drawing.Size(351, 20);
            this.tbFromAddress.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 160);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "From Address:";
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Location = new System.Drawing.Point(130, 131);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.Size = new System.Drawing.Size(351, 20);
            this.tbConfirmPassword.TabIndex = 28;
            this.tbConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 134);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Confirm Password:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(130, 105);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(351, 20);
            this.tbPassword.TabIndex = 26;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Password:";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(130, 79);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(351, 20);
            this.tbUsername.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Username:";
            // 
            // bTestSMTP
            // 
            this.bTestSMTP.Location = new System.Drawing.Point(129, 377);
            this.bTestSMTP.Name = "bTestSMTP";
            this.bTestSMTP.Size = new System.Drawing.Size(129, 23);
            this.bTestSMTP.TabIndex = 22;
            this.bTestSMTP.Text = "Test SMTP Settings";
            this.bTestSMTP.UseVisualStyleBackColor = true;
            this.bTestSMTP.Click += new System.EventHandler(this.bTestSMTP_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "HTML:";
            // 
            // cbHTML
            // 
            this.cbHTML.AutoSize = true;
            this.cbHTML.Location = new System.Drawing.Point(55, 264);
            this.cbHTML.Name = "cbHTML";
            this.cbHTML.Size = new System.Drawing.Size(15, 14);
            this.cbHTML.TabIndex = 10;
            this.cbHTML.UseVisualStyleBackColor = true;
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(130, 209);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(351, 20);
            this.tbSubject.TabIndex = 9;
            this.tbSubject.Text = "Scanned Document Transformed by ReadMe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Subject:";
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(130, 235);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(351, 94);
            this.tbMessage.TabIndex = 7;
            this.tbMessage.Tag = "";
            this.tbMessage.Text = "Open all attatchments. Do not reply to this email address.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Message:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Requires SSL:";
            // 
            // cbSSL
            // 
            this.cbSSL.AutoSize = true;
            this.cbSSL.Location = new System.Drawing.Point(130, 59);
            this.cbSSL.Name = "cbSSL";
            this.cbSSL.Size = new System.Drawing.Size(15, 14);
            this.cbSSL.TabIndex = 4;
            this.cbSSL.UseVisualStyleBackColor = true;
            // 
            // tbSMTPPort
            // 
            this.tbSMTPPort.Location = new System.Drawing.Point(130, 32);
            this.tbSMTPPort.Name = "tbSMTPPort";
            this.tbSMTPPort.Size = new System.Drawing.Size(100, 20);
            this.tbSMTPPort.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "SMTP Server Port:";
            // 
            // tbSMTPAddress
            // 
            this.tbSMTPAddress.Location = new System.Drawing.Point(130, 6);
            this.tbSMTPAddress.Name = "tbSMTPAddress";
            this.tbSMTPAddress.Size = new System.Drawing.Size(351, 20);
            this.tbSMTPAddress.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "SMTP Server Address:";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "ReadMe";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemOpen,
            this.toolStripSeparator1,
            this.menuItemExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(112, 54);
            // 
            // menuItemOpen
            // 
            this.menuItemOpen.Name = "menuItemOpen";
            this.menuItemOpen.Size = new System.Drawing.Size(111, 22);
            this.menuItemOpen.Text = "&Open";
            this.menuItemOpen.Click += new System.EventHandler(this.menuItemOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(108, 6);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(111, 22);
            this.menuItemExit.Text = "E&xit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(498, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readNowToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // readNowToolStripMenuItem
            // 
            this.readNowToolStripMenuItem.Name = "readNowToolStripMenuItem";
            this.readNowToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.readNowToolStripMenuItem.Text = "&Read Now";
            this.readNowToolStripMenuItem.Click += new System.EventHandler(this.readNowToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(131, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lbOutput
            // 
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.Location = new System.Drawing.Point(11, 176);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(390, 95);
            this.lbOutput.TabIndex = 1;
            this.lbOutput.SelectedIndexChanged += new System.EventHandler(this.lbOutput_SelectedIndexChanged);
            this.lbOutput.DoubleClick += new System.EventHandler(this.lbOutput_DoubleClick);
            this.lbOutput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbOutput_KeyDown);
            // 
            // lbInput
            // 
            this.lbInput.FormattingEnabled = true;
            this.lbInput.Location = new System.Drawing.Point(11, 34);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(390, 95);
            this.lbInput.TabIndex = 0;
            this.lbInput.SelectedIndexChanged += new System.EventHandler(this.lbInput_SelectedIndexChanged);
            this.lbInput.DoubleClick += new System.EventHandler(this.lbInput_DoubleClick);
            this.lbInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbInput_KeyDown);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 459);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Read-Me";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bAddInput;
        private System.Windows.Forms.Button bRemoveOutput;
        private System.Windows.Forms.Button bAddOutput;
        private System.Windows.Forms.Button bRemoveInput;
        private System.Windows.Forms.Button bChangeType;
        private System.Windows.Forms.Button bEditOutput;
        private System.Windows.Forms.Button bEditInput;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox tbOutputType;
        private System.Windows.Forms.TextBox tbSMTPAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbHTML;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbSSL;
        private System.Windows.Forms.TextBox tbSMTPPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bTestSMTP;
        private System.Windows.Forms.TextBox tbFromName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbFromAddress;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button bResume;
        private System.Windows.Forms.Button bPause;
        private System.Windows.Forms.Button bSaveSettings;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbInterval;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readNowToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private ToolTipListBox lbOutput;
        private ToolTipListBox lbInput;
    }
}
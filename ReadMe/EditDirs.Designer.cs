namespace ReadMe
{
    partial class EditDirs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDirs));
            this.bOK = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.lput = new System.Windows.Forms.Label();
            this.lType = new System.Windows.Forms.Label();
            this.lError = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.tbput = new System.Windows.Forms.TextBox();
            this.bBrowse = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.chbEmailAddress = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // bOK
            // 
            this.bOK.Location = new System.Drawing.Point(82, 98);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(75, 23);
            this.bOK.TabIndex = 0;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(175, 98);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 1;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // lput
            // 
            this.lput.AutoSize = true;
            this.lput.Location = new System.Drawing.Point(9, 7);
            this.lput.Name = "lput";
            this.lput.Size = new System.Drawing.Size(84, 13);
            this.lput.TabIndex = 3;
            this.lput.Text = "Output Directory";
            this.lput.Visible = false;
            // 
            // lType
            // 
            this.lType.AutoSize = true;
            this.lType.Location = new System.Drawing.Point(9, 46);
            this.lType.Name = "lType";
            this.lType.Size = new System.Drawing.Size(66, 13);
            this.lType.TabIndex = 4;
            this.lType.Text = "Output Type";
            this.lType.Visible = false;
            // 
            // lError
            // 
            this.lError.AutoSize = true;
            this.lError.Location = new System.Drawing.Point(130, 23);
            this.lError.Name = "lError";
            this.lError.Size = new System.Drawing.Size(72, 13);
            this.lError.TabIndex = 5;
            this.lError.Text = "Wrong Mode.";
            this.lError.Visible = false;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "PDF",
            "DOC"});
            this.cbType.Location = new System.Drawing.Point(12, 62);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 6;
            this.cbType.Visible = false;
            // 
            // tbput
            // 
            this.tbput.Location = new System.Drawing.Point(12, 23);
            this.tbput.Name = "tbput";
            this.tbput.Size = new System.Drawing.Size(315, 20);
            this.tbput.TabIndex = 7;
            this.tbput.Visible = false;
            // 
            // bBrowse
            // 
            this.bBrowse.Location = new System.Drawing.Point(252, 49);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(75, 23);
            this.bBrowse.TabIndex = 8;
            this.bBrowse.Text = "Browse";
            this.bBrowse.UseVisualStyleBackColor = true;
            this.bBrowse.Visible = false;
            this.bBrowse.Click += new System.EventHandler(this.bBrowse_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.DesktopDirectory;
            // 
            // chbEmailAddress
            // 
            this.chbEmailAddress.AutoSize = true;
            this.chbEmailAddress.Location = new System.Drawing.Point(150, 53);
            this.chbEmailAddress.Name = "chbEmailAddress";
            this.chbEmailAddress.Size = new System.Drawing.Size(96, 17);
            this.chbEmailAddress.TabIndex = 9;
            this.chbEmailAddress.Text = "E-Mail Address";
            this.chbEmailAddress.UseVisualStyleBackColor = true;
            this.chbEmailAddress.Visible = false;
            // 
            // EditDirs
            // 
            this.AcceptButton = this.bOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(339, 133);
            this.Controls.Add(this.chbEmailAddress);
            this.Controls.Add(this.bBrowse);
            this.Controls.Add(this.tbput);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.lError);
            this.Controls.Add(this.lType);
            this.Controls.Add(this.lput);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditDirs";
            this.ShowInTaskbar = false;
            this.Text = "EditDirs";
            this.Load += new System.EventHandler(this.EditDirs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label lput;
        private System.Windows.Forms.Label lType;
        private System.Windows.Forms.Label lError;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox tbput;
        private System.Windows.Forms.Button bBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox chbEmailAddress;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Xml;
using System.IO;

namespace ReadMe
{

    public partial class Main : Form
    {

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
        static extern void SwitchToThisWindow(IntPtr hWnd, bool fAltTab);
        const int ADD_INPUT = 1;
        const int EDIT_INPUT = 2;
        const int ADD_OUTPUT = 3;
        const int EDIT_OUTPUT = 4;
        const int CHANGE_TYPE = 5;
        private int inSel = -1;
        private int outSel = -1;
        private bool sel = false;

        const string XML = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\n<directories>\n</directories>";

        private ReadDir[] iDirs = new ReadDir[0];
        private string _xmlFile = @"Directories.xml";
        private bool _close = false;

        public Main()
        {
            InitializeComponent();
            foreach (string arg in Environment.GetCommandLineArgs())
            {
                if (arg == "-tray")
                {
                    WindowState = FormWindowState.Minimized;
                    ShowInTaskbar = false;
                }
                else if(arg == "-start")
                {
                    bPause.Enabled = true;
                    bResume.Enabled = false;
                    timer1.Enabled = true;
                }
            }
            InitializeIDirs();
            tbSMTPAddress.Text = Properties.Settings.Default.SMTPServer;
            tbSMTPPort.Text = Properties.Settings.Default.SMTPPort.ToString();
            cbSSL.Checked = Properties.Settings.Default.SSL;
            tbUsername.Text = Properties.Settings.Default.Username;
            tbPassword.Text = Properties.Settings.Default.Password;
            tbConfirmPassword.Text = Properties.Settings.Default.Password;
            tbFromAddress.Text = Properties.Settings.Default.FromAddress;
            tbFromName.Text = Properties.Settings.Default.FromName;
            tbSubject.Text = Properties.Settings.Default.Subject;
            tbMessage.Text = Properties.Settings.Default.Message;
            cbHTML.Checked = Properties.Settings.Default.HTML;
            tbInterval.Text = (Properties.Settings.Default.Interval / 1000.0).ToString();

            timer1.Interval = Properties.Settings.Default.Interval;
        }

        private void bAddInput_Click(object sender, EventArgs e)
        {
            EditDirs form = new EditDirs(ADD_INPUT, iDirs);
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                XmlDocument xDoc = XMLDoc();
                XmlElement input = xDoc.CreateElement("input");
                XmlAttribute dir = xDoc.CreateAttribute("dir");
                dir.InnerText = form._iDir;
                input.SetAttributeNode(dir);
                xDoc.DocumentElement.AppendChild(input);
                xDoc.Save(_xmlFile);

                ReadDir[] temp = iDirs;
                iDirs = new ReadDir[temp.Length + 1];
                for (int i = 0; i < temp.Length; i++)
                {
                    iDirs[i] = temp[i];
                }
                iDirs[iDirs.Length - 1] = new ReadDir(form._iDir);

                loadInputDirs();
                lbInput.SelectedIndex = iDirs.Length - 1;
            }
        }

        private void bEditInput_Click(object sender, EventArgs e)
        {
            EditDirs form = new EditDirs(EDIT_INPUT, iDirs);
            form._iDir = lbInput.SelectedItem.ToString();
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                XmlDocument xDoc = XMLDoc();
                xDoc.GetElementsByTagName("input").Item(lbInput.SelectedIndex).Attributes.GetNamedItem("dir").InnerText = form._iDir;
                xDoc.Save(_xmlFile);

                iDirs[lbInput.SelectedIndex].InputDirectory = form._iDir;

                loadInputDirs();
                sel = true;
                lbInput.SelectedIndex = inSel;
            }
        }

        private void bRemoveInput_Click(object sender, EventArgs e)
        {
            XmlDocument xDoc = XMLDoc();
            xDoc.DocumentElement.RemoveChild(xDoc.GetElementsByTagName("input").Item(lbInput.SelectedIndex));
            xDoc.Save(_xmlFile);
            ReadDir[] temp = iDirs;
            iDirs = new ReadDir[temp.Length - 1];
            for (int i = 0; i < iDirs.Length; i++)
            {
                if (i < lbInput.SelectedIndex)
                {
                    iDirs[i] = temp[i];
                }
                else
                {
                    iDirs[i] = temp[i + 1];
                }
            }
            loadInputDirs();
            outSel = -1;
            inSel = -1;
        }

        private void bAddOutput_Click(object sender, EventArgs e)
        {
            EditDirs form = new EditDirs(ADD_OUTPUT, iDirs);
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                XmlDocument xDoc = XMLDoc();
                XmlElement output = xDoc.CreateElement("output");
                XmlAttribute dir = xDoc.CreateAttribute("dir");
                dir.InnerText = form._oDir;
                output.SetAttributeNode(dir);
                XmlAttribute type = xDoc.CreateAttribute("type");
                type.InnerText = form._oType;
                output.SetAttributeNode(type);
                XmlAttribute email = xDoc.CreateAttribute("email");
                email.InnerText = (form._oEmail ? "true": "false");
                output.SetAttributeNode(email);
                xDoc.GetElementsByTagName("input").Item(lbInput.SelectedIndex).AppendChild(output);
                xDoc.Save(_xmlFile);

                iDirs[lbInput.SelectedIndex].AddOutputDirectory(form._oDir, form._oType, form._oEmail);

                loadInputDirs();
                outSel = iDirs[inSel].GetOutputDirectories().Length - 1;
                sel = true;
                lbInput.SelectedIndex = inSel;
            }
        }

        private void bEditOutput_Click(object sender, EventArgs e)
        {
            EditDirs form = new EditDirs(EDIT_OUTPUT, iDirs);
            form._oDir = lbOutput.SelectedItem.ToString();
            form._oEmail = iDirs[lbInput.SelectedIndex].GetIsEmail(lbOutput.SelectedIndex);
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                XmlDocument xDoc = XMLDoc();
                xDoc.GetElementsByTagName("input").Item(lbInput.SelectedIndex).ChildNodes.Item(lbOutput.SelectedIndex).Attributes.GetNamedItem("dir").InnerText = form._oDir;
                xDoc.GetElementsByTagName("input").Item(lbInput.SelectedIndex).ChildNodes.Item(lbOutput.SelectedIndex).Attributes.GetNamedItem("email").InnerText = (form._oEmail ? "true" : "false");
                
                xDoc.Save(_xmlFile);

                iDirs[lbInput.SelectedIndex].ChangeOutputDirectory(lbOutput.SelectedIndex, form._oDir, form._oEmail);

                loadInputDirs();
                sel = true;
                lbInput.SelectedIndex = inSel;
            }
        }

        private void bRemoveOutput_Click(object sender, EventArgs e)
        {
            XmlDocument xDoc = XMLDoc();
            xDoc.GetElementsByTagName("input").Item(lbInput.SelectedIndex).RemoveChild(xDoc.GetElementsByTagName("input").Item(lbInput.SelectedIndex).ChildNodes.Item(lbOutput.SelectedIndex));
            xDoc.Save(_xmlFile);
            iDirs[lbInput.SelectedIndex].RemoveOutputDirectory(lbOutput.SelectedIndex);
            loadInputDirs();
            outSel = -1;
            sel = true;
            lbInput.SelectedIndex = inSel;
        }

        private void bChangeType_Click(object sender, EventArgs e)
        {
            EditDirs form = new EditDirs(CHANGE_TYPE, iDirs);
            form._oType = tbOutputType.Text;
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                XmlDocument xDoc = XMLDoc();
                xDoc.GetElementsByTagName("input").Item(lbInput.SelectedIndex).ChildNodes.Item(lbOutput.SelectedIndex).Attributes.GetNamedItem("type").InnerText = form._oType;
                
                iDirs[lbInput.SelectedIndex].ChangeOutputType(lbOutput.SelectedIndex, form._oType);

                loadInputDirs();
                sel = true;
                lbInput.SelectedIndex = inSel;
            }
        }

        private void bPause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            bResume.Enabled = true;
            bPause.Enabled = false;
        }

        private void bResume_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            bResume.Enabled = false;
            bPause.Enabled = true;
        }

        private void bTestSMTP_Click(object sender, EventArgs e)
        {
            int port = 25;
            try
            {
                port = Convert.ToInt32(tbSMTPPort.Text);
                if (port != Convert.ToDouble(tbSMTPPort.Text))
                {
                    throw new Exception("Must be an integer.");
                }
                if (port < 0 || port > 65535)
                {
                    throw new Exception("Must be between 0 and 65535");
                }
            }
            catch
            {
                MessageBox.Show("Port must be an integer between 0 and 65535.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSMTPPort.Focus();
                tbSMTPPort.SelectAll();
                return;
            }

            if (tbPassword.Text != tbConfirmPassword.Text)
            {
                MessageBox.Show("The passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbConfirmPassword.Clear();
                tbPassword.Clear();
                tbPassword.Focus();
                tbPassword.SelectAll();
                return;
            }

            if (!Regex.IsMatch(tbFromAddress.Text, @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))
            {
                MessageBox.Show("From address is not a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbFromAddress.Focus();
                tbFromAddress.SelectAll();
                return;
            }

            try
            {
                ReadDir.SendMail(tbSMTPAddress.Text, port, cbSSL.Checked, tbUsername.Text, tbPassword.Text, tbFromAddress.Text, tbFromName.Text, "ReadMe Test", "This email is to test the smtp server", cbHTML.Checked, new string[] { tbFromAddress.Text }, new string[] { });

                MessageBox.Show("Test Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bSaveSettings_Click(object sender, EventArgs e)
        {
            int port = 25, interval = 5000;
            try
            {
                interval = Convert.ToInt32(Convert.ToDouble(tbInterval.Text) * 1000);
                if (interval <= 0)
                {
                    throw new Exception("Must be greater than 0");
                }
            }
            catch
            {
                MessageBox.Show("Interval must be a number greater than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbInterval.Focus();
                tbInterval.SelectAll();
                return;
            }

            try
            {
                port = Convert.ToInt32(tbSMTPPort.Text);
                if (port != Convert.ToDouble(tbSMTPPort.Text))
                {
                    throw new Exception("Must be an integer.");
                }
                if (port < 0 || port > 65535)
                {
                    throw new Exception("Must be between 0 and 65535");
                }
            }
            catch
            {
                MessageBox.Show("Port must be an integer between 0 and 65535.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSMTPPort.Focus();
                tbSMTPPort.SelectAll();
                return;
            }

            if (tbPassword.Text != tbConfirmPassword.Text)
            {
                MessageBox.Show("The passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbConfirmPassword.Clear();
                tbPassword.Clear();
                tbPassword.Focus();
                tbPassword.SelectAll();
                return;
            }

            if (!Regex.IsMatch(tbFromAddress.Text, @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))
            {
                MessageBox.Show("From address is not a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbFromAddress.Focus();
                tbFromAddress.SelectAll();
                return;
            }

            Properties.Settings.Default.SMTPServer = tbSMTPAddress.Text;
            Properties.Settings.Default.SMTPPort = port;
            Properties.Settings.Default.SSL = cbSSL.Checked;
            Properties.Settings.Default.Username = tbUsername.Text;
            Properties.Settings.Default.Password = tbPassword.Text;
            Properties.Settings.Default.FromAddress = tbFromAddress.Text;
            Properties.Settings.Default.FromName = tbFromName.Text;
            Properties.Settings.Default.Subject = tbSubject.Text;
            Properties.Settings.Default.Message = tbMessage.Text;
            Properties.Settings.Default.HTML = cbHTML.Checked;
            Properties.Settings.Default.Interval = interval;

            Properties.Settings.Default.Save();

            timer1.Interval = interval;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            loadInputDirs();
        }

        private void loadInputDirs()
        {
            bEditInput.Enabled = false;
            bRemoveInput.Enabled = false;
            bAddOutput.Enabled = false;
            bEditOutput.Enabled = false;
            bRemoveOutput.Enabled = false;
            bChangeType.Enabled = false;
            lbInput.Items.Clear();
            lbOutput.Items.Clear();
            tbOutputType.Text = "";
            foreach (ReadDir r in iDirs)
            {
                lbInput.Items.Add(r.InputDirectory);
            }
        }

        private void lbInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inSel != lbInput.SelectedIndex || sel)
            {
                bEditOutput.Enabled = false;
                bRemoveOutput.Enabled = false;
                bChangeType.Enabled = false;
                inSel = lbInput.SelectedIndex;
                if (lbInput.SelectedIndex != -1)
                {
                    lbOutput.Items.Clear();
                    tbOutputType.Text = "";
                    foreach (string s in iDirs[lbInput.SelectedIndex].GetOutputDirectories())
                    {
                        lbOutput.Items.Add(s);
                    }
                    bEditInput.Enabled = true;
                    bRemoveInput.Enabled = true;
                    bAddOutput.Enabled = true;
                }
                else
                {
                    bEditInput.Enabled = false;
                    bRemoveInput.Enabled = false;
                    bAddOutput.Enabled = false;
                }
                if (sel)
                {
                    lbOutput.SelectedIndex = outSel;
                }
                else
                {
                    outSel = -1;
                }
            }
        }

        private void lbOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (outSel != lbOutput.SelectedIndex || sel)
            {
                outSel = lbOutput.SelectedIndex;
                if (lbOutput.SelectedIndex != -1)
                {
                    tbOutputType.Text = iDirs[lbInput.SelectedIndex].GetOutputType(lbOutput.SelectedIndex);
                    bEditOutput.Enabled = true;
                    bRemoveOutput.Enabled = true;
                    bChangeType.Enabled = true;
                }
                else
                {
                    bEditOutput.Enabled = false;
                    bRemoveOutput.Enabled = false;
                    bChangeType.Enabled = false;
                }
                sel = false;
            }
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("If you close this the OCR software will not work.\nAre you sure you want to exit?", "Exit?", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Exclamation, System.Windows.Forms.MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                _close = true;
                Close();
            }
        }

        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            ShowInTaskbar = true;
            SwitchToThisWindow(Handle, true);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, EventArgs e)
        {
            menuItemOpen_Click(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (ReadDir r in iDirs)
            {
                r.Read();
            }
        }

        private void InitializeIDirs()
        {
            XmlDocument xDoc = XMLDoc();
            XmlNodeList inputs = xDoc.GetElementsByTagName("input");
            iDirs = new ReadDir[inputs.Count];
            int count = 0;
            foreach (XmlNode input in inputs)
            {
                iDirs[count] = new ReadDir(input.Attributes.GetNamedItem("dir").Value);
                XmlNodeList outputs = input.ChildNodes;
                foreach (XmlNode output in outputs)
                {
                    iDirs[count].AddOutputDirectory(output.Attributes.GetNamedItem("dir").Value, output.Attributes.GetNamedItem("type").Value, (output.Attributes.GetNamedItem("email").Value == "true"));
                }
                count++;
            }
        }

        public XmlDocument XMLDoc()
        {
            try
            {
                XmlDocument document = new XmlDocument();
                document.Load(_xmlFile);
                return document;
            }
            catch
            {
                if (System.Windows.Forms.MessageBox.Show("Could not find file. Would you like to replace the file?", "Error", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Error, System.Windows.Forms.MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (!File.Exists(_xmlFile))
                    {
                        StreamWriter file = File.CreateText(_xmlFile);
                        file.Write(XML);
                        file.Close();
                    }
                    return XMLDoc();
                }
                return null;
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_close)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
                ShowInTaskbar = false;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 form = new AboutBox1();
            form.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuItemExit_Click(sender, e);
        }

        private void readNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(Read));
            t.Start();
        }
        private void Read()
        {
            timer1_Tick(null, null);
        }

        private void lbInput_DoubleClick(object sender, EventArgs e)
        {
            if (bEditInput.Enabled)
            {
                bEditInput_Click(sender, e);
            }
        }

        private void lbOutput_DoubleClick(object sender, EventArgs e)
        {
            if (bEditOutput.Enabled)
            {
                bEditOutput_Click(sender, e);
            }
        }

        private void tbOutputType_DoubleClick(object sender, EventArgs e)
        {
            if (bChangeType.Enabled)
            {
                bChangeType_Click(sender, e);
            }
        }

        private void lbInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 46)
            {
                if (bRemoveInput.Enabled)
                {
                    bRemoveInput_Click(sender, e);
                }
            }
        }

        private void lbOutput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 46)
            {
                if (bRemoveOutput.Enabled)
                {
                    bRemoveOutput_Click(sender, e);
                }
            }
        }
    }
}

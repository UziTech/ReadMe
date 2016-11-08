using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace ReadMe
{
    public partial class EditDirs : Form
    {
        public string _iDir;
        public string _oDir;
        public string _oType;
        public bool _oEmail;
        private ReadDir[] _iDirs;
        private int _mode = -1;
        public EditDirs(int Mode, ReadDir[] iDirs)
        {
            InitializeComponent();
            _mode = Mode;
            _iDirs = iDirs;
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            switch (_mode)
            {
                case 1:
                    if (tbput.Text != "")
                    {
                        if (Directory.Exists(tbput.Text))
                        {
                            if (InputDirExists(tbput.Text))
                            {
                                MessageBox.Show("Input directory already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                _iDir = tbput.Text;
                                DialogResult = System.Windows.Forms.DialogResult.OK;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Input directory does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Input directory can not be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 2:
                    if (_iDir == tbput.Text)
                    {
                        DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    }
                    else
                    {
                        if (Directory.Exists(tbput.Text))
                        {
                            if (InputDirExists(tbput.Text))
                            {
                                MessageBox.Show("Input directory already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                _iDir = tbput.Text;
                                DialogResult = System.Windows.Forms.DialogResult.OK;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Input directory does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case 3:
                    if (tbput.Text == "")
                    {
                        DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    }
                    else
                    {
                        if (chbEmailAddress.Checked)
                        {
                            if (Regex.IsMatch(tbput.Text, @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))
                            {
                                _oDir = tbput.Text;
                                _oType = cbType.SelectedItem.ToString();
                                _oEmail = chbEmailAddress.Checked;
                                DialogResult = System.Windows.Forms.DialogResult.OK;
                            }
                            else
                            {
                                MessageBox.Show("Email address is not the correct format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            if (Directory.Exists(tbput.Text))
                            {
                                _oDir = tbput.Text;
                                _oType = cbType.SelectedItem.ToString();
                                _oEmail = chbEmailAddress.Checked;
                                DialogResult = System.Windows.Forms.DialogResult.OK;
                            }
                            else
                            {
                                MessageBox.Show("Output directory does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    break;
                case 4:
                    if (_oDir == tbput.Text)
                    {
                        DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    }
                    else
                    {
                        if (chbEmailAddress.Checked)
                        {
                            if (Regex.IsMatch(tbput.Text, @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))
                            {
                                _oDir = tbput.Text;
                                _oEmail = chbEmailAddress.Checked;
                                DialogResult = System.Windows.Forms.DialogResult.OK;
                            }
                            else
                            {
                                MessageBox.Show("Email address is not the correct format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            if (Directory.Exists(tbput.Text))
                            {
                                _oDir = tbput.Text;
                                _oEmail = chbEmailAddress.Checked;
                                DialogResult = System.Windows.Forms.DialogResult.OK;
                            }
                            else
                            {
                                MessageBox.Show("Output directory does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    break;
                case 5:
                    if (_oType == cbType.SelectedItem.ToString())
                    {
                        DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    }
                    else
                    {
                        _oType = cbType.SelectedItem.ToString();
                        DialogResult = System.Windows.Forms.DialogResult.OK;
                    }
                    break;
                default:
                    DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    break;
            }
        }

        private void EditDirs_Load(object sender, EventArgs e)
        {

            switch (_mode)
            {
                case 1:
                    this.Text = "Add Input Directory";
                    lput.Text = "Input Directory";
                    lput.Visible = true;
                    tbput.Visible = true;
                    bBrowse.Visible = true;
                    break;
                case 2:
                    this.Text = "Edit Input Directory";
                    lput.Text = "Input Directory";
                    tbput.Text = _iDir;
                    lput.Visible = true;
                    tbput.Visible = true;
                    bBrowse.Visible = true;
                    break;
                case 3:
                    this.Text = "Add Output Directory";
                    lput.Text = "Output Directory";
                    cbType.SelectedIndex = 0;
                    chbEmailAddress.Visible = true;
                    lput.Visible = true;
                    tbput.Visible = true;
                    bBrowse.Visible = true;
                    lType.Visible = true;
                    cbType.Visible = true;
                    break;
                case 4:
                    this.Text = "Edit Output Directory";
                    lput.Text = "Output Directory";
                    tbput.Text = _oDir;
                    chbEmailAddress.Checked = _oEmail;
                    chbEmailAddress.Visible = true;
                    lput.Visible = true;
                    tbput.Visible = true;
                    bBrowse.Visible = true;
                    break;
                case 5:
                    this.Text = "Change Output Type";
                    cbType.SelectedItem = _oType;
                    lType.Visible = true;
                    cbType.Visible = true;
                    break;
                default:
                    _mode = -1;
                    this.Text = "Error";
                    lError.Visible = true;
                    break;
            }
        }

        private void bBrowse_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(tbput.Text))
            {
                folderBrowserDialog1.SelectedPath = tbput.Text;
            }
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbput.Text = folderBrowserDialog1.SelectedPath;
                chbEmailAddress.Checked = false;
            }
        }

        private bool InputDirExists(string dir)
        {
            foreach (ReadDir r in _iDirs)
            {
                if (r.InputDirectory == dir)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

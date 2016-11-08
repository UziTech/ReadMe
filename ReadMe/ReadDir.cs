using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.IO;
using System.Threading;
using System.Drawing;

namespace ReadMe
{
    public class ReadDir
    {
        private string iDir = "";
        private string[] oDir = new string[0];
        private string[] oType = new string[0];
        private bool[] oEmail = new bool[0];

        public ReadDir()
        {
        }

        public ReadDir(string InputDirectory)
        {
            iDir = InputDirectory;
        }

        public string InputDirectory
        {
            get
            {
                return iDir;
            }
            set
            {
                iDir = value;
            }
        }
        public string[] GetOutputDirectories()
        {
            return oDir;
        }

        public void AddOutputDirectory(string Directory, string Type, bool Email)
        {
            string[] temp = oDir;
            oDir = new string[temp.Length + 1];
            for (int i = 0; i < temp.Length; i++)
            {
                oDir[i] = temp[i];
            }
            oDir[temp.Length] = Directory;

            temp = oType;
            oType = new string[temp.Length + 1];
            for (int i = 0; i < temp.Length; i++)
            {
                oType[i] = temp[i];
            }
            oType[temp.Length] = Type;

            bool[] tempB = oEmail;
            oEmail = new bool[tempB.Length + 1];
            for (int i = 0; i < tempB.Length; i++)
            {
                oEmail[i] = tempB[i];
            }
            oEmail[tempB.Length] = Email;
        }

        public void ChangeOutputDirectory(int OutputDirectoryIndex, string NewOutputDirectory, bool Email)
        {
            oDir[OutputDirectoryIndex] = NewOutputDirectory;
            oEmail[OutputDirectoryIndex] = Email;
        }

        public void RemoveOutputDirectory(int OutputDirectoryIndex)
        {
            string[] temp = oDir;
            string[] temp2 = oType;
            bool[] temp3 = oEmail;
            oDir = new string[temp.Length - 1];
            oType = new string[temp2.Length - 1];
            oEmail = new bool[temp3.Length - 1];
            for (int i = 0; i < oDir.Length; i++)
            {
                if (i < OutputDirectoryIndex)
                {
                    oDir[i] = temp[i];
                    oType[i] = temp2[i];
                    oEmail[i] = temp3[i];
                }
                else
                {
                    oDir[i] = temp[i + 1];
                    oType[i] = temp2[i + 1];
                    oEmail[i] = temp3[i + 1];
                }
            }
        }

        public string GetOutputType(int OutputDirectoryIndex)
        {
            return oType[OutputDirectoryIndex];
        }

        public bool GetIsEmail(int OutputDirectoryIndex)
        {
            return oEmail[OutputDirectoryIndex];
        }

        public void SetIsEmail(int OutputDirectoryIndex, bool Email)
        {
            oEmail[OutputDirectoryIndex] = Email;
        }

        public void ChangeOutputType(int OutputDirectoryIndex, string NewOutputType)
        {
            oType[OutputDirectoryIndex] = NewOutputType;
        }

        public void Read()
        {
            ////do ocr
            foreach (string file in Directory.GetFiles(iDir))
            {
                if (file.EndsWith(".tif", true, null) || file.EndsWith(".tiff", true, null))// || file.EndsWith(".pdf", true, null))
                {
                    string fileName = file.Substring(file.LastIndexOf("\\"));
                    fileName = fileName.Substring(0, fileName.LastIndexOf("."));
                    Bitmap image = new Bitmap(file);
                    tessnet2.Tesseract ocr = new tessnet2.Tesseract();
                    ocr.Init(null, "ENG", false);
                    List<tessnet2.Word> result = ocr.DoOCR(image, Rectangle.Empty);

                    image = ocr.GetThresholdedImage(image, Rectangle.Empty);////
                    fileName += ".bmp";////
                    image.Save(fileName);////

                    for(int i = 0; i < oDir.Length; i++)
                    {
                        if (oType[i] == "PDF")
                        {
                            fileName += ".pdf";
                            ////create pdf
                        }
                        else if (oType[i] == "DOC")
                        {
                            fileName += ".doc";
                            ////create doc
                        }
                        
                        if (oEmail[i])
                        {
                            try
                            {
                                SendMail(Properties.Settings.Default.SMTPServer, Properties.Settings.Default.SMTPPort, Properties.Settings.Default.SSL, Properties.Settings.Default.Username, Properties.Settings.Default.Password, Properties.Settings.Default.FromAddress, Properties.Settings.Default.FromName, Properties.Settings.Default.Subject, Properties.Settings.Default.Message, Properties.Settings.Default.HTML, new string[] { oDir[i] }, new string[] { fileName });
                                File.Delete(fileName);
                            }
                            catch (Exception ex)
                            {
                                System.Windows.Forms.MessageBox.Show(ex.ToString(), "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            File.Move(fileName, oDir[i] + fileName);
                        }
                    }
                }
            }
        }

        public static void SendMail(string SMTPAddress, int SMTPPort, bool SSL, string Username, string Password, string FromAddress, string FromName, string Subject, string Message, bool HTML, string[] ToAddresses, string[] FileNames)
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            string to = "";

            foreach (string s in ToAddresses)
            {
                to += "," + s;
            }
            to = to.Substring(1);

            mail.From = new MailAddress(FromAddress, FromName);
            mail.To.Add(to);
            mail.Subject = Subject;
            mail.Body = Message;
            mail.IsBodyHtml = HTML;

            for (int i = 0; i < FileNames.Length; i++)
            {
                mail.Attachments.Add(new Attachment(FileNames[i]));
            }

            smtp.Host = SMTPAddress;
            smtp.Port = SMTPPort;
            smtp.EnableSsl = SSL;
            smtp.Credentials = new System.Net.NetworkCredential(Username, Password);

            smtp.Send(mail);
        }
    }
}

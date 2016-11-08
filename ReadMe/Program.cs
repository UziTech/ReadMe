using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ReadMe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Main());
            }
            catch (Exception e)
            {
                string msg = "There has been an error:\n\n" + e.Message;
                while (e.InnerException != null)
                {
                    if (e.Message == e.InnerException.Message)
                    {
                        e = e.InnerException;
                    }
                    else
                    {
                        e = e.InnerException;
                        msg += "\n\n" + e.Message;
                    }
                }
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

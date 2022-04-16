using System;
using System.Collections.Generic;
using System.Diagnostics;
//using System.Linq;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abadgaran
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
#if DEBUG
            Application.Run(new frm_login());

#else
             if (Abadgaran.Properties.Settings.Default.first_time == true)
            {
                Application.Run(new Amlakino.frm_register());
            }
            else
            {
                Application.Run(new frm_login());
            }
#endif

            //  Process.Start("font\\IRANSans.ttf");

        }
    }
}

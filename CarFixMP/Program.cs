using CarFix.Interfaces;
using CarFix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarFix.Forms;

namespace CarFixMP
{
    internal static class Program
    {
        static Mutex mutex = new Mutex(true, "CarFix");

        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormLogin());
            }
            else
            {
                MessageBox.Show("The application is already running", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

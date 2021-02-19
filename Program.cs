using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Luthor.lib;
using System.Windows.Forms;

namespace Bayar.exe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Connection.setConnection("localhost", "bayarin", "root", "");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Login());
        }
    }
}

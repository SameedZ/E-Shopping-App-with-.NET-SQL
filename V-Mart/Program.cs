using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V_Mart
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
            // User Flow - Customer/User is complete.
            // User Flow - Admin is complete.
             Application.Run(new SplashScreen());
            Application.Run(new PortalSelection ());
             

        }
    }
}

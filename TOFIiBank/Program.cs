using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOFIiBank
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Banking());
            //Application.Run(new Login());
            /*if(userID != -1)
            {
                Application.Run(new Banking());
            }
           // Application.Run(new MainApp());

            if(userID != -1)
            {
                Tools.deleteSession(userID);
            }*/
        }

        public static int userID = 1;
        public static string userEmail = Tools.getUserEmail(userID);
        public static int requiredWindow = -1;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAA_project_clinic
{
    static class Program
    {
        public static int UserId = 0;
        public static string Name = "";
        public static string Role = "userTable";
        public static string userName="";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]

        
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Splash_Screen ());
        }
    }
}

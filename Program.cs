using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Victoria_Brown_C969_PA.Database;

namespace Victoria_Brown_C969_PA
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

            ConnectToDB.startConnection();
            Application.Run(new login());
            ConnectToDB.closeConnection();
        }
    }
}

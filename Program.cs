using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;

namespace Spottyfy
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
            //Application.Run(new SongView());
            //Login l = new Login();
            //l.StartPosition = FormStartPosition.Manual;
            //l.Location = new System.Drawing.Point(0,0);
            //l.Show();
            Application.Run(new SongView());
        }
    }
}

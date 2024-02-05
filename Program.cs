using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MongoDB.Driver;

namespace Spottyfy
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static MainMenu mainMenuInstance;
        private static DataBaseConnect dbInstance;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainMenuInstance = new MainMenu();
            mainMenuInstance.FormBorderStyle = FormBorderStyle.FixedSingle;
            mainMenuInstance.MaximizeBox = false;
            SetApplicationIcon(ReadFromConfigFile("settings.cfg", "logo"));
            SetApplicationLanguage(ReadFromConfigFile("settings.cfg", "lang"));
            SetApplicationTitle(ReadFromConfigFile("settings.cfg", "title"));
            Application.Run(new Login());
        }
        public static MainMenu GetMainMenuInstance()
        {
            return mainMenuInstance;
        }
        public static void InitializeDB(int type) { 
            dbInstance=new DataBaseConnect(type);
        }
        public static DataBaseConnect GetDBInstance()
        {
            return dbInstance;
        }
        public static string ReadFromConfigFile(string filePath, string key)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split('=');

                        if (parts.Length == 2 && parts[0].Trim() == key)
                        {
                            return parts[1].Trim();
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File not found: {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading from config file: {ex.Message}");
            }

            return null;
        }
        public static XDocument SetApplicationLanguage(string lang)
        {
            string xmlFilePath = lang;

            XDocument doc = XDocument.Load(xmlFilePath);
            return doc;


        }
        public static XDocument GetLangInstance()
        {
            return SetApplicationLanguage(ReadFromConfigFile("settings.cfg", "lang"));
        }
        public static void SetApplicationTitle(string title) {
            mainMenuInstance.Text = title;
        }
        public static void SetApplicationIcon(string path)
        {
            try
            {
                Icon customIcon = new Icon(path);
                if (mainMenuInstance != null)
                {
                    mainMenuInstance.Icon = Icon.ExtractAssociatedIcon(path);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error setting application icon: " + ex.Message);
            }
        }
    }
}

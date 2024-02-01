using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
        private static MainMenu mainMenuInstance;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainMenuInstance = new MainMenu();
            SetApplicationIcon(ReadFromConfigFile("settings.cfg", "logo"));
            SetApplicationTitle(ReadFromConfigFile("settings.cfg", "title"));
            Application.Run(mainMenuInstance);
        }
        public static MainMenu GetMainMenuInstance()
        {
            return mainMenuInstance;
        }
        public static string ReadFromConfigFile(string filePath, string key)
        {
            try
            {
                // Open the file for reading
                using (StreamReader reader = new StreamReader(filePath))
                {
                    // Read the file line by line
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Split each line into key and value
                        string[] parts = line.Split('=');

                        // Check if the key matches the desired key
                        if (parts.Length == 2 && parts[0].Trim() == key)
                        {
                            // Return the corresponding value
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

            // Return null if the key is not found or an error occurs
            return null;
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

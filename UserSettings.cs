﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Spottyfy
{
    public partial class UserSettings : Form
    {
        public string getUsername { get; set; }
        public int getTypeOfConnection { get; set; }
        public string getRank { get; set; }

        private int type;
        private const string ProfilePictureFilePath = "profilePicturePath.txt";
        public UserSettings()
        {   
            InitializeComponent();
            LoadProfilePicture();
            
        }
        public void getTheData()
        {
            label_username.Text = this.getUsername;
            label_rank.Text = this.getRank;
            type = this.getTypeOfConnection;
            
        }

        private void LoadProfilePicture()
        {
            if (File.Exists(ProfilePictureFilePath))
            {
                string imagePath = File.ReadAllText(ProfilePictureFilePath);
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    panel_avatar.BackgroundImage = Image.FromFile(imagePath);
                }
                if (Application.OpenForms["MainMenu"] is MainMenu mainMenuForm)
                {
                    mainMenuForm.SetProfilePicture(imagePath);
                }
            }
        }

        public string user_picture = "";
        private void button_usersett_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    panel_avatar.BackgroundImage = Image.FromFile(imagePath);

                    // Save the chosen path to a file
                    File.WriteAllText(ProfilePictureFilePath, imagePath);
                }
            }
        }

        private void button_changpassword_Click(object sender, EventArgs e)
        {
            if (user_picture.Length > 0)
            {
                panel_avatar.BackgroundImage = Image.FromFile(user_picture);
            }
        }
    }
}

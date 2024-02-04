using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Spottyfy
{
    public partial class UserSettings : Form
    {
        public string getUsername { get; set; }
        public int getTypeOfConnection { get; set; }
        public string getRank { get; set; }
        public List<UserData> users { get; set; }

        private int type;
        private const string ProfilePictureFilePath = "profilePicturePath.txt";
        public UserSettings()
        {
            this.FormBorderStyle= FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            InitializeComponent();
            LoadProfilePicture();

        }
        public void getTheData()
        {
            label_username.Text = this.getUsername;
            label_rank.Text = this.getRank;
            type = this.getTypeOfConnection;
            users = this.users;

            comboBox_users.Items.Clear();
            foreach (UserData item in users)
            {
                if (item.name != this.getUsername) comboBox_users.Items.Add(item.name);
            }

            if (label_rank.Text.Equals("admin", StringComparison.Ordinal))
            {
                flowLayout_admin.Visible = true;
            }
            else
            {
                flowLayout_admin.Visible = false;
            }

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

        private void UserSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoadProfilePicture();
        }

        string setRank;
        private void checkBox_admin_CheckedChanged(object sender, EventArgs e)
        {
            setRank = "admin";
            checkBox_user.Checked = false;
        }

        private void checkBox_user_CheckedChanged(object sender, EventArgs e)
        {
            setRank = "user";
            checkBox_admin.Checked = false;
        }

        private void button_confirmchange_Click(object sender, EventArgs e)
        {

            if (comboBox_users.SelectedIndex > -1)
            {
                if (checkBox_user.Checked == true || checkBox_admin.Checked == true)
                {
                    DataBaseConnect db = new DataBaseConnect(type);
                    var username = db.connection.GetUserData();
                    foreach (var item in username)
                    {
                        if (item.name == comboBox_users.SelectedItem.ToString())
                        {
                            UserData user = new UserData();
                            user.Id = item.Id;
                            user.name = item.name;
                            user.password = item.password;
                            user.money= item.money;
                            user.creationDate = item.creationDate;
                            user.rank = setRank;
                            Console.WriteLine("owowowowd");
                            Console.WriteLine(user.rank.ToString());
                            Console.WriteLine(user.name.ToString());
                            db.connection.UpdateData(user, item.Id);

                            string errorMessage = "User rank has been updated";
                            AlertBox alertBox = new AlertBox();
                            alertBox.UpdateLabelTextAndCenterSUCCES(errorMessage);
                            alertBox.Show();

                            checkBox_admin.Checked = false;
                            checkBox_user.Checked = false;
                            comboBox_users.Text = String.Empty;
                        }
                    }
                }
                else
                {
                    string errorMessage = "Please select the option: admin or user";
                    AlertBox alertBox = new AlertBox();
                    alertBox.UpdateLabelTextAndCenterFAILED(errorMessage);
                    alertBox.Show();
                }
            }
            else
            {
                string errorMessage = "Please select the user to modify";
                AlertBox alertBox = new AlertBox();
                alertBox.UpdateLabelTextAndCenterFAILED(errorMessage);
                alertBox.Show();
            }
        }

        
    }
}

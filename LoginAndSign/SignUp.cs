using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson.Serialization;
using MongoDB.Driver.Search;
using MongoDB.Bson.Serialization.Serializers;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using MongoDB.Bson.Serialization.Attributes;

namespace Spottyfy
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void button_exit_signup_window_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_cancel_signup_window_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login LoginOpen = new Login();
            LoginOpen.ShowDialog();
        }

        int type = 1; //database login
        private void select_mysql_CheckedChanged(object sender, EventArgs e)
        {
            select_mongo.Checked = false;
            type = 2;
        }

        private void select_mongo_CheckedChanged(object sender, EventArgs e)
        {
            select_mysql.Checked = false;
            type = 1;
        }

        private void PerformSignUp()
        {
            DataBaseConnect db = Program.GetDBInstance();
            db.connection.GetUserData();
            var username = db.connection.GetUserData();
            foreach (var item in username) 
            {
                item.ToJson();
                string user = item.name.ToString();
                if (user == input_username_signup_window.Text) //SPRAWDZA CZY NAZWA JEST DOSTEPNA
                {
                    string errorMessage = "This username is already taken, please choose another ";
                    AlertBox alertBox = new AlertBox();
                    alertBox.UpdateLabelTextAndCenterFAILED(errorMessage);
                    alertBox.Show();
                }
                else //JAK WSZYSTKO SIE ZGADZA POBIERA DANE I TWORZY USERA
                {
                    UserData newUser = new UserData();
                    newUser.name = input_username_signup_window.Text;
                    newUser.password = input_password_signup_window.Text;
                    newUser.rank = "user";
                    newUser.creationDate = DateTime.Now;

                    db.connection.AddData(newUser);

                    string errorMessage = "Your account has been created";
                    AlertBox alertBox = new AlertBox();
                    alertBox.UpdateLabelTextAndCenterSUCCES(errorMessage);
                    alertBox.Show();

                }
            }

        }

        public bool PasswordMatch = false;
        private void DoesPasswordMatch()
        {
            if (input_repeatpassword_signup_window.Text != input_password_signup_window.Text)
            {
                label_password_signup_window.ForeColor = Color.Red;
                label_repeatpassword_signup_window.ForeColor = Color.Red;
                panel3.BackColor = Color.Red;
                panel4.BackColor = Color.Red;
                panel5.BackColor = Color.Red;
                panel6.BackColor = Color.Red;

                label_failed_signup_window.Text = "Passwords are not the same";
                label_failed_signup_window.Visible = true;
                PasswordMatch = false;
            }
            else
            {
                label_password_signup_window.ForeColor = ColorTranslator.FromHtml("#D7F75B");
                label_repeatpassword_signup_window.ForeColor = ColorTranslator.FromHtml("#D7F75B");
                panel3.BackColor = ColorTranslator.FromHtml("#D7F75B");
                panel4.BackColor = ColorTranslator.FromHtml("#D7F75B");
                panel5.BackColor = ColorTranslator.FromHtml("#D7F75B");
                panel6.BackColor = ColorTranslator.FromHtml("#D7F75B");

                label_failed_signup_window.Visible = false;
                PasswordMatch = true;
            }
        }

        public bool EverythingFilled = false;
        private void IsEverythingFilled()
        {
            if (input_username_signup_window.Text.Length == 0 || input_password_signup_window.Text.Length == 0 || input_repeatpassword_signup_window.Text.Length == 0)
            {
                label_failed_signup_window.Text = "Please, fill every pool";
                label_failed_signup_window.Visible = true;
                EverythingFilled = false;
            }
            else 
            { 
                label_failed_signup_window.Visible=false;
                EverythingFilled = true;
            }

        }
        private void input_username_signup_window_TextChanged(object sender, EventArgs e)
        {
            DoesPasswordMatch();
            IsEverythingFilled();
        }
        private void input_password_signup_window_TextChanged(object sender, EventArgs e)
        {
            DoesPasswordMatch();
            IsEverythingFilled();
        }
        private void input_repeatpassword_signup_window_TextChanged(object sender, EventArgs e)
        {
            DoesPasswordMatch();
            IsEverythingFilled();
        }
        private void button_signup_login_window_Click(object sender, EventArgs e)
        {
            IsEverythingFilled();
            if (EverythingFilled == true && PasswordMatch==true) { PerformSignUp(); }
            else 
            {
                string errorMessage = "Some data is missing, please fill every pool ";
                AlertBox alertBox = new AlertBox();
                alertBox.UpdateLabelTextAndCenterFAILED(errorMessage);
                alertBox.Show();
            }
            
        }
    }
}

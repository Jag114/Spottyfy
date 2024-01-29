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

        private void PerformLogin()
        {
            DataBaseConnect db = new DataBaseConnect(type);
            db.connection.GetUserData();


        }
    }
}

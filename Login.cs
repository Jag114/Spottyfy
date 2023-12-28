using MongoDB.Driver;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            //test
            int type = 1;
            string dataType = "song";
            DataBaseConnect db = new DataBaseConnect(type);//1-mongo, 2-mysql, 3-postgresql
            db.connection.GetData(dataType);

            DataBaseConnect db2 = new DataBaseConnect(3);
            db2.connection.GetData(dataType);

            
        }

        private void button_loggin_window_Click(object sender, EventArgs e)
        {
            if (input_username_login_window.Text == "PLACEHOLDER_databaseuser" && input_password_login_window.Text == "PLACEHOLDER_databasepassword")
            {
                this.Hide();
            }
            else
            {
                label_failed_login_window.Visible = true;
            }
        }

        private void button_exit_login_window_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_singup_login_window_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp SignUpOpen = new SignUp();
            SignUpOpen.ShowDialog();
        }

        private void button_loggin_window_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}

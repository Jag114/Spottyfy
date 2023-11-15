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

        private void panel_signup_window_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_signup_login_window_Click(object sender, EventArgs e)
        {

        }
    }
}

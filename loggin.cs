﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_window
{
    public partial class loggin : Form
    {
        public loggin()
        {
            InitializeComponent();
        }

        private void button_loggin_window_Click(object sender, EventArgs e)
        {
            if (input_usrname_login_window.Text == "PLACEHOLDER_databaseuser" && input_password_login_window.Text == "PLACEHOLDER_databasepassword")
            {
                this.Hide();
            }
            else
            {
                label_failed_login_screen.Visible = true;
            }
        }

        private void button_exit_login_window_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
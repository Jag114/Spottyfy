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
    public partial class AlertBox : Form
    {
        //Przykladowe wywolanie w innym pliku:
        //string errorMessage = "This is a new error message. ";
        //AlertBox alertBox = new AlertBox();
        //alertBox.UpdateLabelTextAndCenter(errorMessage);
        //alertBox.Show();

        public AlertBox()
        {
            InitializeComponent();
            CenterLabel();
            CenterPanel();
        }

        private void CenterLabel()
        {
            
            int x = (panel_login_window.Width - label_error_message_alertbox.Width) / 2;
            int y = (panel_login_window.Height - label_error_message_alertbox.Height) / 2;

            
            label_error_message_alertbox.Location = new System.Drawing.Point(x, y);
        }

        private void CenterPanel()
        {
            int x = (this.ClientSize.Width - panel_login_window.Width) / 2;
            int y = (this.ClientSize.Height - panel_login_window.Height) / 2;

            panel_login_window.Location = new Point(x, y);
        }

        public void UpdateLabelTextAndCenter(string new_error_message)
        {
            label_error_message_alertbox.Text = new_error_message;
            CenterLabel();
        }
        private void panel_login_window_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_title_alertbox_Click(object sender, EventArgs e)
        {

        }

        private void label_failed_login_window_Click(object sender, EventArgs e)
        {

        }

        private void button_okay_alertbox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

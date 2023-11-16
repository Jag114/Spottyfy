using MongoDB.Bson;
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
    public partial class SongView : Form
    {
        public SongView()
        {
            InitializeComponent();
        }

        private void SongView_Load(object sender, EventArgs e)
        {
            List<Album> albums = Album.getAlbumsMethod();
            Console.WriteLine(string.Join(",",albums));
            albumTitle.Text = albums[0].title;
            albumArtist.Text = albums[0].artist;
            for (int i = 0; i < albums.Count; ++i)
            {
                Button button = new Button();
                button.Width = flowLayoutPanel1.Width;
                button.Height = 100;
                button.ForeColor = Color.White;
                button.BackColor = Color.FromArgb(82,80,80);
                int tag = i;
                button.Tag = tag;
                button.Text = albums[i].title;
                button.Click += (s, ev) => {
                    System.Diagnostics.Debug.WriteLine(tag);
                    albumTitle.Text = albums[tag].title;
                    albumArtist.Text = albums[tag].artist;
                };
                flowLayoutPanel1.Controls.Add(button);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

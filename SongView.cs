using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            DoubleBuffered = true;
        }

        private void SongView_Load(object sender, EventArgs e)
        {
            DataBaseConnect db = Program.GetDBInstance();
            var albums = db.connection.GetAlbumData();
            var songs = db.connection.GetSongDataFromAlbum(albums[0].Id);
            albumTitle.Text = albums[0].name;
            albumArtist.Text = albums[0].author;
            loadSongs(songs);
            for (int i = 0; i < albums.Count; ++i)
            {
                Button button = new Button();
                button.Width = flowLayoutPanel1.Width;
                button.Height = 100;
                button.BackColor = Color.FromArgb(215, 247, 91);
                button.ForeColor = Color.FromArgb(26, 24, 27);
                int tag = i;
                button.Tag = tag;
                button.Text = albums[i].name;
                button.Font = new Font("Microsoft Sans Serif", 18);
                button.Click += (s, ev) => {
                    albumTitle.Text = albums[tag].name;
                    albumArtist.Text = albums[tag].author;
                    songs = db.connection.GetSongDataFromAlbum(albums[tag].Id);
                    loadSongs(songs);
                };
                flowLayoutPanel1.Controls.Add(button);
            }
        }
        private void loadSongs(List<SongData> songs) {
            flowLayoutPanel2.Controls.Clear();
            foreach (SongData song in songs) {
                LinkLabel songLabel = new LinkLabel();
                songLabel.Text = song.name;
                songLabel.ForeColor = Color.FromArgb(215, 247, 91);
                songLabel.LinkColor = Color.FromArgb(215, 247, 91);
                songLabel.LinkClicked += (s, ev) =>
                {
                    SongDetailView sdForm = new SongDetailView(song, albumTitle.Text){ TopLevel = false, TopMost = true };
                    //sdForm.Location = this.Location;
                    //sdForm.StartPosition = FormStartPosition.Manual;
                    sdForm.FormBorderStyle = FormBorderStyle.None;
                    this.Controls.Clear();
                    this.Controls.Add(sdForm);
                    //sdForm.FormClosing += delegate { Application.Exit(); };
                    sdForm.Show();
                    //this.Hide();
                };
                songLabel.Width = flowLayoutPanel2.Width;
                songLabel.Height = 30;
                songLabel.Font= new Font("Microsoft Sans Serif", 16);
                flowLayoutPanel2.Controls.Add(songLabel);
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

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void SongView_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, System.Drawing.ColorTranslator.FromHtml("#1b1918"),
                  System.Drawing.ColorTranslator.FromHtml("#416386"), 180F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
        private void SongView_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Spottyfy
{
    public partial class SongDetailView : Form
    {
        private SongData song;
        private string albumTitle;
        public SongDetailView(SongData songData, string _albumTitle)
        {
            song = songData;
            albumTitle = _albumTitle;
            InitializeComponent();
        }

        private void SongDetailView_Load(object sender, EventArgs e)
        {
            songTitle.Text = song.name;
            songDetails.Text = song.author + " - " + albumTitle;
            songReleaseDate.Text = song.releaseDate.ToString().Substring(0, song.releaseDate.ToString().IndexOf(' '));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void backButton_Click(object sender, EventArgs e)
        {
            SongView Song = new SongView() { TopLevel = false, TopMost = true };
            this.Controls.Clear();
            Song.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(Song);
            Song.Show();
        }
    }
}

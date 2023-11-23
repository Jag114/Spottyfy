using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            /*flowLayoutPanel1.BackColor=Color.LimeGreen; flowLayoutPanel2.BackColor=Color.LimeGreen;
            splitContainer1.BackColor=Color.LimeGreen; splitContainer2.BackColor=Color.LimeGreen;
            this.TransparencyKey=Color.LimeGreen;*/
            List<Album> albums = Album.getAlbumsMethod();
            List<SongData> songs = SongData.getSongsFromAlbum(albums[0].id);
            Console.WriteLine(string.Join(",",albums));
            albumTitle.Text = albums[0].title;
            albumArtist.Text = albums[0].artist;
            loadSongs(songs);
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
                    songs = SongData.getSongsFromAlbum(albums[tag].id);
                    loadSongs(songs);
                };
                flowLayoutPanel1.Controls.Add(button);
            }
        }
        private void loadSongs(List<SongData> songs) {
            foreach (SongData song in songs) { 
                Label songLabel = new Label();
                songLabel.Text = song.name;
                songLabel.ForeColor = Color.White;
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
    }
}

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
    public partial class AddSong : Form
    {
        private List<AlbumData> albumki;
        private string albumId;
        DataBaseConnect db = Program.GetDBInstance();
        public AddSong()
        {
            InitializeComponent();
            label1.Text = Program.GetLangInstance().Descendants("Name").FirstOrDefault()?.Value;
            label2.Text = Program.GetLangInstance().Descendants("Album").FirstOrDefault()?.Value;
            label3.Text = Program.GetLangInstance().Descendants("Author").FirstOrDefault()?.Value;
            label4.Text = Program.GetLangInstance().Descendants("ReleaseDate").FirstOrDefault()?.Value;
            label5.Text = Program.GetLangInstance().Descendants("Price").FirstOrDefault()?.Value;
            addSongBtn.Text = Program.GetLangInstance().Descendants("AddSong").FirstOrDefault()?.Value;
        }

        private void AddSong_Load(object sender, EventArgs e)
        {
            albumki= db.connection.GetAlbumData();
            foreach (AlbumData album in albumki)
            {
                albumList.Items.Add(album.name);
            }
        }
        private void addSongBtn_Click(object sender, EventArgs e) {
            SongData song = new SongData() {
                Id = null,
                name = songName.Text,
                author = songAuthor.Text,
                album = albumId,
                releaseDate = songDate.Value,
                cost = int.Parse(songCost.Text)
            };
            db.connection.AddData(song);
            this.Hide();
        }
        private void albumList_SelectedIndexChanged(object sender, EventArgs e)
        {
            albumId = albumki.Find(album => album.name == albumList.SelectedItem.ToString()).Id;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

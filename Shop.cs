using MySqlX.XDevAPI.Relational;
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
    public partial class Shop : Form
    {
        public int getTypeOfConnection { get; set; }
        int type;
        public Shop()
        {
            InitializeComponent();
            DataBaseConnect db = new DataBaseConnect(type);
            //var albums = db.connection.GetAlbumData();

            for (int i =1; i< table_shop.RowCount; i++) 
            {
                Label label_album = new Label();
                label_album.Text = "album";
                label_album.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Regular);
                table_shop.Controls.Add(label_album, 0, i);

                Label label_author = new Label();
                label_author.Text = "author";
                label_author.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Regular);
                table_shop.Controls.Add(label_author,1,i);

                Label label_song = new Label();
                label_song.Text = "title";
                label_song.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Regular);
                table_shop.Controls.Add(label_song, 2, i);

                Label label_price = new Label();
                label_price.Text = "100";
                label_price.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Regular);
                table_shop.Controls.Add(label_price, 3, i);

                Button button = new Button();
                button.Text = "Buy";
                button.FlatStyle=FlatStyle.Flat;
                button.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Regular);
                button.BackColor = ColorTranslator.FromHtml("#E8F9A3");
                table_shop.Controls.Add(button, 4, i);

            }

        }

        public void getData()
        { 
            type = getTypeOfConnection;
        }


    }
}

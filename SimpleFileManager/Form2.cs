using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFileManager
{
    public partial class Playlist : Form
    {
        
        public Playlist()
        {
            InitializeComponent();
        }

        
        System.Data.SQLite.SQLiteConnection con = new SQLiteConnection(@"datasource = C:\Users\admin\Desktop\Databases\sms.db"); // we are going to connect to this db.

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM PlayLists";
            SQLiteCommand cmd = new SQLiteCommand(query, con); //what query to execute, what connection
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd); //execute this command and give us the data
            adapter.Fill(dt);

            //Loop through the DataTable.

            foreach (DataRow row in dt.Rows)

            {

                //Add Item to ListView.

                ListViewItem item = new ListViewItem(row["Name"].ToString());
                item.Tag = int.Parse(row["Id"].ToString()); //Add Tag, reference to database. 
                //item.SubItems.Add(row["CustomerId"].ToString());
                listView1.Items.Add(item);

            }



            listView1.View = View.List;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnShowMusicFiles_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "SELECT FileName, FilePath, FileType, Comment FROM MediaFiles WHERE FileType LIKE 'MP3'";
            SQLiteCommand cmd = new SQLiteCommand(query, con); //what query to execute, what connection
                                                               // adapter - read data from db
                                                               // datatable - adapter will read data and write into datatable

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd); //execute this command and give us the data
            adapter.Fill(dt);

            //Loop through the DataTable.

            foreach (DataRow row in dt.Rows)
            {
                //Add Item to ListView.

                ListViewItem item = new ListViewItem(row["FileName"].ToString());

                lvMusicFiles.Items.Add(item);
            }
            lvMusicFiles.View = View.List;
        }

        private void lblMusicInPlaylist_Click(object sender, EventArgs e)
        {

        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            var playlistid = e.Item.Tag;
            string query = "SELECT * FROM MediaFiles INNER JOIN Playlists ON MediaFiles.PlaylistId = Playlist.Id";
        }
    }
}

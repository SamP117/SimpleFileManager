using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.Linq;
using System.Data;
using Microsoft.Data.Sqlite;
using System.Data.SQLite;

namespace SimpleFileManager
{
    public partial class Form1 : Form
    {
        private string filePath = "D:/Sam"; //designated file path, can leave as "D:/. Must be / not \

        private bool isFile = false; //need false for navigation
        private string currentlySelectedItemName = "";

        public Form1()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        SQLiteConnection con = new SQLiteConnection(@"datasource = C:\Users\admin\Desktop\Databases\sms.db"); // we are going to connect to this db.


        private void Form1_Load(object sender, EventArgs e)
        {
            filePathTextBox.Text = filePath;
            loadFilesAndDirectories();

            //set version info
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            this.lblVersion.Text = String.Format(this.lblVersion.Text, version.Major, version.Minor, version.Build, version.Revision);
        }
        public void loadFilesAndDirectories()
        {
            DirectoryInfo fileList;
            string tempFilePath = "";
            FileAttributes fileAttr;
            try
            {
                if (isFile) //will be detailing file details as per below
                {
                    tempFilePath = filePath + "/" + currentlySelectedItemName;
                    FileInfo fileDetails = new FileInfo(tempFilePath);
                    lblFileName.Text = fileDetails.Name;
                    lblFiletype.Text = fileDetails.Extension;
                    fileAttr = File.GetAttributes(tempFilePath);
                    Process.Start(tempFilePath);
                }
                else //will be detailing dir details as per below
                {
                    fileAttr = File.GetAttributes(filePath);
                }
                if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    fileList = new DirectoryInfo(filePath);
                    FileInfo[] files = fileList.GetFiles(); //Gets all files
                    DirectoryInfo[] dirs = fileList.GetDirectories(); //Gets all directories
                    string fileExtension = "";
                    listView1.Items.Clear();


                    for (int i = 0; i < files.Length; i++)
                    {
                        fileExtension = files[i].Extension.ToUpper();
                        switch (fileExtension)
                        {
                            case ".MP3":
                            case ".MP2":
                                listView1.Items.Add(files[i].Name, 3);
                                break;
                            case ".EXE":
                            case ".COM":
                                listView1.Items.Add(files[i].Name, 1);
                                break;

                            case ".MP4":
                            case ".AVI":
                            case ".MKV":
                                listView1.Items.Add(files[i].Name, 9);
                                break;
                            case ".PDF":
                                listView1.Items.Add(files[i].Name, 4);
                                break;
                            case ".DOC":
                            case ".DOCX":
                                listView1.Items.Add(files[i].Name, 0);
                                break;

                            case ".PNG":
                            case ".JPG":
                            case ".JPEG":
                                listView1.Items.Add(files[i].Name, 2);
                                break;

                            default:
                                listView1.Items.Add(files[i].Name, 8);
                                break;
                        }

                    }
                    for (int i = 0; i < dirs.Length; i++)
                    {
                        listView1.Items.Add(dirs[i].Name, 7);
                    }
                }
                else
                {
                    lblFileName.Text = this.currentlySelectedItemName;
                }
            }
            catch (Exception e)
            {

            }
        }
        public void loadButtonAction()
        {
            removeBackSlash();
            filePath = filePathTextBox.Text;
            loadFilesAndDirectories();
            isFile = false;
        }

        public void removeBackSlash()
        {
            string path = filePathTextBox.Text;
            if (path.LastIndexOf("/") == path.Length - 1)
            {
                filePathTextBox.Text = path.Substring(0, path.Length - 1);
            }

        }

        public void goBack()
        {
            try
            {
                removeBackSlash();
                string path = filePathTextBox.Text;
                path = path.Substring(0, path.LastIndexOf("/"));
                this.isFile = false;
                filePathTextBox.Text = path;
                removeBackSlash();
            }
            catch (Exception e)
            {

            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            loadButtonAction();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            currentlySelectedItemName = e.Item.Text;

            FileAttributes fileAttr = File.GetAttributes(filePath + "/" + currentlySelectedItemName);
            if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                isFile = false; //because it's directory
                filePathTextBox.Text = filePath + "/" + currentlySelectedItemName;
            }
            else
            {
                isFile = true;
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            loadButtonAction();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            goBack();
            loadButtonAction();
        }

        private void btnSortMusic_Click(object sender, EventArgs e)
        {
            DataTable DT = (DataTable)dataGridView1.DataSource;
            if (DT != null)
                DT.Clear();
            // connection object - connect to db
            //command object - write sql query
            string query = "SELECT FileName, FilePath, FileType, Comment FROM MediaFiles WHERE FileType LIKE 'MP3'";
            SQLiteCommand cmd = new SQLiteCommand(query, con); //what query to execute, what connection
                                                               // adapter - read data from db
                                                               // datatable - adapter will read data and write into datatable
            
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd); //execute this command and give us the data
            adapter.Fill(dt);

            dataGridView1.DataSource = dt; //where will I read data from
        }

        private void btnEditPlaylist_Click(object sender, EventArgs e)
        {
            var m = new Playlist();
            m.Show();

        }
    }
}

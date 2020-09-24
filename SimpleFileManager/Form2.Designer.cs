namespace SimpleFileManager
{
    partial class Playlist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lvMusicFiles = new System.Windows.Forms.ListView();
            this.btnShowMusicFiles = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.lblMusicInPlaylist = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.Location = new System.Drawing.Point(12, 12);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Size = new System.Drawing.Size(75, 23);
            this.btnPlaylist.TabIndex = 0;
            this.btnPlaylist.Text = "Playlist";
            this.btnPlaylist.UseVisualStyleBackColor = true;
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(75, 233);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // lvMusicFiles
            // 
            this.lvMusicFiles.HideSelection = false;
            this.lvMusicFiles.Location = new System.Drawing.Point(115, 41);
            this.lvMusicFiles.Name = "lvMusicFiles";
            this.lvMusicFiles.Size = new System.Drawing.Size(145, 233);
            this.lvMusicFiles.TabIndex = 2;
            this.lvMusicFiles.UseCompatibleStateImageBehavior = false;
            // 
            // btnShowMusicFiles
            // 
            this.btnShowMusicFiles.AutoSize = true;
            this.btnShowMusicFiles.Location = new System.Drawing.Point(139, 12);
            this.btnShowMusicFiles.Name = "btnShowMusicFiles";
            this.btnShowMusicFiles.Size = new System.Drawing.Size(99, 23);
            this.btnShowMusicFiles.TabIndex = 3;
            this.btnShowMusicFiles.Text = "Show Music Files";
            this.btnShowMusicFiles.UseVisualStyleBackColor = true;
            this.btnShowMusicFiles.Click += new System.EventHandler(this.btnShowMusicFiles_Click);
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(285, 41);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(133, 233);
            this.listView2.TabIndex = 4;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // lblMusicInPlaylist
            // 
            this.lblMusicInPlaylist.AutoSize = true;
            this.lblMusicInPlaylist.Location = new System.Drawing.Point(308, 17);
            this.lblMusicInPlaylist.Name = "lblMusicInPlaylist";
            this.lblMusicInPlaylist.Size = new System.Drawing.Size(82, 13);
            this.lblMusicInPlaylist.TabIndex = 5;
            this.lblMusicInPlaylist.Text = "Music In Playlist";
            this.lblMusicInPlaylist.Click += new System.EventHandler(this.lblMusicInPlaylist_Click);
            // 
            // Playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMusicInPlaylist);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.btnShowMusicFiles);
            this.Controls.Add(this.lvMusicFiles);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnPlaylist);
            this.Name = "Playlist";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView lvMusicFiles;
        private System.Windows.Forms.Button btnShowMusicFiles;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label lblMusicInPlaylist;
    }
}
namespace SimpleFileManager
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFiletype = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(713, 12);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.iconList;
            this.listView1.Location = new System.Drawing.Point(12, 50);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 361);
            this.listView1.SmallImageList = this.iconList;
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "doc.png");
            this.iconList.Images.SetKeyName(1, "exe.png");
            this.iconList.Images.SetKeyName(2, "jpg.png");
            this.iconList.Images.SetKeyName(3, "mp3.png");
            this.iconList.Images.SetKeyName(4, "pdf.png");
            this.iconList.Images.SetKeyName(5, "png.png");
            this.iconList.Images.SetKeyName(6, "xls.png");
            this.iconList.Images.SetKeyName(7, "FolderIcon.png");
            this.iconList.Images.SetKeyName(8, "Unknown.png");
            this.iconList.Images.SetKeyName(9, "MP4.png");
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(109, 12);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(580, 20);
            this.filePathTextBox.TabIndex = 3;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(36, 414);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(51, 13);
            this.lblFileName.TabIndex = 4;
            this.lblFileName.Text = "FileName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(658, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "File Type";
            // 
            // lblFiletype
            // 
            this.lblFiletype.AutoSize = true;
            this.lblFiletype.Location = new System.Drawing.Point(737, 414);
            this.lblFiletype.Name = "lblFiletype";
            this.lblFiletype.Size = new System.Drawing.Size(13, 13);
            this.lblFiletype.TabIndex = 7;
            this.lblFiletype.Text = "--";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFiletype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnBack);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFiletype;
    }
}


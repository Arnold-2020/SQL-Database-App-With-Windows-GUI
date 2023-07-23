namespace SQLDatabaseMusicApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLoadAlbums = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.txtbox_AlbumDescription = new System.Windows.Forms.TextBox();
            this.txtbox_ImageURL = new System.Windows.Forms.TextBox();
            this.txtbox_AlbumYear = new System.Windows.Forms.TextBox();
            this.txtbox_ArtistName = new System.Windows.Forms.TextBox();
            this.txtbox_AlbumName = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.lableImageURL = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoadAlbums
            // 
            this.buttonLoadAlbums.Location = new System.Drawing.Point(227, 24);
            this.buttonLoadAlbums.Name = "buttonLoadAlbums";
            this.buttonLoadAlbums.Size = new System.Drawing.Size(108, 23);
            this.buttonLoadAlbums.TabIndex = 0;
            this.buttonLoadAlbums.Text = "Load Albums";
            this.buttonLoadAlbums.UseVisualStyleBackColor = true;
            this.buttonLoadAlbums.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(236, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(583, 254);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(579, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(360, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 23);
            this.textBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 278);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.txtbox_AlbumDescription);
            this.groupBox1.Controls.Add(this.txtbox_ImageURL);
            this.groupBox1.Controls.Add(this.txtbox_AlbumYear);
            this.groupBox1.Controls.Add(this.txtbox_ArtistName);
            this.groupBox1.Controls.Add(this.txtbox_AlbumName);
            this.groupBox1.Controls.Add(this.labelDescription);
            this.groupBox1.Controls.Add(this.lableImageURL);
            this.groupBox1.Controls.Add(this.labelYear);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 244);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Album";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(9, 187);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // txtbox_AlbumDescription
            // 
            this.txtbox_AlbumDescription.Location = new System.Drawing.Point(90, 149);
            this.txtbox_AlbumDescription.Name = "txtbox_AlbumDescription";
            this.txtbox_AlbumDescription.Size = new System.Drawing.Size(100, 23);
            this.txtbox_AlbumDescription.TabIndex = 10;
            // 
            // txtbox_ImageURL
            // 
            this.txtbox_ImageURL.Location = new System.Drawing.Point(90, 118);
            this.txtbox_ImageURL.Name = "txtbox_ImageURL";
            this.txtbox_ImageURL.Size = new System.Drawing.Size(100, 23);
            this.txtbox_ImageURL.TabIndex = 9;
            // 
            // txtbox_AlbumYear
            // 
            this.txtbox_AlbumYear.Location = new System.Drawing.Point(90, 87);
            this.txtbox_AlbumYear.Name = "txtbox_AlbumYear";
            this.txtbox_AlbumYear.Size = new System.Drawing.Size(100, 23);
            this.txtbox_AlbumYear.TabIndex = 8;
            // 
            // txtbox_ArtistName
            // 
            this.txtbox_ArtistName.Location = new System.Drawing.Point(90, 56);
            this.txtbox_ArtistName.Name = "txtbox_ArtistName";
            this.txtbox_ArtistName.Size = new System.Drawing.Size(100, 23);
            this.txtbox_ArtistName.TabIndex = 7;
            // 
            // txtbox_AlbumName
            // 
            this.txtbox_AlbumName.Location = new System.Drawing.Point(90, 25);
            this.txtbox_AlbumName.Name = "txtbox_AlbumName";
            this.txtbox_AlbumName.Size = new System.Drawing.Size(100, 23);
            this.txtbox_AlbumName.TabIndex = 6;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(6, 152);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(67, 15);
            this.labelDescription.TabIndex = 4;
            this.labelDescription.Text = "Description";
            this.labelDescription.Click += new System.EventHandler(this.labelDescription_Click);
            // 
            // lableImageURL
            // 
            this.lableImageURL.AutoSize = true;
            this.lableImageURL.Location = new System.Drawing.Point(6, 121);
            this.lableImageURL.Name = "lableImageURL";
            this.lableImageURL.Size = new System.Drawing.Size(61, 15);
            this.lableImageURL.TabIndex = 3;
            this.lableImageURL.Text = "ImageURL";
            this.lableImageURL.Click += new System.EventHandler(this.lableImageURL_Click);
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(6, 90);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(29, 15);
            this.labelYear.TabIndex = 2;
            this.labelYear.Text = "Year";
            this.labelYear.Click += new System.EventHandler(this.labelYear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Artist";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Album Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 528);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonLoadAlbums);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonLoadAlbums;
        private DataGridView dataGridView1;
        private Button button2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label lableImageURL;
        private Label labelYear;
        private Label label2;
        private Label label1;
        private Label labelDescription;
        private TextBox txtbox_ArtistName;
        private TextBox txtbox_AlbumName;
        private TextBox txtbox_AlbumYear;
        private TextBox txtbox_ImageURL;
        private TextBox txtbox_AlbumDescription;
        private Button buttonAdd;
    }
}
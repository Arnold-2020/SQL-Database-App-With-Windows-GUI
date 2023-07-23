namespace SQLDatabaseMusicApp
{
    public partial class Form1 : Form
    {

        BindingSource albumBindingSource = new BindingSource();


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            //AlbumsDAO albumsDAO = new AlbumsDAO();
            //Album a1 = new Album()
            //{
            //    ID = 1,
            //    AlbumName = "MY First album",
            //    ArtistName = " Bob Smith",
            //    Year = 2023,
            //    ImageURL = "Nothing Special Yet",
            //    Description = "Nothing Yet"
            //};
            //Album a2 = new Album()
            //{
            //    ID = 1,
            //    AlbumName = "MY Second album",
            //    ArtistName = " Bob Smith",
            //    Year = 2023,
            //    ImageURL = "Nothing Special Yet",
            //    Description = "Nothing Yet"
            //};

            // albumsDAO.albums.Add(a1);
            // albumsDAO.albums.Add(a2);

            // Connect the list to the grid view control.
            albumBindingSource.DataSource = albumsDAO.getAllAlbums();

            dataGridView1.DataSource = albumBindingSource;

            //pictureBox1.Load("https://upload.wikimedia.org/wikipedia/en/f/fb/Calvin_Harris_-_Motion.png");

            pictureBox1.Load("https://upload.wikimedia.org/wikipedia/en/1/16/Queen_The_Game.png");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            // Connect the list to the grid view control.
            albumBindingSource.DataSource = albumsDAO.searchTitles(textBox1.Text);

            dataGridView1.DataSource = albumBindingSource;


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            // Get the Row Number Clicked

            int rowClicked = dataGridView.CurrentRow.Index;
            MessageBox.Show("You Cllicked row " + rowClicked);

            String imageURL = dataGridView.Rows[rowClicked].Cells
                [4].Value.ToString();

            //MessageBox.Show("URL=" + imageURL);

            pictureBox1.Load(imageURL);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lableImageURL_Click(object sender, EventArgs e)
        {

        }

        private void labelYear_Click(object sender, EventArgs e)
        {

        }

        private void labelDescription_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Add a new Item to the given Database
            Album album = new Album
            {
                AlbumName = txtbox_AlbumName.Text,
                ArtistName = txtbox_ArtistName.Text,
                Year = Int32.Parse(txtbox_AlbumYear.Text),
                ImageURL = txtbox_ImageURL.Text,
                Description = txtbox_AlbumDescription.Text 
            };

            AlbumsDAO albumsDAO = new AlbumsDAO();
            int result = albumsDAO.addOneAlbum(album);
            MessageBox.Show(result + " new row(s) inserted ");



        }
    }
}
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDatabaseMusicApp
{
    // DAO Data Access Object 
    internal class AlbumsDAO
    {
        // v1 that will help create fake data
         public List<Album> albums = new List<Album>();

        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=music;";
        
        public List<Album> getAllAlbums()
        {
            // Start with an empty list. 
            List<Album> returnthese = new List<Album>();


            // Connect to the MYSQL server

            MySqlConnection connection = new MySqlConnection
                (connectionString);
            connection.Open();

            // Will define the sql statement to fetch all albums 
            //MySqlCommand command = new MySqlCommand("SELECT * FROM ALBUMS",
            //    connection);

            // Or the next best way can be like this: 

            MySqlCommand command = new MySqlCommand("SELECT ID, ALBUM_TITLE, ARTIST, YEAR, IMAGE_NAME," +
                "DESCRIPTION FROM ALBUMS",
               connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while(reader.Read())
                {
                    Album a = new Album
                    {
                        ID = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        ArtistName = reader.GetString(2),
                        Year = reader.GetInt32(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5),

                    };
                    returnthese.Add(a);
                }
            }
            connection.Close();



            return returnthese;
        }

        public List<Album> searchTitles(String searchTerm)
        {
            // Start with an empty list. 
            List<Album> returnthese = new List<Album>();


            // Connect to the MYSQL server

            MySqlConnection connection = new MySqlConnection
                (connectionString);
            connection.Open();

            // Will define the sql statement to fetch all albums 
            //MySqlCommand command = new MySqlCommand("SELECT * FROM ALBUMS",
            //    connection);

            // Or the next best way can be like this: 


            String searchWildPhrase = "%" + searchTerm + "%";
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT ID, ALBUM_TITLE, ARTIST, YEAR, IMAGE_NAME," +
                "DESCRIPTION FROM ALBUMS WHERE ALBUM_TITLE LIKE @search";
            command.Parameters.AddWithValue("@search", searchWildPhrase);
            command.Connection = connection;


            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album a = new Album
                    {
                        ID = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        ArtistName = reader.GetString(2),
                        Year = reader.GetInt32(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5),

                    };
                    returnthese.Add(a);
                }
            }
            connection.Close();



            return returnthese;
        }

        internal int addOneAlbum(Album album)
        {
            // Connect to the MYSQL server
            MySqlConnection connection = new MySqlConnection
                (connectionString);
            connection.Open();

            

            // Or the next best way can be like this: 

            MySqlCommand command = new MySqlCommand("INSERT INTO `albums`( `ALBUM_TITLE`, `ARTIST`, `YEAR`, `IMAGE_NAME`, " +
                "`DESCRIPTION`) VALUES (@albumtitle, @artist, @year, @imageURL, @description)",
               connection);

            command.Parameters.AddWithValue("@albumtitle", album.AlbumName);

            command.Parameters.AddWithValue("@artist", album.ArtistName);

            command.Parameters.AddWithValue("@year", album.Year);

            command.Parameters.AddWithValue("@imageURL", album.ImageURL);
           
            command.Parameters.AddWithValue("@description", album.Description);

            int newRows = command.ExecuteNonQuery();
            
            connection.Close();

            return newRows;
        }
    }
    }


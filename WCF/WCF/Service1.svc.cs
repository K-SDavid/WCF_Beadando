using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private string connectionString = "Server=localhost;Port=3306;Database=szop_beadando;Uid=root;Pwd=;";
        static Dictionary<string, string> logged = new Dictionary<string, string>();

        private void CheckLogin(string guid)
        {
            try
            {
                if (guid == null || guid == "")
                    throw new Exception("Először jelentkezzen be!");

                lock (logged)
                {
                    if (!logged.ContainsKey(guid))
                        throw new Exception("Először jelentkezzen be!");
                }
            }
            catch (Exception ex)
            {
                ServiceData insert = new ServiceData();
                insert.Result = false;
                insert.ErrorMessage = ex.Message;
                insert.ErrorDetails = "Jelentkezzen be!";
                throw new FaultException<ServiceData>(insert, ex.ToString());
            }
        }

        public string AddMusic(string name, string artist, string album, Genres genre, int likes, int dislikes, string uid)
        {
            try
            {
                CheckLogin(uid);

                Music temp = new Music(name, artist, album, genre, likes, dislikes);

                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = connectionString;
                connection.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO music(Name, Artist, Album, Genre, Likes, Dislikes) " +
                    "VALUES (@name, @artist, @album, @genre, @likes, @dislikes)";
                command.Parameters.AddWithValue("@name", temp.Name);
                command.Parameters.AddWithValue("@artist", temp.Artist);
                command.Parameters.AddWithValue("@album", temp.Album);
                command.Parameters.AddWithValue("@genre", temp.Genre.ToString());
                command.Parameters.AddWithValue("@likes", temp.Likes);
                command.Parameters.AddWithValue("@dislikes", temp.Dislikes);
                command.ExecuteNonQuery();
                connection.Close();
                return "OK";
            }
            catch (Exception ex)
            {
                ServiceData insert = new ServiceData();
                insert.Result = false;
                insert.ErrorMessage = ex.Message;
                insert.ErrorDetails = "Nem megfelelő bemeneti adatok!";
                throw new FaultException<ServiceData>(insert, ex.ToString());
            }
        }

        public string UpdateMusic(int id, string name, string artist, string album, Genres genre, int likes, int dislikes, string uid)
        {
            try
            {
                CheckLogin(uid);

                if(id.ToString() == "")
                {
                    throw new Exception("Kérem adjon meg egy id-t!");
                }

                Music temp = new Music(name, artist, album, genre, likes, dislikes);

                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = connectionString;
                connection.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE music SET Name = @name, Artist = @artist, Album = @album," +
                    "Genre = @genre, Likes = @likes, Dislikes = @dislikes WHERE Id = @id";
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@name", temp.Name);
                command.Parameters.AddWithValue("@artist", temp.Artist);
                command.Parameters.AddWithValue("@album", temp.Album);
                command.Parameters.AddWithValue("@genre", temp.Genre.ToString());
                command.Parameters.AddWithValue("@likes", temp.Likes);
                command.Parameters.AddWithValue("@dislikes", temp.Dislikes);

                MySqlCommand command2 = new MySqlCommand();
                command2.Connection = connection;
                command2.CommandType = CommandType.Text;
                command2.CommandText = "SELECT Name FROM music WHERE Id = @id";
                command2.Parameters.AddWithValue("@id", id);

                MySqlDataReader reader = command2.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    command.ExecuteNonQuery();
                }
                else
                {
                    reader.Close();
                    throw new Exception("Nincs ilyen id-vel rendelkező elem az adatbázisban!");
                }
                connection.Close();

                return "OK";
            }
            catch (Exception ex)
            {
                ServiceData updateisavailable = new ServiceData();
                updateisavailable.Result = false;
                updateisavailable.ErrorMessage = ex.Message;
                updateisavailable.ErrorDetails = "ERROR";
                throw new FaultException<ServiceData>(updateisavailable, ex.ToString());
            }
        }

        public string DeleteMusic(int id, string uid)
        {
            try
            {
                CheckLogin(uid);

                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = connectionString;
                connection.Open();

                MySqlCommand command2 = new MySqlCommand();
                command2.Connection = connection;
                command2.CommandType = CommandType.Text;
                command2.CommandText = "SELECT Name FROM music WHERE Id = @id";
                command2.Parameters.AddWithValue("@id", id);

                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM music WHERE Id = @id";
                command.Parameters.AddWithValue("@id", id);

                MySqlDataReader reader = command2.ExecuteReader();
                if(reader.HasRows)
                {
                    reader.Close();
                    command.ExecuteNonQuery();
                }
                else
                {
                    reader.Close();
                    throw new Exception("Nincs ilyen id-vel rendelkező elem az adatbázisban!");
                }

                connection.Close();

                return "OK";
            }
            catch (Exception ex)
            {
                ServiceData delete = new ServiceData();
                delete.Result = false;
                delete.ErrorMessage = ex.Message;
                delete.ErrorDetails = "ERROR";
                throw new FaultException<ServiceData>(delete, ex.ToString());
            }
        }

        public string DeleteAllMusic(string uid)
        {
            try
            {
                CheckLogin(uid);

                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = connectionString;
                connection.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "TRUNCATE TABLE music";
                command.ExecuteNonQuery();
                connection.Close();

                return "OK";
            }
            catch (Exception ex)
            {
                ServiceData deleteall = new ServiceData();
                deleteall.Result = false;
                deleteall.ErrorMessage = ex.Message;
                deleteall.ErrorDetails = "ERROR";
                throw new FaultException<ServiceData>(deleteall, ex.ToString());
            }
        }

        public List<Music> ListMusic()
        {
            List<Music> musics = new List<Music>();

            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = connectionString;
                connection.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM music";

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Music m = new Music();
                    m.Id = int.Parse(reader["Id"].ToString());
                    m.Name = reader["Name"].ToString();
                    m.Artist = reader["Artist"].ToString();
                    m.Album = reader["Album"].ToString();
                    m.Genre = (Genres)Enum.Parse(typeof(Genres), reader["Genre"].ToString());
                    m.Likes = int.Parse(reader["Likes"].ToString());
                    m.Dislikes = int.Parse(reader["Dislikes"].ToString());
                    musics.Add(m);
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                ServiceData list = new ServiceData();
                list.Result = false;
                list.ErrorMessage = ex.Message;
                list.ErrorDetails = "Az adatbázis üres.";

                throw new FaultException<ServiceData>(list, ex.ToString());
            }
            return musics;
        }

        public string Login(string username, string password)
        {
            ServiceData myServiceData = new ServiceData();
            try
            {
                User temp = new User(username, password);
                
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = connectionString;
                connection.Open();

                MySqlCommand command = connection.CreateCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT Username FROM users WHERE Username = @username AND Password = @password";
                command.Parameters.AddWithValue("@username", temp.Username);
                command.Parameters.AddWithValue("@password", temp.Password);

                MySqlCommand command2 = connection.CreateCommand();
                command2.Connection = connection;
                command2.CommandType = CommandType.Text;
                command2.CommandText = "INSERT INTO users(Username, Password) VALUES (@username, @password)";
                command2.Parameters.AddWithValue("@username", temp.Username);
                command2.Parameters.AddWithValue("@password", temp.Password);

                MySqlDataReader reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    reader.Close();
                    reader = command2.ExecuteReader();
                }
                reader.Close();
                connection.Close();

                string id = Guid.NewGuid().ToString();
                lock (logged)
                {
                    logged.Add(id, username);
                }
                return id;
            }
            catch (Exception ex)
            {
                myServiceData.Result = false;
                myServiceData.ErrorMessage = ex.Message;
                myServiceData.ErrorDetails = ex.ToString();
                throw new FaultException<ServiceData>(myServiceData, ex.ToString());
            }
        }

        public void Logout(string uid)
        {
            if (uid != null && uid != "")
                lock (logged)
                {
                    if (logged.ContainsKey(uid))
                        logged.Remove(uid);
                }
            else
                throw new Exception("Ön nincs bejelentkezve!");

        }
    }
}

using Microsoft.Data.SqlClient;
using System.Data;

namespace AuthorApplication2.Models
{


        public class MovieRepository
        {
            public static List<Movie> GetMovies()
            {
                List<Movie> movies = new List<Movie>();
                using (SqlConnection connect = SqlHelper.CreateConnection())
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }


                    SqlCommand cmd = connect.CreateCommand();
                    string commend = @"SELECT * FROM movie";
                    cmd.CommandText = commend;
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Movie movie = new Movie();
                        movie.Id = reader.GetInt32(0);
                        movie.Title = reader.GetString(1);
                        movie.Language = reader.GetString(2);
                        movie.Hero = reader.GetString(3);
                        movie.Director = reader.GetString(4);
                        movie.MusicDiretor = reader.GetString(5);
                        movie.ReleaseDate = reader.GetDateTime(6);
                        movie.Cost = reader.GetDecimal(7);
                        movie.Collection = reader.GetDecimal(8);
                        movie.Review = reader.GetString(9);
                        movies.Add(movie);
                    }
                }
                return movies;
            }

            public static int AddMovie(Movie movie)
            {

                int query = 0;
                using (SqlConnection connect = SqlHelper.CreateConnection())
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }
                    SqlCommand command = connect.CreateCommand();
                    String str = @"INSERT INTO movie  Values(@id,@title,@Language,@Hero,@Director,@MusicDirector,@ReleaseDate,@Cost,@Collection,@Review);";
                    command.Parameters.Add("@id", SqlDbType.Int).Value = movie.Id;
                    command.Parameters.Add("@title", SqlDbType.NVarChar).Value = movie.Title;
                    command.Parameters.Add("@Language", SqlDbType.NVarChar).Value = movie.Language;
                    command.Parameters.Add("@Hero", SqlDbType.NVarChar).Value = movie.Hero;
                    command.Parameters.Add("@Director", SqlDbType.NVarChar).Value = movie.Director;
                    command.Parameters.Add("@MusicDirector", SqlDbType.NVarChar).Value = movie.MusicDiretor;
                    command.Parameters.Add("@ReleaseDate", SqlDbType.DateTime).Value = movie.ReleaseDate;
                    command.Parameters.Add("@Cost", SqlDbType.Decimal).Value = movie.Cost;
                    command.Parameters.Add("@Collection", SqlDbType.Decimal).Value = movie.Collection;
                    command.Parameters.Add("@Review", SqlDbType.NVarChar).Value = movie.Review;
                    command.CommandText = str;
                    query = command.ExecuteNonQuery();


                }
                return query;
            }

            public static Movie GetMovie(int id)
            {
                Movie movie = new Movie();
                using (SqlConnection connect = SqlHelper.CreateConnection())
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }


                    SqlCommand cmd = connect.CreateCommand();
                    string commend = @"SELECT * FROM movie where ID =@id";
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cmd.CommandText = commend;
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        movie.Id = reader.GetInt32(0);
                        movie.Title = reader.GetString(1);
                        movie.Language = reader.GetString(2);
                        movie.Hero = reader.GetString(3);
                        movie.Director = reader.GetString(4);
                        movie.MusicDiretor = reader.GetString(5);
                        movie.ReleaseDate = reader.GetDateTime(6);
                        movie.Cost = reader.GetDecimal(7);
                        movie.Collection = reader.GetDecimal(8);
                        movie.Review = reader.GetString(9);
                    }
                }
                return movie;
            }

            public static int UpdateMovie(int id, Movie movie)
            {
                int query = 0;
                using (SqlConnection connect = SqlHelper.CreateConnection())
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }


                    SqlCommand command = connect.CreateCommand();
                    string commend = @"Update movie set ID=@id,Title=@title,Language=@Language,Hero =@Hero,Director=@Director,MusicDirector=@MusicDirector,ReleaseDate=@ReleaseDate,Cost=@Cost,Collection=@Collection,Review=@Review  Where ID=@id ;";
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    command.Parameters.Add("@title", SqlDbType.NVarChar).Value = movie.Title;
                    command.Parameters.Add("@Language", SqlDbType.NVarChar).Value = movie.Language;
                    command.Parameters.Add("@Hero", SqlDbType.NVarChar).Value = movie.Hero;
                    command.Parameters.Add("@Director", SqlDbType.NVarChar).Value = movie.Director;
                    command.Parameters.Add("@MusicDirector", SqlDbType.NVarChar).Value = movie.MusicDiretor;
                    command.Parameters.Add("@ReleaseDate", SqlDbType.DateTime).Value = movie.ReleaseDate;
                    command.Parameters.Add("@Cost", SqlDbType.Decimal).Value = movie.Cost;
                    command.Parameters.Add("@Collection", SqlDbType.Decimal).Value = movie.Collection;
                    command.Parameters.Add("@Review", SqlDbType.NVarChar).Value = movie.Review;
                    command.CommandText = commend;
                    query = command.ExecuteNonQuery();
                }
                return query;
            }

            public static int Delete(int id)
            {
                int query = 0;
                using (SqlConnection connect = SqlHelper.CreateConnection())
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }


                    SqlCommand command = connect.CreateCommand();
                    string str = @"Delete from movie where ID =@id;";
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    command.CommandText = str;
                    query = command.ExecuteNonQuery();
                }
                return query;
            }



        }
 }

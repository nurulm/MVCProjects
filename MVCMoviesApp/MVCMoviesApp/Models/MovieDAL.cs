using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace MVCMoviesApp.Models
{
    public class MovieDAL
    {
        SqlConnection cn = new SqlConnection("user id=sa; password=sa; database=MVC; data source=NURUL-PC\\SQLEXPRESS");

        SqlCommand cmd = new SqlCommand();

        public void AddMovie(MovieModel m)
        {
            cmd.CommandText = "INSERT INTO MOVIES VALUES(@MID, @MNAME, @MFILE)";
            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@MID", m.MovieID);
            cmd.Parameters.AddWithValue("@MNAME", m.MovieName);
            cmd.Parameters.AddWithValue("@MFILE", m.MovieFile);

            cn.Open();

            cmd.ExecuteNonQuery();

            cn.Close();
        }

        public List<MovieModel> GetMovies()
        {
            List<MovieModel> objList = new List<MovieModel>();

            cmd.CommandText = "SELECT * FROM MOVIES";

            cmd.Connection = cn;
            cn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                MovieModel mm = new MovieModel();

                mm.MovieID = dr["MovieID"].ToString();
                mm.MovieName = dr["MovieName"].ToString();
                mm.MovieFile = dr["MovieFile"].ToString();

                objList.Add(mm);
            }

            dr.Close();
            cn.Close();

            return objList;
            
        }

        public void DeleteMovie(string movieid)
        {
            cmd.CommandText = "DELETE FROM MOVIES WHERE MOVIEID=@ID";

            cmd.Connection = cn;

            cmd.Parameters.AddWithValue("@ID", movieid);

            cn.Open();

            cmd.ExecuteNonQuery();

            cn.Close();
        }

        public MovieModel GetMovie(string movieid)
        {
            MovieModel m = new MovieModel();

            cmd.CommandText = "SELECT * FROM MOVIES WHERE MOVIEID=@MVID";

            cmd.Connection = cn;
            cmd.Parameters.AddWithValue("@MVID", movieid);

            cn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                m.MovieID = dr["MovieID"].ToString();
                m.MovieName = dr["MovieName"].ToString();
                m.MovieFile = dr["MovieFile"].ToString();
            }
            dr.Close();
            cn.Close();

            return m;
        }

        public void UpdateMovie(MovieModel m)
        {

            //Old Record Deleted
            this.AddMovie(m); //insert fresh row
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMoviesApp.Models;

namespace MVCMoviesApp.Controllers
{
    public class MoviesController : Controller
    {
        MovieDAL MDal = new MovieDAL();
        
        // GET: Movies
        public ActionResult Index()
        {
            TempData["Action"] = "Add";
            return View();
        }

        public ActionResult AddMovie()
        {
            ViewBag.MovieID = "";
            ViewBag.MovieName = "";

            ViewBag.Movies = MDal.GetMovies();

            //Get the Movies List
            List<MovieModel> m = MDal.GetMovies();

            TempData["Action"] = "Add";

            return View(m);
        }


        public ActionResult Add(MovieModel m)
        {
            if (TempData["Action"].ToString() == "Add")
            {
                HttpPostedFileBase hp = Request.Files["fu1"];

                m.MovieFile = m.MovieID + ".mp4";

                string Path = Server.MapPath("/Movies/") + m.MovieID + ".mp4";

                hp.SaveAs(Path); //Saves the file in the server folder

                MDal.AddMovie(m);
                
            }
            else if (TempData["Action"].ToString() == "Update")
            {
              
                    System.IO.File.Delete(Server.MapPath("/Movies/" + Session["MovieID"].ToString() + ".mp4")); //Delete the old file

                    HttpPostedFileBase hp = Request.Files["fu1"];

                    m.MovieFile = m.MovieID + ".mp4";

                    string Path = Server.MapPath("/Movies/") + m.MovieID + ".mp4";

                    hp.SaveAs(Path); //Saves the file in the server folder

                    MDal.DeleteMovie(Session["MovieID"].ToString());
                    MDal.UpdateMovie(m);
            }

            ViewBag.MovieID = "";
            ViewBag.MovieName = "";
            //ViewBag.Movies  = MDal.GetMovies();
            TempData["Action"] = "Add";
            //ViewBag.SubmitAction = "Add";
            return View("AddMovie", MDal.GetMovies());
        }

        public ActionResult Display()
        {
            List<MovieModel> mm = MDal.GetMovies();

            return View(mm);
        }

        public ActionResult Edit(string id)
        {
            MovieModel m = MDal.GetMovie(id);

            ViewBag.MovieID = m.MovieID;
            ViewBag.MovieName = m.MovieName;
          //  ViewBag.Movies = MDal.GetMovies();

            Session["MovieID"] = id;

            TempData["Action"] = "Update";

            //ViewBag.SubmitAction = "Update";

            return View("AddMovie", MDal.GetMovies());
        }
        public ActionResult Delete(string id)
        {
            MDal.DeleteMovie(id);

            System.IO.File.Delete(Server.MapPath("/Movies/" + id + ".mp4"));

            //ViewBag.Movies = MDal.GetMovies();

            TempData["Action"] = "Add";
            //ViewBag.SubmitAction = "Add";

            return View("AddMovie", MDal.GetMovies());

            //return View("Display", MDal.GetMovies());
        }

    }
}
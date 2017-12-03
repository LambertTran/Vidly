using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public ApplicationDbContext _context;


        public ActionResult Index()
        {
            var movie = new Movie()
            {
                Name = "Shrek!"
            };          

            return View(movie);
        }
        
        
    }
}
﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            Models.Movie movie = new Models.Movie();
            movie.Title = "The Godfather";
            movie.ReleaseDate = new DateTime(1972, 3, 24);
            return View(movie);
        }

    }
}

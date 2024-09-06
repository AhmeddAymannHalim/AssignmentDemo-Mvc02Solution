using System;
using AssignmentDemo_Mvc02.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AssignmentDemo_Mvc02.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IConfiguration _configuration;

        public MoviesController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        ///[ActionName("Index")] //BaseUrl/Movies/GetMovie/id?name=" " 
        ///public string GetAllMovies()
        ///{
        ///    return $"All Movies";
        ///}
        //BaseUrl/Movies/GetMovie/{id} => Segment
        //BaseUrl/Movies/GetMovie/?id = 10 => QueryParam
        [HttpGet]//Verb Get
        public /*string*/ IActionResult GetMovie(int id/*,string name*/)
        {
            //    Name {name}
            //return $"Movie with  and Id {id}";

            if (id == 0)
                return new BadRequestResult();

            if (id == 100)
                return new NotFoundResult();

            // ContentResult result = new ContentResult();
            // result.Content = $"<h1>Movie with Id {id}</h1>";
            // result.ContentType = "text/html";
            // //result.StatusCode = 404;
            return Content($"<h1>Movie with Id :{id} </h1>", "text/html"); 

        }

        public IActionResult CreateMovie()
        {
            return View();
        }
        // public IActionResult Hamada()
        // {
        //     //RedirectResult result = new RedirectResult("https://wuzzuf.net/jobs/egypt");
        //     //RedirectResult result = new RedirectResult(_configuration["WuzzufUrl"]!);
        //     //RedirectResult result = new RedirectResult($"{_configuration["BaseUrl"]}/Movies/GetMovie/10");
        // 
        //     //RedirectToActionResult result = new RedirectToActionResult(nameof(GetMovie), "Movies", new {id=10});
        // 
        //     //RedirectToRouteResult result = new RedirectToRouteResult("default",)
        // 
        // 
        // 
        //     return View();
        // }
        /// [HttpGet]
        /// public ViewResult CreateMovie()
        /// {
        ///     var View = new ViewResult();
        ///     return View;
        /// }
        /// [HttpPost]
        /// public OkResult CreateMovie(Movie model)
        /// {
        ///     return new OkResult();
        /// }
    }
}

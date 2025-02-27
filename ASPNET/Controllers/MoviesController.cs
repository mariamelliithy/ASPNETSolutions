using Microsoft.AspNetCore.Mvc;

namespace ASPNET.Controllers
{
    public class MoviesController : Controller
    {
        //public void GetMovie(int id)
        //{

        //}
        //public string Index() 
        //{
        //    return "Hello from index";
        //}
        //https://localhost:44352/Movies/Index
        public IActionResult Index()
        {
            //ContentResult result = new ContentResult();
            //result.Content = "Hello from index";
            //result.ContentType = "text/html";
            ////result.ContentType = "object/pdf";
            //return result;
            return Content("Hello from index", "text/html");
        }

        public IActionResult Test() 
        {
            //RedirectResult result = new RedirectResult("https://localhost:44352/Movies/Index");
            //return result;
            return RedirectToAction("Index");
            //return RedirectToRoute(new {Controller = "Movies", Action= "Index" });
        }
        //Action parameters binding
        //1]Form
        //2]Segment /10
        //3]Query string ?id=10
        //4]File
        public IActionResult GetMovie(int id, string name, Movie movie) 
        {
            return Content($"Movie with id : {id}, name : {name}");
        }
    }
}

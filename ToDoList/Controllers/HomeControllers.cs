using Microsoft.AspNetCore.Mvc;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
      [Route("/favorite_photos")]
      public ActionResult FavoritePhotos()
      {
        return View();
      }

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }



    }
}

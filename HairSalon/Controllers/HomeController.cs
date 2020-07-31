using Microsoft.AspNetCore.Mvc;

namespace FavoriteClient.Controllers
{
  public class HomeController : Controller
  {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
  } 
}


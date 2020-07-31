using Microsoft.AspNetCore.Mvc;

using FavoriteClient.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;


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


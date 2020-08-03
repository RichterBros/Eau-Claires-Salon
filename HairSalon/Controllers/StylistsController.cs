using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FavoriteClient.Models;
using System.Collections.Generic;
using System.Linq;



namespace FavoriteClient.Controllers
{
  public class StylistsController : Controller
  {
    private readonly FavoriteClientContext _db; 

    public StylistsController(FavoriteClientContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Stylist> model = _db.Stylists.OrderBy(stylist => stylist.Type).ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Stylist stylist)
    {
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
   
{
Stylist thisStylist = _db.Stylists.Include(stylist => stylist.Clients).FirstOrDefault(stylist =>stylist.StylistId == id); // passes list of restaurants associated with that cuisine ID. Saves result of search of cuisine ID to thisCuisine, returns thisCuisine in View.

      return View(thisStylist);
}





      // {
      // List<Stylist> model = _db.Stylists.Include(stylists => stylists.Clients).ToList();
      // // List<Client> model = _db.Clients.Include(clients => clients.Stylist).ToList();
        
    
      // return View(model);
    
      // }
  // {
  //  Stylist thisStylist = _db.Stylists.FirstOrDefault(stylists => stylists.StylistId == id);
     
    
     
  //     return View(thisStylist);
  //   }
    

  }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FavoriteClient.Models;
using System.Collections.Generic;
using System.Linq;

namespace FavoriteClient.Controllers
{
  public class ClientsController : Controller
  {
    private readonly FavoriteClientContext _db;

    public ClientsController(FavoriteClientContext db)
    {
      _db = db;
    }

    public ActionResult Create()
    {
      ViewBag.Hello = "Hello world!"; // Client Create.cshtml line 8
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Type");
     
     
   
     
     
      //ViewBag.PassedHealthInspection = new SelectList(_db.Restaurants, "PassedHealthInspection", "Passed Health Inspection");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Client client)
    {
      _db.Clients.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Index()
    {
      List<Client> model = _db.Clients.Include(clients => clients.Stylist).ToList();
      
        
    
      return View(model);
    }
  
    public ActionResult Details(int id)
    {
      
      Client thisClient = _db.Clients.FirstOrDefault(clients => clients.ClientId == id);
     
    
     
      return View(thisClient);
    }

// public ActionResult Details()
//     {
      
//       return View();
//     }

// public ActionResult Details()
// {

// return View();
  
//   }
  
  
  }
}
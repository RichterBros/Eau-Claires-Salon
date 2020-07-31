using Microsoft.AspNetCore.Mvc;
using FavoriteClient.Models;
using Microsoft.EntityFrameworkCore;
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
      Stylist thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      return View (thisStylist);
    }

  }
}
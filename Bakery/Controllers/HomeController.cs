using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Controllers
{
  public class HomeController : Controller
  {

    private readonly BakeryContext _db;

    public HomeController(BakeryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      ViewBag.Flavor = new List<Flavor>( _db.Flavors);
      ViewBag.Treat = new List<Treat>( _db.Treats);
      return View( _db.Flavors.ToList());
    }
  }
}
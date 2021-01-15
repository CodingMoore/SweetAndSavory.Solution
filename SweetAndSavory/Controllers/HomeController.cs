using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SweetAndSavory.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SweetAndSavory.Controllers
{
  public class HomeController : Controller
  {
    private readonly SweetAndSavoryContext _db;
    public HomeController(SweetAndSavoryContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Flavor> flavorList = _db.Flavors.ToList();
      List<Treat> treatList = _db.Treats.ToList();
      ViewBag.FlavorList = flavorList;
      ViewBag.TreatList = treatList;
      ViewBag.Flavors = _db.Flavors;
      ViewBag.Treats = _db.Treats;
      return View();
    }

  }
}
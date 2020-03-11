using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;
using System.Collections.Generic;

namespace PackerTracker.Controllers
{
  public class ThingsToBringController : Controller
  {

    // Displays list of all things
    [HttpGet("/thingstobring")]
    public ActionResult Index()
    {
      List<ThingsToBring> allThings = ThingsToBring.GetAll();
      return View(allThings);
    }

    // Displays form to create a new thing
    [HttpGet("/thingstobring/new")]
    public ActionResult New()
    {
      return View();
    }

    // Creates a new thing
    [HttpPost("/thingstobring")]
    public ActionResult Create(string name, int price, bool isPurchased, int weight, string manufacturer, bool isPacked)
    {
      ThingsToBring newthing = new ThingsToBring(name, price, isPurchased, weight, manufacturer, isPacked);
      return RedirectToAction("Index");
    }

    // Clears all things
    [HttpPost("/thingstobring/deleteall")]
    public ActionResult DestroyAll()
    {
      ThingsToBring.ClearAll();
      return View();
    }
  }
}
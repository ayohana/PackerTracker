using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;
using System.Collections.Generic;

namespace PackerTracker.Controllers
{
  public class ThingsToBringController : Controller
  {

    public List<ThingsToBring> allThings = ThingsToBring.GetAll();

    // Displays list of all things
    [HttpGet("/thingstobring")]
    public ActionResult Index()
    {
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
    public ActionResult Create(string name, int price, string isPurchased, int weight, string manufacturer, string isPacked)
    {
      ThingsToBring newThing = new ThingsToBring(name, price, isPurchased, weight, manufacturer, isPacked);
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
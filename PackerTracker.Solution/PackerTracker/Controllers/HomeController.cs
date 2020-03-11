using Microsoft.AspNetCore.Mvc;

namespace PackerTracker.Controllers
{
  public class HomeController : Controller
  {

    // Displays Homepage
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}
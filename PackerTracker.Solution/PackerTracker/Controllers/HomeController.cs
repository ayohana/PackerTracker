using Microsoft.AspNetCore.Mvc;

namespace PackerTracker.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/thingstobring")]
    public ActionResult Index()
    {
      return View();
    }

  }
}
using Microsoft.AspNetCore.Mvc;
using TravelApiMVC.Models;

namespace TravelApiMVC.Controllers
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
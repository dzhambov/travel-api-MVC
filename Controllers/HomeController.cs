using Microsoft.AspNetCore.Mvc;
using TravelApiMVC.Models;

namespace TravelApiMVC.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      var allDestinations = Destination.GetDestinations();
      return View(allDestinations);
    }
  }
}
using Microsoft.AspNetCore.Mvc;
using TravelApiMVC.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace TravelApiMVC.Controllers
{
  public class DestinationController : Controller
  {
    public IActionResult Index()
    {
    var allDestinations = Destination.GetDestinations();
    return View(allDestinations);
    }
  }
}

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

    [HttpPost]
    public IActionResult Index(Destination destination)
    {
      Destination.Post(destination);
      return RedirectToAction("Index");
    }

    public IActionResult Details(int id)
    {
      var destination = Destination.GetDetails(id);
      return View(destination);
    }

    public IActionResult Edit(int id)
    {
      var destination = Destination.GetDetails(id);
      return View(destination);
    }

    [HttpPost]
    public IActionResult Details(int id, Destination destination)
    {
      destination.DestinationId = id;
      Destination.Put(destination);
      return RedirectToAction("Details", id);
    }

    public IActionResult Delete(int id)
    {
      Destination.Delete(id);
      return RedirectToAction("Index");
    }
  }
}


using Microsoft.AspNetCore.Mvc;
using CafeVendors.Models;

namespace CafeVendors.Controllers
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
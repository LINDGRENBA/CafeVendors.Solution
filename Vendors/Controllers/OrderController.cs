using Microsoft.AspNetCore.Mvc;
using CafeVendors.Models;
using System.Collections.Generic;
using System;


namespace CafeVendors.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("vendors/{vendorId}/orders/new")]
    public ActionResult New()
    {
      return View();
    }
  }
}
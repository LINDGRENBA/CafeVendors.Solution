using Microsoft.AspNetCore.Mvc;
using CafeVendors.Models;
using System.Collections.Generic;
using System;


namespace CafeVendors.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }
  }
  
}
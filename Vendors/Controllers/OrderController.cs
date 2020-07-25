using Microsoft.AspNetCore.Mvc;
using CafeVendors.Models;
using System.Collections.Generic;
using System;


namespace CafeVendors.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.FindVendor(vendorId);
      return View();
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.FindOrder(orderId);
      Vendor vendor = Vendor.FindVendor(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }
  }
}
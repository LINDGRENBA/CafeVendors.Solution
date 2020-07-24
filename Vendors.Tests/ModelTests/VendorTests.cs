using Microsoft.VisualStudio.TestTools.UnitTesting;
using CafeVendors.Models;
using System.Collections.Generic;
using System;

namespace CafeVendors.Tests
{
  [TestClass]
  public class VendorTests //VendorTest ?
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor firstVendor = new Vendor("name", "description");
      Assert.AreEqual(typeof(Vendor), firstVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Rita's Flower Shop";
      string description = "A flower shop that sells pastries.";
      Vendor firstVendor = new Vendor(name, description);
      string result = firstVendor.Name;
      Assert.AreEqual(name, result);
    }
  }
}
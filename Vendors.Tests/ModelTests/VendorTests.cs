using Microsoft.VisualStudio.TestTools.UnitTesting;
using CafeVendors.Models;
using System.Collections.Generic;
using System;

namespace CafeVendors.Tests
{
  [TestClass]
  public class VendorTests : IDisposable 
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

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

        [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string name = "Rita's Flower Shop";
      string description = "A flower shop that sells pastries.";
      Vendor firstVendor = new Vendor(name, description);
      string result = firstVendor.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetVendor_GetListOfVendors_VendorList()
    {
      string name = "Rita's Flower Shop";
      string description = "A flower shop that sells pastries.";
      Vendor firstVendor = new Vendor(name, description);
      List<Vendor> newList = new List<Vendor> {firstVendor};
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void FindVendor_ReturnsVendorByIdSearch_Vendor()
    {
      string name01 = "Rita's";
      string description01 = "Flower shop and cafe.";
      Vendor firstVendor = new Vendor(name01, description01);
      string name02 = "Kate's";
      string description02 = "Sandwich shop";
      Vendor secondVendor = new Vendor(name02, description02);
      Vendor result = Vendor.FindVendor(1);
      Assert.AreEqual(firstVendor, result);
    }
  }
}
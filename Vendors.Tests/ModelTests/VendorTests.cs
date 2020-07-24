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
      Vendor firstVendor = new Vendor();
      Assert.AreEqual(typeof(Vendor), firstVendor.GetType());
    }
  }
}
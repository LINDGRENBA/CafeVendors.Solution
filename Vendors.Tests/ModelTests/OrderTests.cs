using Microsoft.VisualStudio.TestTools.UnitTesting;
using CafeVendors.Models;
using System.Collections.Generic;
using System;

namespace CafeVendors.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("title", "description", 20, "date");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void OrderConstructor_CreatesOrderInstanceWithFields_String()
    {
      string title = "Rita's weekly croissant order";
      string description = "Details about Rita's weekly croissant order.";
      int price = 20;
      string date = "Every Monday.";
      Order ritasOrder = new Order(title, description, price, date);
      string titleResult = ritasOrder.Title;
      string descriptionResult = ritasOrder.Description;
      string dateResult = ritasOrder.Date;
      Assert.AreEqual(title, titleResult);
      Assert.AreEqual(description, descriptionResult);
      Assert.AreEqual(date, dateResult);
    }
  }
}
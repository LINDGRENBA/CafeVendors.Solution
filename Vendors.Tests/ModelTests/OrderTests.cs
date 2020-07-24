using Microsoft.VisualStudio.TestTools.UnitTesting;
using CafeVendors.Models;
using System.Collections.Generic;
using System;

namespace CafeVendors.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
        public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("title", "description", 20, "date");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void OrderConstructor_CreatesOrderInstanceWithTitleDescriptionAndDate_String()
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

    [TestMethod]
    public void OrderConstructor_CreatesOrderInstanceWithPrice_Int()
    {
      string title = "Rita's weekly croissant order";
      string description = "Details about Rita's weekly croissant order.";
      int price = 20;
      string date = "Every Monday.";
      Order ritasOrder = new Order(title, description, price, date);
      int result = ritasOrder.Price;
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void GetList_GetsListOfOrders_OrderList()
    {
      string title = "Rita's weekly croissant order";
      string description = "Details about Rita's weekly croissant order.";
      int price = 20;
      string date = "Every Monday.";
      Order anotherOrder = new Order(title, description, price, date);
      List<Order> anotherList = new List<Order> {anotherOrder};
      List<Order> result = Order.GetAll();
      Assert.AreEqual(anotherList, result);
    }

    [TestMethod]
    public void FindOrder_ReturnsOrderByIdSearch_Vendor()
    {
      Order firstOrder = new Order("Rita's Order", "Details of Rita's weekly order", 20, "Every Monday");
      Order secondOrder = new Order("Kate's order", "Details of Kate's order.", 15, "1st of the month");
      Order result = Order.FindOrder(1);
      Assert.AreEqual(firstOrder, result);
    }
  }
}
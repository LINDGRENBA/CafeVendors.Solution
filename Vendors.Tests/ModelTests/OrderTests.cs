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
      Order.ClearAll();
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
      string title02 = "order title";
      string details02 = "order details";
      int price02 = 5;
      string date02 = "order date";
      Order secondOrder = new Order(title02, details02, price02, date02);
      List<Order> anotherList = new List<Order> {anotherOrder, secondOrder};
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(anotherList, result);
    }

    [TestMethod]
    public void FindOrder_ReturnsOrderByIdSearch_Order()
    {
      string title01 = "order title";
      string details01 = "order details";
      int price01 = 5;
      string date01 = "order date";
      Order firstOrder = new Order(title01, details01, price01, date01);
      string title02 = "order title";
      string details02 = "order details";
      int price02 = 5;
      string date02 = "order date";
      Order secondOrder = new Order(title02, details02, price02, date02);
      Order result = Order.FindOrder(1);
      Assert.AreEqual(firstOrder, result);
    }
  }
}
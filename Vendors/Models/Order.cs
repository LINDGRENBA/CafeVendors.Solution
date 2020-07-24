using System.Collections.Generic;

namespace CafeVendors.Models
{
  public class Order
  {
    public string Title { get; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    public int Id { get; }
    private static List<Order> _ordersList = new List<Order> {};

    public Order(string title, string description, int price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      _ordersList.Add(this);
      Id = _ordersList.Count;
    }

    public static void ClearAll()
    {
      _ordersList.Clear();
    }

    public static List<Order> GetAll()
    {
      List<Order> newOrderList = new List<Order> {};
      return newOrderList;
    }
  }
}


    // Create an Order class. This class should include properties for the title, the description, the price, the date, and any other properties you would like to include.
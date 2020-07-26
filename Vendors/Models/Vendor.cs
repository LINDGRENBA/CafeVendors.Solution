using System.Collections.Generic;

namespace CafeVendors.Models
{
  public class Vendor
  {
    public string Name { get; }
    public string Description { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }
    private static List<Vendor> _vendorList = new List<Vendor> {};

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      _vendorList.Add(this);
      Id = _vendorList.Count;
      Orders = new List<Order> {};
    }

    public static void ClearAll()
    {
      _vendorList.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _vendorList;
    }

    public static Vendor FindVendor(int searchId)
    {
      return _vendorList[searchId - 1];
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}


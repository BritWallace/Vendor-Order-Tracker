using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Order
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    public static List<Order> _instances = new List<Order>{ };
    public int Id { get;}
    public Order (string name, string description, int price, string date)
    {
      Name = name;
      Description = description;
      Price = price;
      Date = date;
      _instances.Add(this);
      Id = _instances.Count;
    }
  
    public static List<Order> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
      public static Order Find(int num)
    {
      return _instances[num -1];
    }
  }
}



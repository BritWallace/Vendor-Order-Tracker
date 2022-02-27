
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrder.Models;

namespace VendorOrder.Tests
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
      Order newOrder = new Order("NameVender", "tests description", 100, "tests date");

      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetALl_ReturnsEmptyList_OrderList()
    {
    List<Order> newOrder = new List<Order> { };
    List<Order>result = Order.GetAll();
    CollectionAssert.AreEqual(newOrder, result);
    }
    [TestMethod]
    public void GetALL_ReturnsVendorOrder_OrderList()
    {
      string name1 = "Olive's";
      string description1 = "Bread";
      int price1 = 100;
      string date1 = "2022 February 22";
      
      string name2 = "Joe's";
      string description2 = "Pastries";
      int price2 = 50;
      string date2 = "2022 February 23";

      Order newOrder1 = new Order(name1, description1, price1, date1);
      Order newOrder2 = new Order(name2, description2, price2, date2);
      List<Order> newOrder = new List<Order> {newOrder1, newOrder2};

      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newOrder, result);
    }
    
  }
}

  // [TestMethod]
  
  // {public void OrderConstructor_CreatesInstanceOfOrder_Order()
  //   Order newOrder = new Order();
  // }
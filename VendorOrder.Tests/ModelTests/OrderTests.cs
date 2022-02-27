
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
    
  }
}

  // [TestMethod]
  
  // {public void OrderConstructor_CreatesInstanceOfOrder_Order()
  //   Order newOrder = new Order();
  // }
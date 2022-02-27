using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorOrder.Models;
namespace VendorOrder.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("NameVendor", "tests description", 100, "tests date");

      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetALl_ReturnsEmptyList_VendorList()
    {
    List<Vendor> newList = new List<Vendor> { };
    List<Vendor>result = Vendor.GetAll();
    CollectionAssert.AreEqual(newList, result);
    }
  }
}
  //   public class VendorTests
  //   {
  //   public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
  //   {
  //     Vendor newVendor = new Vendor("Yo");
  //     Assert.AreEqual(typeof(Vendor), newVendor.GetType());
  //   }
    





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
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("NameVendor", "tests description");

      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetALl_ReturnsEmptyList_VendorList()
    {
    List<Vendor> newList = new List<Vendor> { };
    List<Vendor>result = Vendor.GetAll();
    CollectionAssert.AreEqual(newList, result);
    }
    
    [TestMethod]
    public void GetALL_ReturnsVendorList_VendorList()
    {
      //Arrange
      string description01 = "Bread";
      string description02 = "Pastries";
      string name01 = "Joe's";
      string name02 = "Olive's";
      Vendor newVendor1 = new Vendor(name01, description01);
      Vendor newVendor2 = new Vendor(name02, description02);
      List<Vendor> newVendorList = new List<Vendor> { newVendor1, newVendor2 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newVendorList, result);
    }
    [TestMethod]
    public void  GetId_VendorReturnsWithId_Int()
    {
      string name = "Joe's";
      string description = "Bread";
      Vendor newVendor = new Vendor(name, description);

      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
    

  }
}




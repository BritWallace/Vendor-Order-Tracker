using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorOrder.Models;
using System;

namespace VendorOrder.Controllers
{
  public class OrderController : Controller 
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor newVendor = Vendor.Find(vendorId);
      return View(newVendor);
    }
    [HttpPost("/order/delete")]
    public ActionResult DeleteAll()
    {
      Order.ClearAll();
      return View();
    }
    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }
  
  }
}




// [HttpGet("/vendor/{Id}/orders/new")]
//     public ActionResult New(int vendorId);
//     {
//       Vendor newVendor =Vendor.Find(vendorId);
//       return View(vendor);
//     }
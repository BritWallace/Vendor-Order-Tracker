using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorOrder.Models;
using System;

namespace VendorOrder.Controllers
{
  public class VendorOrderController : Controller 
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor newVendor = Vendor.Find(vendorId);
      return View(newVendor);
    }
    
  }
}




// [HttpGet("/vendor/{Id}/orders/new")]
//     public ActionResult New(int vendorId);
//     {
//       Vendor newVendor =Vendor.Find(vendorId);
//       return View(vendor);
//     }
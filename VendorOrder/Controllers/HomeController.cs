using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;
using System.Collections.Generic;


namespace VendorOrder.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Vendor> allItems = Vendor.GetAll();
      return View(allItems);
    }
  }
}

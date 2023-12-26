using System.Diagnostics;
using Catalog;
using Microsoft.AspNetCore.Mvc;
using mvcApp.Models;

namespace mvcApp.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public ProductController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

      //Action Methods
    public IActionResult Index()
    {
        Product p1 = new Product();
        p1.Title="Jasmine";
        p1.Description="Smelling Flower";
        p1.UnitPrice=56;
        p1.Quantity=7999;
        p1.Imageurl="/images/jasmine.jpg";
  
        ViewData["flower"] = p1;
        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }
      public IActionResult Contactus()
    {
        return View();
    }


}

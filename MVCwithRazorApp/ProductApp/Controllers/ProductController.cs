using System.Diagnostics;
using BLL;
using BOL;
using Microsoft.AspNetCore.Mvc;


namespace productApp.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public ProductController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
    
        ProductManager pm = new ProductManager();
        List<Product> allproducts = pm.getAllProducts();
        this.ViewData["products"] = allproducts;
        return View();
    }

   
}
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using productApp.Models;

using BOL;

using BLL;



namespace productApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ProductManager pm = new ProductManager();
        List<Product> allproducts = pm.getAllProducts();
        this.ViewData["products"] = allproducts;
        System.Diagnostics.Debug.WriteLine("This will be displayed in output window");
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

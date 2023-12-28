using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using productApp.Models;

using BOL;

using BLL;
using MimeKit;
using MailKit.Net.Smtp;



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

     [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(int id,string name,string email,string username,string password)
    {
         Console.WriteLine("inside controller");
        Console.WriteLine(id+" "+name+" "+" "+email+" "+username+" "+password);
        EmployeeManager empManager = new EmployeeManager();
        empManager.RegisterEmployee(id,name,email,username,password);
        return View();
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(string username,string password)
    {
        
        EmployeeManager empManager = new EmployeeManager();
        string  name = empManager.LoginEmployee(username,password);
        this.ViewData["name"]=name;
           Console.WriteLine("inside controller"+name);
        return View();

    }


    public IActionResult Welcome()
    {
        return View();
    }




















    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

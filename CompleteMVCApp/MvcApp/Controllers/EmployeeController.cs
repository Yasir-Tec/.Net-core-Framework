using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using productApp.Models;

using BOL;

using BLL;



namespace productApp.Controllers;

public class EmployeeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public EmployeeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult EmployeeList()
    {

        EmployeeManager empManager = new EmployeeManager();
        List<Employee> emplist = empManager.getAllEmployee();
        ViewData["employees"]=emplist;
         return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using productApp.Models;

using BOL;

using BLL;
using Microsoft.AspNetCore.Mvc.TagHelpers;




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

    public IActionResult Details(int id)
    {
        Console.WriteLine("hii id"+id);
        return View();
    }

    public IActionResult Delete(int id)
    {
        Console.WriteLine("hii delete"+id);
        EmployeeManager empManager = new EmployeeManager();
        empManager.DeleteEmployee(id);
        return View();
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        EmployeeManager empManager = new EmployeeManager();
        List<Employee> emplist = empManager.getEmployeeById(id);
        ViewData["employees"]=emplist;
        return View();
    }
    

    [HttpPost]
    public IActionResult Edit(int id,string name,string email,string username,string password)
    {

        EmployeeManager empManager = new EmployeeManager();
        empManager.EditEmployee(id,name,email,username,password);
        Console.WriteLine(id+" "+name+" "+" "+email+" "+username+" "+password);
        return View();
    }
  


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

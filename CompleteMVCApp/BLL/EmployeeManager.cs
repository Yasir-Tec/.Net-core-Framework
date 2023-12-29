

using BOL;
using DAL.Connected;

public class EmployeeManager{

    public List<Employee> getAllEmployee()
    {
        List<Employee> elist = new List<Employee>();
        elist = EmpManager.getAllEmployee();
        return elist;
    }

    public void RegisterEmployee(int id,string name,string email,string username,string password)
    {
        Console.WriteLine("inside BLL");
        Console.WriteLine(id+" "+name+" "+" "+email+" "+username+" "+password);
        EmpManager.RegisterEmployee(id,name,email,username,password);
    }

    public string LoginEmployee(string username,string password)
    {
        string name = EmpManager.LoginEmployee(username,password);
           Console.WriteLine("inside BLL"+name);
        return name;
    }

    public void DeleteEmployee(int id)
    {
        EmpManager.DeleteEmployee(id);
    }

    public List<Employee> getEmployeeById(int id)
    {
        List<Employee> elist = new List<Employee>();
        elist = EmpManager.getEmployeeById(id);
        return elist;
    }

    public void EditEmployee(int id,string name,string email,string username,string password)
    {
        EmpManager.EditEmployee(id,name,email,username,password);
    }




}
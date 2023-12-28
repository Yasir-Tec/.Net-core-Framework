

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

}
using HR;


Console.WriteLine("Hello, World!");
Employee e=new Employee();
//Console.WriteLine(e);
Employee e1=new Employee(2,"yasir");
//onsole.WriteLine(e1);

int myid = e1.Id;
string myname = e1.Fullname;
//Console.WriteLine(myid);
Console.WriteLine("fullname is :"+myname);

WageEmployee wg1 = new WageEmployee();
//Console.WriteLine(wg1);

SalesEmployee se1 = new SalesEmployee();
//Console.WriteLine(se1);

List<Employee> lst = new List<Employee>();
lst.Add(e);
lst.Add(e1);
lst.Add(wg1);
lst.Add(se1);

foreach(Employee emp in lst)
{
    Console.WriteLine(emp);
    Console.WriteLine(emp.computePay());
}



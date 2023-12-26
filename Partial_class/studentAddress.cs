

namespace abc;
public partial class student
{
    public int pin{set;get;}
    public string city{set;get;}

    public student()
    {
        id=5;
        name="yasir";
        pin=123;
        city="pune";

    }
    public partial void Display(int a)
    {
        Console.WriteLine("Name = "+name);
        Console.WriteLine("Id = "+id);
        Console.WriteLine("Pin ="+pin);
        Console.WriteLine("City ="+city );
    }

}
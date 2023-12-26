namespace HR;

public class Employee
{
    private int id;
    private string fullname;

    public Employee():this(1,"aa"){}

    public Employee(int id,string fullname)
    {
        this.id = id;
        this.fullname = fullname;
    }

    public int Id{
    
        get{ return this.id; }
        set{ this.id=value; }
    }

    public string Fullname{
        get{ return this.fullname; }
        set{ this.fullname=value; }
    }


    public virtual float computePay()
    {
        return 20000;
    }


    public override string ToString()
    {
        return id+"  "+fullname;
    }
}

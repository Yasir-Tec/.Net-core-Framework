
namespace HR;
public class SalesEmployee:WageEmployee
{
    public float incentive{get;set;}
    public float target{get;set;}

    public static int count=0;

    public SalesEmployee():this(499,"Manisha Nene",70,7000,1000000){}

    public SalesEmployee(int id,string fullname,int whrs,float inct,float target):base(id,fullname,whrs)
    {
        this.incentive=inct;
        this.target=target;
    }

    public override float computePay()
    {
        float totalsalary;
        if(target>500000)
        {
            totalsalary = base.computePay()+incentive;
        }
        else
        {
            totalsalary = base.computePay();
        }
        return totalsalary*1000;
    }

    public override string ToString()
    {
        return base.ToString()+" Target : "+this.target+" Incentive : "+this.incentive;
    }

}
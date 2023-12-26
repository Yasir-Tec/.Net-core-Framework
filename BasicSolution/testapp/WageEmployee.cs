namespace HR;

public class WageEmployee:Employee
{
    private int workinghrs;


    public WageEmployee():this(3,"atharva",80){}

    public WageEmployee(int id,string fullname,int whrs):base(id,fullname)
    {
        this.workinghrs=whrs;
    }

    public override float computePay()
    {
        return base.computePay()+ workinghrs*100;
    }

    
    public int Workinghrs{
        get{ return this.workinghrs; }
        set{ this.workinghrs=value; }
    }

    public override string ToString()
    {
        return base.ToString()+" working hours : "+workinghrs;
    }

}
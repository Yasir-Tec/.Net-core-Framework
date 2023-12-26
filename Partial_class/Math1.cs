
namespace abcd;


public static class Maths1
{
    public static int N1{set;get;}
    public static int N2{set;get;}

     public static void SwapByValue(int a,int b)
     {
        int temp=a;
        a=b;
        b=temp;
     }

    public static void SwapByReference(ref int p,ref int q)
    {
         int temp=p;
        p=q;
        q=temp;
    }

    public static void Area(int radius,out double area,out double circumference)
    {
        circumference=2*3.14*radius;
        area=3.14*radius*radius;
    }

     public static int Addition(this Maths2 m ,int a,int b)
    {
        return a+b;
    }
    public static int Substraction(this Maths2 m,int a,int b)
    {
        return a-b;
    }


}
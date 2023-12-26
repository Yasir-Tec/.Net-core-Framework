namespace abcd;

public class Maths2{
    public int Num1{set;get;}
    public int Num2{set;get;}

    public int Multiplication(int a,int b){
        return a*b;
    }

    public int Division(int a,int b){
        return a/b;
    }

    public void ShowMethod(params object [] abc){
        foreach(object a in abc)
        {
            Console.Write(a+" ");
        }
    }
}
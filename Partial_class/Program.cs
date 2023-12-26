// See https://aka.ms/new-console-template for more information
using abc;
using abcd;

Console.WriteLine("Partial class program !");

Console.WriteLine();

student s1=new student();
s1.id=1;
s1.name="rushi";
s1.pin=1234;
s1.city="mumbai";

Console.WriteLine(s1.name);
Console.WriteLine(s1.pin);
Console.WriteLine(s1.city);
Console.WriteLine(s1.id+s1.name+s1.pin+s1.city);
Console.WriteLine();
new student().Display(9);
Console.WriteLine("----------------------------------------");



Maths2 mobj3 = new Maths2();
int p=100;
int q=10;
int ans=0;
ans=mobj3.Multiplication(p,q);
Console.WriteLine("Mul = "+ans);
ans=mobj3.Division(p,q);
Console.WriteLine("Div = "+ans);

ans=mobj3.Addition(p,q);
Console.WriteLine("Add = "+ans);
ans=mobj3.Substraction(p,q);
Console.WriteLine("Sub = "+ans);
Console.WriteLine("----------------------------------------");


Maths2 mobj5 = new Maths2();
mobj5.ShowMethod("prathamesah","nale","Phaltan","pune",520,5.20,true,"abc");
Console.WriteLine();
Console.WriteLine("----------------------------------------");

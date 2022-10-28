using System;
namespace SingleCasting;
public delegate int Calculator(int value);//can add method having int return type & 1 int arg
class Program
{
    static int value=10 ;

    public static int Add(int number){value+=number; return value;}

    public static int Multiply(int number){value*=number; return value;}

    public static int GetNum() {return value; }
    public static void Main(string[] args)
    {
      //Create Delegates instances Or Objects
      Calculator nc1=new Calculator(Add);
      Calculator nc2=new Calculator(Multiply);
      //calling methods directly
      Add(10);
      //calling the methods using the delegates the objects
      System.Console.WriteLine("Output: "+nc1(25));
      System.Console.WriteLine("Value of Num{0}:",GetNum());
      System.Console.WriteLine("Output: "+nc2(5));
      System.Console.WriteLine("Value of Num{0}:",GetNum());
    }
}

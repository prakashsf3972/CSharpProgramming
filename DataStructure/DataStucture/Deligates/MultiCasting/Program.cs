using System;
namespace MultiCasting;
public delegate int Calculator(int value);
class Program
{
    static int value=10 ;

    public static int Add(int number){value+=number; return value;}

    public static int Multiply(int number){value*=number; return value;}

    public static int GetNum() {return value; }
        public static void Main(string[] args)
        {
            //MultiCasting
            //create delegates Instances
            Calculator nc;
            nc=new Calculator(Add);
            nc+=new Calculator(Multiply);
            //Calling Mulicast
            nc(5);
            System.Console.WriteLine("Value of Num {0}",GetNum());
        }
    }


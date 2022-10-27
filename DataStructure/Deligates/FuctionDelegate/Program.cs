using System;
namespace FunctionDelegates;

class Program
{
     static double Sum(int number1,int number2){return number1+number2;}
        static double Subtract(int number1,int number2){return number1-number2;}
        static double Calculator(Func<int,int,double>operation,int x,int y)
                                    //a //b //returning //nc
        {
            return operation(x,y);
            
        }
    public static void Main(string[] args)
    {
       System.Console.WriteLine(Calculator(Sum,10,20));
       System.Console.WriteLine(Calculator(Subtract,10,20));  
    }
}

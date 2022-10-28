using System;
namespace ActionDelegates;

class Program
{
     static void Add(int number1,int number2)
     {
        System.Console.WriteLine("Output"+(number1+number2));
     }
     static void Multiply(int number1,int number2)
     {
        System.Console.WriteLine("Output"+(number1*number2));
     }
     static void Calculator(Action<int,int>action,int input1,int input2)
     {                                  //parameters only
        action(input1,input2);
     }
     public static void Main(string[] args)
     {
        Action<int,int> action=Add;
        action+=Multiply;//Multicasting action delegates
        action(10,20);//No return type,can take 16 Arguments
        Calculator(Add,10,10);
     }
}

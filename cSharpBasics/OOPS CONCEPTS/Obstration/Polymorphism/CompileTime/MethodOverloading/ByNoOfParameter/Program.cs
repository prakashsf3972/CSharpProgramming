using System;
namespace ByNoOfParameter;
class Program{
    public static void Main(string[] args)
    {
       Display(10);
       Display(10,20);
    }
     //Method int Number
        static void Display(int number)
        {
            System.Console.WriteLine("Number"+number);
        }
        static void Display(int number1,int number2)
        {
            System.Console.WriteLine("Number1"+number1 + "Number2"+number2);
        }
       

}

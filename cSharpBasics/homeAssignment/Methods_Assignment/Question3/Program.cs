using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a Value1: ");
        int number1=(int.Parse(Console.ReadLine()));
        System.Console.WriteLine("Enter a Value2: ");
        int number2=(int.Parse(Console.ReadLine()));
        int temp;
        swap(number1,number2);

        
        void swap(int number1,int number2)
        {
            temp=number1;
            number1=number2;
            number2=temp;
            System.Console.WriteLine("Now the 1st value : "+number1);
            System.Console.WriteLine("Now the 2nd value : "+number2);
        }
    }
}
using System;
namespace ValueRefType;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a Number 1: ");
        int number1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter a Number 2: ");
        int number2=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Number 1 is :"+number1);
        number2=number1;
        System.Console.WriteLine("Number 2 is :"+number2);

        ValueRefDetails object1;
        object1=new ValueRefDetails();

        object1.Number=10;
        ValueRefDetails object2=object1;

        System.Console.WriteLine($"Number 1 is :{object1.Number} Number 2 is : {object2.Number}");

    }
}

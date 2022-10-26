using System;
namespace Qustion13;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a  Number to show Mathematical Table: ");
        int number=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Mathematical Table For Given Number is: ");
        for(int initial=1;initial<=20;initial++)
        {
            System.Console.Write(number*initial+" ");
        }
    }
}

using System;
namespace Question10;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a Number: ");
        int number =(int.Parse(Console.ReadLine()));
        int count=0;

        for(int initial=1;initial <= number;initial++)
        {
            if(number % initial == 0)
            {
                count++;
            }
        }
        if(count == 2)
        {
            System.Console.WriteLine($"The Given number {number} is a Prime number");
        }
        else
        {
            System.Console.WriteLine($"The Given number {number} is not a Prime number");
        }
    }
}

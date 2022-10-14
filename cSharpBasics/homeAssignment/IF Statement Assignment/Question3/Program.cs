using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a Year : ");
        int year = (int.Parse(Console.ReadLine()));

        if(year % 4 == 0 )
        {
            if( year % 100 == 0)
                {
                 if (year % 400 == 0)
                    {
                    System.Console.WriteLine($"{year} is a Leap Year");
                    }
                else
                    {
                    System.Console.WriteLine($"{year} is not a Leap Year");
                    }
                }
            else
            {
                System.Console.WriteLine($"{year} is a Leap Year");
            }
        }
        else
        {
            System.Console.WriteLine($"{year} is not a Leap year");
        }
    }
}
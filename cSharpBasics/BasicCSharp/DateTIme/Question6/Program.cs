using System;
namespace Question6;
class Program
{
    public static void Main(string[] args)
    {
       DateTime date=new DateTime(2016,08,20,4,18,17);
       DateTime add=date.AddDays(40.0);
       System.Console.WriteLine(date);
       System.Console.WriteLine(add.DayOfWeek);
    }
}

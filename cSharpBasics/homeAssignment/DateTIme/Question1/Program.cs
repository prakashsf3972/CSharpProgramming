using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        DateTime[] dates = { DateTime.Now, new DateTime(2016, 8, 16, 9, 28, 0),  
        new DateTime(2011, 5, 28, 10, 35, 0),new DateTime(1979, 12, 25, 14, 30, 0) };
        foreach(DateTime date in dates)
        {
        Console.WriteLine("Day:"+date.ToString("dd/MM/yyyy")+" Time"+date.ToString("HH:mm:ss"));
        Console.WriteLine("Day:"+date.ToString("dd/MM/yyyy")+" Time"+date.ToString("hh:mm:ss tt"));
        }
        System.Console.WriteLine();
    }
}

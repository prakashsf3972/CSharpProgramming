using System;
using System.IO;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a First Date in Format dd/MM/yyyy : ");
        DateTime firstDate=DateTime.ParseExact(System.Console.ReadLine(),"dd/MM/yyyy",null);
        System.Console.WriteLine("Enter a Second Date in Format dd/MM/yyyy :" );
        DateTime secondDate=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

        TimeSpan differnce=firstDate-secondDate;
        System.Console.WriteLine("Difference Between No of Days is: "+differnce.Days);
    }
}

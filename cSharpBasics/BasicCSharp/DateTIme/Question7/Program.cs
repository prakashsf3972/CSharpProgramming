using System;
namespace Question7;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a Date1: ");
        DateTime date1=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        System.Console.WriteLine("Enter a Date2: ");
        DateTime date2=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        if(date1<date2)
        {
            System.Console.WriteLine("date date1 is Lesser than date2");
        }
        else
        {
            System.Console.WriteLine("date2 is Greater");
        }
    }
}

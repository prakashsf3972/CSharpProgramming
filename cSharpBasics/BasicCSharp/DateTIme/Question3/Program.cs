using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
         
         System.Console.WriteLine("Enter a Date in Format : dd/MM/yyyy hh:mm:ss");
         DateTime date=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy hh:mm:ss",null);
         System.Console.WriteLine("Year : "+date.Year);
         System.Console.WriteLine("Month: "+date.Month);
         System.Console.WriteLine("Date :"+date.Date);
         System.Console.WriteLine("Hours:"+date.Hour);
         System.Console.WriteLine("Minutes:"+date.Minute);
         System.Console.WriteLine("MilliSeconds :"+date.Millisecond);

    }
}

using System;
namespace Question9;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a month : ");
        string month =(Console.ReadLine().ToUpper());
        
        if((month=="DECMBER") || (month =="JANUARY") || (month =="FEBUARY"))
        {
            System.Console.WriteLine("winter");
        }
        else if((month=="MARCH") || (month =="ARRIL") || (month =="MAY"))
        {
            System.Console.WriteLine("spring");
        }
        else if((month=="JUNE") || (month =="JULY") || (month =="AUGUST"))
        {
            System.Console.WriteLine("summer");
        }
        else if((month=="SEPTEMBER") || (month =="OCTOBER") || (month =="NOVEMBER"))
        {
            System.Console.WriteLine("rainfall");
        }
        else
        {
          System.Console.WriteLine("Invalid input");
        }
    }
}

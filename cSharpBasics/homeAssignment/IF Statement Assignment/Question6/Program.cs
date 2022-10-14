using System;
namespace Queestion6;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter your Temperature in Centigrade");
        int temp= (int.Parse(Console.ReadLine()));
        
        if(temp < 0)
        {
            System.Console.WriteLine("It's a Freezing weather");
        
        }
        if ((temp >= 0)&&(temp < 10))
        {
           System.Console.WriteLine("It's a  Very Cold weather");
        }
        if((temp >= 10) && (temp < 20))
        {
            System.Console.WriteLine("It's a Cold weather");
        }
        if((temp >=  20) && (temp < 30 ))
        {
            System.Console.WriteLine("It's Normal in Temperature");
        }
        if ((temp>=30) &&  (temp < 40))
        {
            System.Console.WriteLine("Its Hot ");
        }
        if(temp>=40)
        {
            System.Console.WriteLine("Its Very hot");
        }
    }
}

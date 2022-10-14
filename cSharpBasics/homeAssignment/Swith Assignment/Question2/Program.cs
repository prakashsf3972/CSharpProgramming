using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a day you want : ");
        int day = (int.Parse(Console.ReadLine()));
        
        switch(day)
        {
          case 1:
          {
            System.Console.WriteLine("Sunday");
            break;
          }
          case 2:
          {
            System.Console.WriteLine("Monday");
            break;
          }
          case 3:
          {
            System.Console.WriteLine("Tuesday");
            break;
          }
          case 4:
          {
            System.Console.WriteLine("Wednesday");
            break;
          }
          case 5:
          {
            System.Console.WriteLine("Thursday");
            break;
          }
          case 6:
          {
            System.Console.WriteLine("Friday");
            break;
          }
          case 7:
          {
            System.Console.WriteLine("Saturday");
            break;
          }
          default:
          {
            System.Console.WriteLine("Invalid input");
            break;
          }

          
        }
    }
}

using System;
namespace Question12;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a initial number:");
        int initial=(int.Parse(Console.ReadLine()));
        System.Console.WriteLine("Enter a Final number:");
        int final=(int.Parse(Console.ReadLine()));
        double square=0,sum=0;
        System.Console.WriteLine("The square of sum Odd numbers are: ");
        for(initial=initial;initial<=final;initial++)
        {
          if(initial%2!=0)
          {
            square=initial*initial;
            sum=square+sum;
          }
        }
        System.Console.WriteLine($"{sum}");
    }
}

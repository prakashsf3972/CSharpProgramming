using System;
namespace Question2;
class  Program{
    public static void Main(string[] args)
    {
        double sum=0,count=0;
        double average;
        System.Console.WriteLine("Enter a initial value :");
        int initial =(int.Parse(Console.ReadLine()));
        System.Console.WriteLine("Enter a End value :");
        int End =(int.Parse(Console.ReadLine()));
         for(;initial<=End;initial++)
         {
            sum=sum+initial;
            count++;
         }
         average=(sum/count);
         System.Console.WriteLine($"Sum of values {sum}");
         System.Console.WriteLine($"Average is {average}");
    }
}

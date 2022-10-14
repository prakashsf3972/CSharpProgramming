using System;
namespace Question;
class Program{
    public static void Main(string[] args)
    {
      int count=2,terms,first_number=0,second_number=1,series;
      System.Console.WriteLine("Enter a Number of terms:");
      terms=(int.Parse(Console.ReadLine()));
      System.Console.WriteLine($"Fibonacci Series:\n{first_number} \n{second_number}");
      do
      {
        series=first_number+second_number;
        first_number=second_number;
        second_number=series;
        count++;
        System.Console.WriteLine($"{series}");
      }while(count<terms);
    }
}

using System;
namespace Question5;
class Program
{
public static void Main(string[] args)
{
    System.Console.WriteLine("Enter a physics mark :");
    int physics=(int.Parse(Console.ReadLine()));
    System.Console.WriteLine("Enter a chemistry mark :");
    int chemistry=(int.Parse(Console.ReadLine()));
    System.Console.WriteLine("Enter a Math Maths mark :");
    int maths=(int.Parse(Console.ReadLine()));

    double sum = (physics +  chemistry + maths);

    double percentage =(sum/3);

    System.Console.WriteLine($"Sum = {sum}");
    System.Console.WriteLine($"Percentage = {percentage}");
   
}
}

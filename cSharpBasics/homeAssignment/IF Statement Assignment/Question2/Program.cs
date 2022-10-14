using System;
namespace Question2;
class Program
{
public static void Main(string[] args)
{
    System.Console.WriteLine("Enter you Age Here : ");
    int age = (int.Parse(Console.ReadLine()));

    if(age >= 18)
    {
        System.Console.WriteLine("Congratulation! Your are Eligible for Casting Your vote");
    }
    else
    {
        System.Console.WriteLine("Sorry Your are not Eligible for Casting your vote");
    }
}
}

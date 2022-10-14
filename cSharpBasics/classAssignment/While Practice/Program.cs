using System;
namespace Whilepractice;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Do you hungry : ");
        string food=(Console.ReadLine().ToLower);
        while(food=="yes")
        {
            System.Console.WriteLine("Eat Food");
            System.Console.WriteLine("Do you feel hungry more:");
            food=(Console.ReadLine());
        }
    }
}

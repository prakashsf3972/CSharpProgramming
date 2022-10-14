using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        int sum=0,digits,rem;
        System.Console.WriteLine("Enter a number: ");
        digits=(int.Parse(Console.ReadLine()));
        while(digits>0)
        {
            rem=(digits%10);
            sum=sum+rem;
            digits=digits/10;
        }
        System.Console.WriteLine($"{sum}");
    }
}

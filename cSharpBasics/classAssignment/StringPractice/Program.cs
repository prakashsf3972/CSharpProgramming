using System;
namespace StringPractice;
class Program{
    public static void Main(string[] args)
    {
    //int count=0;
    string Longer,find;
    System.Console.WriteLine("Enter a Longer string: ");
    Longer=(Console.ReadLine());
    System.Console.WriteLine("Enter your string you want:");
    find=Console.ReadLine();
    string[] sub=(Longer.Split(find));
    int length=sub.Length-1;
    System.Console.WriteLine($"The count is:{length}");
    }

}
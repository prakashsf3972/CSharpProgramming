using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a String: ");
        string input=Console.ReadLine();
        int count=0;
        
        foreach(char words in input)
        {
            count++;
        }
        System.Console.WriteLine("length of Array : "+count);
    }
}

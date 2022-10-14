using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
       System.Console.WriteLine("Enter a String:");
       string value=Console.ReadLine();
       System.Console.WriteLine("The sperate Strings are:");
       foreach(char words in value) 
       {
        System.Console.Write(words+" ");
       }
    }
}

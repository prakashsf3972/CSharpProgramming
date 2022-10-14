using System;
namespace Question9;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Input the string: ");
        string input=Console.ReadLine();
        System.Console.WriteLine("search a string: ");
        string search=Console.ReadLine();
        bool find=input.Contains(search);
        if(find)
        {
            System.Console.WriteLine("The substring exists in the string");
        }
        else{
            System.Console.WriteLine("no substring");
        }
    }
}

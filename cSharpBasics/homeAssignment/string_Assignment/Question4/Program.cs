using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a String: ");
        string input=Console.ReadLine();
        int count=0;
        
        string[] copy=input.Split(new char[] {' '},StringSplitOptions.None);
        for(int initial=0;initial<copy.Length;initial++)
        {
            count++;
        }
        System.Console.WriteLine("The String count is "+count);
    }
}

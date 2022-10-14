using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a string: ");
        string input=Console.ReadLine();
        int count=0;
        foreach(char words in input)
        {
            count++;
        }
        for(count=count-1;count>=0;count--)
        {
            System.Console.Write(input[count]+" ");
        }
    }
}

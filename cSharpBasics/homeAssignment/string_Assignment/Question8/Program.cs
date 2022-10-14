using System;
namespace Question8;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a String: ");
        string exact=Console.ReadLine();
        System.Console.WriteLine("Input the position to start extraction: ");
        int position=(int.Parse(Console.ReadLine()));
        System.Console.WriteLine("Input the length of substring: ");
        int len=(int.Parse(Console.ReadLine()));
        
        for(int i=position;i<=position+len;i++)
        {
            System.Console.Write(exact[i]);
        }
    }
}

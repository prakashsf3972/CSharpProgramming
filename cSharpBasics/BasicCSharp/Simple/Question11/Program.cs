using System;
namespace Question11;
class Program{
    public static void Main(string[] args)
    {
       System.Console.WriteLine("Enter a Number For X:  ");
       int x=int.Parse(Console.ReadLine());
       System.Console.WriteLine("Enter A Number For Y:  ");
       int y=int.Parse(Console.ReadLine());
       System.Console.WriteLine("The Numbers are: ");
       for(x=x;x<=y;x++)
       {
            System.Console.Write(((x)*y*y) +" ");
       }

    }
}

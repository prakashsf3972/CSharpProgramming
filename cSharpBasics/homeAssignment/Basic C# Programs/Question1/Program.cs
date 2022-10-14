using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("ENTER A NAME :");
        string Name=Console.ReadLine();
        

//CONCATENATION

        System.Console.WriteLine("Hello :" + Name );
        

//PLACE HOLDER

        System.Console.WriteLine("Hello :{0}",Name);

//$ PLACE HOLDER

        System.Console.WriteLine($"Hello :{Name}");
        
        
    }
}

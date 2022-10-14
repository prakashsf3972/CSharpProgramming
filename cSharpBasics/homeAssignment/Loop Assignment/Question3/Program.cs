using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a initial value : ");
        int initial =(int.Parse(Console.ReadLine()));
        System.Console.WriteLine("Enter a End Value : ");
        int end =(int.Parse(Console.ReadLine()));
        for(;initial<=end;initial++)
        {
            System.Console.WriteLine($"{initial} cube  is {(initial*initial*initial)}");
        }
    }
}

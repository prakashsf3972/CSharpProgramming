using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Number to Multiple : ");
        double multipleNum=(double.Parse(Console.ReadLine()));
        System.Console.WriteLine("Enter a initial value :");
        int initial =(int.Parse(Console.ReadLine()));
        System.Console.WriteLine("Enter a End value : ");
        int end =(int.Parse(Console.ReadLine()));

        for(;initial<=end;initial++)
        {
            System.Console.WriteLine($"{multipleNum} x {initial} = {multipleNum * initial} ");
        }
    }
}

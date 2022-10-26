using System;
namespace Question9;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a Month:");
        string month=(Console.ReadLine().ToLower());
        int days,total=0,present;
        int salary=500;
        System.Console.WriteLine("Enter no of days Leave: ");
        int leave=(int.Parse(Console.ReadLine()));
        if((month=="january")||(month=="march")||(month=="may")||(month=="july")||(month=="august")||(month=="october")||(month=="december"))
        {
            days=31;
            present=days-leave;
            total=(present*salary);
            System.Console.WriteLine($"Total salary:{total}");
        }
        else if((month=="april")||(month=="june")||(month=="september")||(month=="november"))
        {
            days=30;
            present=days-leave;
            total=(present*salary);
            System.Console.WriteLine($"Total salary:{total}");
        }
        else
        {
            days=28;
            present=days-leave;
            total=(present*salary);
            System.Console.WriteLine($"Total salary:{total}");
        }
    }
}

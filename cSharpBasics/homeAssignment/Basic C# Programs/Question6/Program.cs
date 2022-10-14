using System;
namespace Question6;
class Program
{
public static void Main(string[] args)
{
    System.Console.WriteLine("Total Price amount : ");
    int Price=(int.Parse(Console.ReadLine()));

    double Total=Price + Price * 0.18;

    System.Console.WriteLine($"Price = {Price}");
    System.Console.WriteLine($"Total = {Total} ");

}
}

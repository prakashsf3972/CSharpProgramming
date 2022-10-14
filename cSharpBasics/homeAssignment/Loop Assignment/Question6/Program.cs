using System;
namespace Question6;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter number of rows :");
        int rows=(int.Parse(Console.ReadLine()));
        for(int i=1;i<=rows;i++)
        {
            for(int j=0;j<i;j++)
            {
               System.Console.Write("*");
            }
            System.Console.WriteLine();
        }
    }
}

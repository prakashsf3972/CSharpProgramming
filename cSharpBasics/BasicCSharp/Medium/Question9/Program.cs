using System;
namespace Question9;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter number of rows: ");
        int rows=(int.Parse(Console.ReadLine()));
        int space=rows-1;
        int star=1;
        for(int i=1;i<=rows;i++)
        {
            for(int j=1;j<=space;j++)
            {
                System.Console.Write(" ");
            }
            for(int k=1;k<=star;k++)
            {
                System.Console.Write(" *");
            }
            System.Console.WriteLine();
            space--;
            star++;
        }

    }
}

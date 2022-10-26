using System;
namespace Question14;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a Number Of Rows : ");
        int rows=int.Parse(Console.ReadLine());
        for(int i=1;i<=rows;i++)
        {
            for(int j=1;j<=i;j++)
            {
                System.Console.Write(i);
            }
            System.Console.WriteLine();
        }
    }
}

using System;
namespace Question7;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Number of ROWs: ");
        int rows=(int.Parse(System.Console.ReadLine()));
        int space=rows;
        int star=1;
        for(int i=1;i<=rows;i++)
        {
            for(int j=1;j<space;j++)
            {
              System.Console.Write(" ");
            }
            for(int k=0;k<star;k++)
            {
                System.Console.Write("* ");
            }
            System.Console.WriteLine();
            space--;
            star++;
        }
    }
}

using System;
namespace Question8;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Number of Rows: ");
        int rows=(int.Parse(Console.ReadLine()));
        int space=rows-1;
        int l=1;
        for(int i=1;i<=rows;i++)
        {
            for(int j=1;j<=space;j++)
            {
                System.Console.Write(" ");
            }
            for(int k=l;k<=i;k++)
            {
                System.Console.Write(" "+l);
                l++;
            }
            System.Console.WriteLine();
            space--;
        }
    }
}

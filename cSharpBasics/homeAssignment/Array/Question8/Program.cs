using System;
namespace Question8;
class Program{
    public static void Main(string[] args)
    {
       System.Console.WriteLine("Enter a no.of.Rows: ");
       int row=(int.Parse(Console.ReadLine()));
       System.Console.WriteLine("Enter a no.of.column: ");
       int column=(int.Parse(Console.ReadLine()));
       int[,] arr1=new int[row,column];
       System.Console.WriteLine("Enter a Matrix:");
       for(int i=0;i<row;i++)
       {
        for(int j=0;j<column;j++)
        {
            arr1[i,j]=(int.Parse(Console.ReadLine()));
        }
       }
       for(int i=0;i<row;i++)
       {
        for(int j=0;j<column;j++)
        {
           System.Console.Write(arr1[i,j]+" ");
        }
        Console.WriteLine();
       }



    }
}

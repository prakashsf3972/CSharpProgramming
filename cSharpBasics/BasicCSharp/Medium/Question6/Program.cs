using System;
namespace Question;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter no rows of rows matrix:");
        int rows=(int.Parse(Console.ReadLine()));
        System.Console.WriteLine("Enter no column of columns Matrix:");
        int columns=(int.Parse(Console.ReadLine()));
        int[,] arr1=new int[rows,columns];
        int[,] arr2=new int[rows,columns];
        int[,] arr3=new int[rows,columns];
        System.Console.WriteLine("Enter a First Matrix Input");
        for(int i=0;i<rows;i++)
        {
            for(int j=0;j<columns;j++)
            {
              arr1[i,j]=(int.Parse(Console.ReadLine()));
            }
        }
        System.Console.WriteLine("Enter a Second Matrix input");
        for(int i=0;i<rows;i++)
        {
            for(int j=0;j<columns;j++)
            {
              arr2[i,j]=(int.Parse(Console.ReadLine()));
            }
        }
        for(int i=0;i<rows;i++)
        {
            for(int j=0;j<columns;j++)
            {
              arr3[i,j]=arr1[i,j]+arr2[i,j];
            }
        }
        System.Console.WriteLine("Sum of arrays are: ");
        for(int i=0;i<rows;i++)
        {
            for(int j=0;j<columns;j++)
            {
              System.Console.Write(arr3[i,j]+" ");
            }
            System.Console.WriteLine();
        }
    }
}

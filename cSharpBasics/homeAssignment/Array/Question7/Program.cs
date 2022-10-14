using System;
namespace Question7;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a Row: ");
        int row=(int.Parse(Console.ReadLine()));
        System.Console.WriteLine("Enter a Column: ");
        int column=(int.Parse(Console.ReadLine()));
        int[,] arr1=new int[row,column];
        int[,] arr2=new int[row,column];
        int[,] arr3=new int[row,column];
        System.Console.WriteLine("Enter a 1st Array: ");
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<column;j++)
            {
                arr1[i,j]=(int.Parse(Console.ReadLine()));
            }
        }
        System.Console.WriteLine("Enter a 2nd Array: ");
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<column;j++)
            {
                arr2[i,j]=(int.Parse(Console.ReadLine()));
            }
        }
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<column;j++)
            {
                arr3[i,j]=arr1[i,j]+arr2[i,j];
            }
        }
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<column;j++)
            {
                System.Console.Write(arr3[i,j]+" ");
            }
            System.Console.WriteLine();
        }  
    }
}

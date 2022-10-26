using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
       int[,] arr1=new int[2,3];
       int[,] arr2=new int[3,2];
       int[,] arr3=new int[2,2];
       System.Console.WriteLine("Enter a First Matrix :");
       for(int i=0;i<2;i++)
       {
         for(int j=0;j<3;j++)
        {
            arr1[i,j]=(int.Parse(Console.ReadLine()));
        }
       }
       System.Console.WriteLine("Enter a Second Matrix: ");
       for(int i=0;i<3;i++)
       {
        for(int j=0;j<2;j++)
        {
            arr2[i,j]=(int.Parse(Console.ReadLine()));
        }
       }
        for(int i=0;i<3;i++)
        {
            for(int j=0;j<2;j++)
            {
              for(int k=0;k<3;k++)
              {
                arr3[j,j]=arr1[i,k]*arr2[k,j];
              }
            }
        }
        for(int i=0;i<2;i++)
        {
            for(int j=0;j<2;j++)
            {
                System.Console.WriteLine(arr3[i,j]);
            }
            System.Console.WriteLine();
        }
}
}

using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a Number: ");
        int[] Num_box=new int[10];
        for(int initial=0;initial<10;initial++)
        {
         Num_box[initial]=(int.Parse(Console.ReadLine()));
        }
        System.Console.WriteLine("Elements in Array Are:");
        for(int initial=0;initial<10;initial++)
        {
            System.Console.Write(Num_box[initial]+" ");
        }
    }
}

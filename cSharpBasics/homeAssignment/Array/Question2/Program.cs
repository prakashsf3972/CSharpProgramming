using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
     System.Console.WriteLine("Enter a Size of an Array: ");
     int arr_size=(int.Parse(Console.ReadLine()));

     System.Console.WriteLine("Enter a Number:");
     int[] Num_box=new int[arr_size];

        for(int initial=0;initial<arr_size;initial++)
        {
         Num_box[initial]=(int.Parse(Console.ReadLine()));
        }
        System.Console.WriteLine("Reverse elements in Array Are:");
        for(int initial=(arr_size-1);initial>=0;initial--)
        {
            System.Console.Write(Num_box[initial]+" ");
        }
    }

}

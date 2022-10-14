using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
    int Sum=0;
     System.Console.WriteLine("Enter a Size of an Array: ");
     int arr_size=(int.Parse(Console.ReadLine()));

     System.Console.WriteLine("Enter a Number:");
     int[] Num_box=new int[arr_size];

        for(int initial=0;initial<arr_size;initial++)
        {
         Num_box[initial]=(int.Parse(Console.ReadLine()));
        }
        System.Console.WriteLine("Sum of Elements in the Array:");
        for(int initial=0;initial<arr_size;initial++)
        {
            Sum=Num_box[initial]+Sum;
        }
        System.Console.Write($"{Sum}");
    }

}


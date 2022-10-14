using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
     System.Console.WriteLine("Enter a Size of an Array: ");
     int arr_size=(int.Parse(Console.ReadLine()));
     int[] even=new int[arr_size];
     int[] odd=new int[arr_size];

     System.Console.WriteLine("Enter a Number:");
     int[] Num_box=new int[arr_size];

        for(int initial=0;initial<arr_size;initial++)
        {
         Num_box[initial]=(int.Parse(Console.ReadLine()));
        }
        for(int initial=0;initial<arr_size;initial++)
        {
            if(Num_box[initial] % 2==0)
            {
                even[initial]=Num_box[initial];
            }
            else
            {
                odd[initial]=Num_box[initial];
            }
        }
        System.Console.Write("The even Numbers are :");
        for(int initial=0;initial<arr_size;initial++)
        {
         System.Console.Write(even[initial]+" ");
        }
        System.Console.Write("The Odd Numbers are :");
        for(int initial=0;initial<arr_size;initial++)
        {
         System.Console.Write(odd[initial]+" ");
        }
    }

}


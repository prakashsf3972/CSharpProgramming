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
        int max=Num_box[0];
        int min=Num_box[0];
        for(int initial=0;initial<arr_size;initial++)
        {
          if(max<Num_box[initial])
          {
            max=Num_box[initial];
          }
          else if(min<Num_box[initial])
          {
            min=Num_box[initial];
          }
    
        }
        System.Console.WriteLine($"The Maximum Number is {max}");
        System.Console.WriteLine($"The minimum number is {min}");
    }

}


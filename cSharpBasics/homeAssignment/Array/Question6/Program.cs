using System;
namespace Question6;
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
        int less= 0;
        for(int initial=0;initial<arr_size;initial++)
        {
          for(int nextindex=initial+1;nextindex<arr_size;nextindex++)
          {
            if(Num_box[initial]>Num_box[nextindex])
            {
              less = Num_box[nextindex];
              Num_box[nextindex] = Num_box[initial];
              Num_box[initial] = less;
            }
          }
        }
        System.Console.WriteLine("The ascending Order of Array is:");
        for(int initial=0;initial<arr_size;initial++)
        {
                System.Console.Write(Num_box[initial]+" ");
        }
        }
}
        

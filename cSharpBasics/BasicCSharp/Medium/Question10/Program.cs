using System;
namespace Question10;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Length of Rectangle : ");
        int length=(int.Parse(Console.ReadLine()));
        int breath=length+2;
        for(int i=0;i<length;i++)
        {
            for(int j=0;j<breath;j++)
            {
                if(i==0||(i==(length-1))||(j==0)||(j==(breath-1)))
                {
                    System.Console.WriteLine("*"+" ");
                }
                else{
                    System.Console.WriteLine(" "+" ");
                }
            }
            System.Console.WriteLine();
        }
    }
}

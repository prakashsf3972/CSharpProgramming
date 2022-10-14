using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a Mark1: ");
        int mark1=(int.Parse(Console.ReadLine()));
        System.Console.WriteLine("Enter a Mark2: ");
        int mark2=(int.Parse(Console.ReadLine()));
        System.Console.WriteLine("Enter a Mark3: ");
        int mark3=(int.Parse(Console.ReadLine()));
        double percentage,Total=0;
        
        Percentage1(mark1,mark2,mark3);



        void Percentage1(int mark1,int mark2,int mark3)
        {
            Total=mark1+mark2+mark3;
            percentage=(Total/3);
            System.Console.WriteLine("mark 1 :"+mark1);
            System.Console.WriteLine("mark 2 :"+mark2);
            System.Console.WriteLine("mark 3 :"+mark3);
            System.Console.WriteLine("Percentage "+percentage);
        }
    }
}

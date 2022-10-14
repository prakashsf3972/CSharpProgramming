using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter your Physics Mark :");
        int physics=(int.Parse(Console.ReadLine()));
        System.Console.WriteLine("Enter your chemistry mark :");
        int chemistry=(int.Parse(Console.ReadLine()));
        System.Console.WriteLine("Enter your mathematics : ");
        int maths =(int.Parse(Console.ReadLine()));

        int percentage = ((physics + chemistry + maths) / 3);

        if(percentage >= 75)
        {
            System.Console.WriteLine("The candidate is Eligible for admission");
        }
        else
        {
            System.Console.WriteLine("The candidate is Not Eligible for admission");
        }

    }
}

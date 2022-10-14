using System;
namespace StudentDetails;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter a name:");
        string traineename=Console.ReadLine();

        System.Console.Write("Enter a age:");
        int age=(Convert.ToInt32(Console.ReadLine()));

        System.Console.Write("Enter mark of subject 1:");
        int subject1=(Convert.ToInt32(Console.ReadLine()));

        System.Console.Write("Enter mark of subject 2:");
        int subject2=(Convert.ToInt32(Console.ReadLine()));

        System.Console.Write("Enter mark of subject 3:");
        int subject3=(Convert.ToInt32(Console.ReadLine()));

        double Total=subject1+subject2+subject3;

        double Average=(Total/3);

        System.Console.Write("Enter Grade:");
        char Grade=(Convert.ToChar(Console.ReadLine()));

        System.Console.WriteLine("Enter Mobile number:");
        double number=(Convert.ToDouble(Console.ReadLine()));

        System.Console.WriteLine("Enter mail id: ");
        string mailid=Console.ReadLine();

        System.Console.WriteLine("cgpa: ");
        float Cgpa = (float.Parse(Console.ReadLine()));

        System.Console.WriteLine($"Trainee Details Are:");
        System.Console.WriteLine($"Name:{traineename}");
        System.Console.WriteLine($"Age:{age}");
        System.Console.WriteLine($"Marks1:{subject1}");
        System.Console.WriteLine($"Marks2:{subject2}");
        System.Console.WriteLine($"Marks3:{subject3}");
        System.Console.WriteLine($"Total:{Total}");
        System.Console.WriteLine($"Average:{Math.Round(Average,1)}");
        System.Console.WriteLine($"Enter grage:{Grade}");
        System.Console.WriteLine($"Mobile Number:{number}");
        System.Console.WriteLine($"Mailid:{mailid}");
        System.Console.WriteLine($"cgpa:{Cgpa}");
  
    }
}

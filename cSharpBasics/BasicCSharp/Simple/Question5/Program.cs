using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter your Salary: ");
        double Salary=(int.Parse(Console.ReadLine()));
        double DA=0.10,HRA=0.10,Taxes=0.05;
        double bonus=Salary+DA+HRA;
        double decreses=Taxes-Salary;
        double Annual_income=bonus-decreses;
        System.Console.WriteLine($"Annual Income is :{Annual_income}RS");
    }
}
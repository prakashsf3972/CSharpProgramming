using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a Year in Format: ");
        DateTime year=new DateTime(2000,12,31);
        for(int i=0;i<=20;i++)
        {
            DateTime dateToDisplay=year.AddYears(i);
            System.Console.WriteLine($"{dateToDisplay.ToString("dd/MM/yyyy")},{dateToDisplay.Year},{dateToDisplay.DayOfYear}");
            if(dateToDisplay.DayOfYear==365)
            {
                System.Console.WriteLine("not Leap Year");
            }
            else if(dateToDisplay.DayOfYear!=365)
            {
                System.Console.WriteLine("Leap Year");
            }
        }

    }
}

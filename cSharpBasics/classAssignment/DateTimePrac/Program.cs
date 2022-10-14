using System;
namespace DateTimePrac;
class Program{
    public static void Main(string[] args)
   
    {
        DateTime date=new DateTime(2021,8,10,10,40,32);
        System.Console.WriteLine($"Year: {date.Year}");
        System.Console.WriteLine($"Month:{date.Month}");
        System.Console.WriteLine($"date:{date.Date}");
        System.Console.WriteLine($"day: {date.Day}");
        System.Console.WriteLine($"day: {date.Hour}");
        System.Console.WriteLine($"day: {date.Second}");
        string Convert;
        Convert=(date.ToString());
        System.Console.WriteLine(Convert);
        string[] Cut=(Convert.Split(new char[] {'/',' ',':'},StringSplitOptions.None));
        int count=-1;
        foreach(string element in Cut)
        {
            count++;
        }
        for(int initial=count;initial>=0;initial--)
        {
            System.Console.WriteLine(Cut[initial]);
        }
        System.Console.WriteLine("Enter a Datetime in Format: yyyy/MM/dd hh:mm:ss tt");
       DateTime daytime=DateTime.ParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null);
       System.Console.WriteLine(daytime.ToString("yyyy/MM/dd"));
        

    }
}

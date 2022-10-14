using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a month in integer : ");
        int month=(int.Parse(Console.ReadLine()));
        int choice=0;
        
        if((month == 1)||(month == 3)||(month == 5)||(month == 7)||(month == 8)||(month == 10)||(month ==12))
        {
            choice = 1;
        }
        else if((month == 4) || (month == 6) || ((month == 9) || (month == 11)))
        {
            choice = 2;
        }
        else if((month == 2))
        {
            choice =3;
        }
        else {
            System.Console.WriteLine("Invalid data");
        }
    switch(choice)
    {
        case 1:
        {
            System.Console.WriteLine("The Given month have 31 days");
            break;
        }
        case 2:
        {
            System.Console.WriteLine("The Given month have 30 days");
            break;
        }
        case 3:
        {
            System.Console.WriteLine("The Given month have 28 or 29 days");
            break;
        }
    }
    }
}

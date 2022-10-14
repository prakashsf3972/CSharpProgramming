using System;
namespace Question7;
class program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("To Enter your details :");

        System.Console.WriteLine("Enter your ID :");
        int customerid = (int.Parse(Console.ReadLine()));
        System.Console.WriteLine("Enter your Name : ");
        string name = (Console.ReadLine());
        System.Console.WriteLine("Enter your Electricity Unit :");
        double unit = (int.Parse(Console.ReadLine()));

        double amountcharges=0,surcharge,amount=0;

     if(unit>=0)
      {
        if((unit >=0) &&(unit <= 199))
        {
            amountcharges = 1.20;
            amount = unit * amountcharges;
        }
        else if((unit >=200) && (unit < 400) ) 
        {
            amountcharges = 1.50;
            amount = unit * amountcharges;
        }
        else if((unit >=400) && (unit < 600) )
        {
            amountcharges = 1.80;
            amount = unit * amountcharges;
        }
        else if(unit >=600)
        {
            amountcharges = 2.00;
            amount = unit * amountcharges;
        }
        if(amount >= 400 )
        {
            surcharge =(unit*0.15)*amountcharges;
        }
        else
        {
            surcharge =0;
        }
        amount = surcharge + amount;
        if((amount <= 100) && (amount >=0))
        {
            System.Console.WriteLine("The Minimum Bill value is 100");
        }
    
        System.Console.WriteLine($"Customer ID NO : {customerid}");
        System.Console.WriteLine($"Name : {name}");
        System.Console.WriteLine($"Unit : {unit}");
        System.Console.WriteLine($"Amountcharges @Rs {amountcharges} per unit");
        System.Console.WriteLine($"Surcharge amount : {surcharge}");
        System.Console.WriteLine($"Net amount Paid by the Customer : {amount}");
      }
      else
      {
      System.Console.WriteLine("The User Given Invalid Input");
      }
    }

}

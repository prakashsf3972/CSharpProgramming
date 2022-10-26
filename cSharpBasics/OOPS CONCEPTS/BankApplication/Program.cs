using System;
using System.Collections.Generic;
namespace BankApplication
{
    public class BankDetail
    {
        public static void Main(string[] args)
        {
        string statement="";
           List<BankDetails> bankd=new List<BankDetails>();
         do{
            System.Console.WriteLine("Enter your Name: ");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter your Father Name: ");
            string fathername=Console.ReadLine();
            System.Console.WriteLine("Enter your Gender:Default,Male,Female,TransGender");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine().ToUpper(),true);
            System.Console.WriteLine("Enter your Account Type :SavingsAccount,FB,SB,RD");
            AccountType accounttype=Enum.Parse<AccountType>(Console.ReadLine().ToLower(),true);
            
            BankDetails member=new BankDetails(name,fathername,gender,accounttype);
            System.Console.WriteLine("your Account id is :"+member.CustomerId);
            bankd.Add(member);
            System.Console.WriteLine("do you want to countinue (yes/no)");
            statement=Console.ReadLine();
         }while(statement=="yes");

         foreach(BankDetails members in bankd)
         {
            System.Console.WriteLine("Name :"+members.Name);
            System.Console.WriteLine("Father Name"+members.FatherName);
            System.Console.WriteLine("Gender:"+members.CustomerGender);
            System.Console.WriteLine("Account Type:"+members.CustomerAccountType);
            System.Console.WriteLine();
            System.Console.WriteLine("Enter your Deposit Amount: ");
            double depoist=(double.Parse(Console.ReadLine()));
            double depositBalance = members.Deposit(depoist);
            System.Console.WriteLine("Your available balance is: "+depositBalance);

            
            System.Console.WriteLine("Enter a Withdraw Amount: ");
            double withrawAmount=(double.Parse(Console.ReadLine()));
            double AvailableBal = members.WithDraw(withrawAmount);
            System.Console.WriteLine("Amount after withdrawal is: "+AvailableBal);
         }
        }
        
    }
}
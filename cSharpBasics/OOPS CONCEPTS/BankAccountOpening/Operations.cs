using System;
using System.Collections.Generic;
namespace BankAccountOpening
{
    /// <summary>
    /// Class Operations
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Create a new list to add members in the Banklist
        /// </summary>
        /// <typeparam name="BankDetails"></typeparam>
        /// <returns></returns>
        public static List<BankDetails> BankList=new List<BankDetails>();
/// <summary>
/// Mainmenu is a method to which is used to show a content in the mainmenu
/// </summary>
        public static void MainMenu()
        {
            string statement="yes";
            do{
           System.Console.WriteLine("|_______------MAINMENU------________|");
           System.Console.WriteLine("| 1.REGISTRATION| |2.LOGIN| |3.EXIT|");
           System.Console.WriteLine("Enter your choice");
           /// <summary>
           /// Swich statement is used to call a Method
           /// </summary>
           /// <returns></returns>
           int choice=int.Parse(Console.ReadLine());
                    switch(choice)
                    {
                        case 1:
                        {
                            Registration();
                            break;
                        }
                        case 2:
                        {
                            Login();
                            break;
                        }
                        case 3:
                        {
                        statement="no";
                        break;
                        }

                    }
            }while(statement=="yes");
        }
        /// <summary>
        /// Registration method is used to Register a new user
        /// </summary>
        public static void Registration()
        {
                System.Console.WriteLine("Enter your Name: ");
                string name=Console.ReadLine();
                System.Console.WriteLine("Enter your Gender:");
                Gender gender=Enum.Parse<Gender>(Console.ReadLine().ToLower());
                System.Console.WriteLine("Enter a PhoneNumber:");
                long phoneNumber=long.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter a Mailid:");
                string mailId=Console.ReadLine();
                System.Console.WriteLine("Enter your DateofBirth (dd/MM/yyyy) in Format:");
                DateTime dateOfBirth=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
                BankDetails member=new BankDetails(name,gender,phoneNumber,mailId,dateOfBirth);
                BankList.Add(member);
                System.Console.WriteLine($"Your Id is {member.CustomerId}");
        }
        /// <summary>
        /// Login method is used to login a already exist user
        /// </summary>
        public static void Login()
        {
            int temp=0;
            System.Console.WriteLine("You are in Login Section");
            System.Console.WriteLine("Enter your id :");
            string original=Console.ReadLine();
            BankDetails store;
            foreach(BankDetails search in BankList)
            {
                temp=1;
                if(original==search.CustomerId)
                {
                    store = search;
                    int option=(int.Parse(Console.ReadLine()));
                    Submenu(store);
                }
                else
                {
                    temp=0;
                }
                if(temp==0)
                {
                     System.Console.WriteLine("Your Enter Customer Id is Invalid");
                    System.Console.WriteLine("---------CaseSensitive----------\n sinup or register");
                    System.Console.WriteLine("Select a Option\n1.Mainmenu\n2.Login");
                    int option=int.Parse(Console.ReadLine());
                    switch(option)
                    {
                        case 1:
                        {
                            MainMenu();
                            break;
                        }
                        case 2:
                        {
                            Login();
                            break;
                        } 
                    }
                }
            }
        }   
        /// <summary>
        /// Submenu is shown when the user login Enters OriginalId       
        /// </summary>
        /// <param name="store"></param>
        public static void Submenu(BankDetails store)
        {
            string option="yes";
            do{
            System.Console.WriteLine("**********SUBMENU**********");
            System.Console.WriteLine("1.DEPOSIT \n2.WITHDRAW \n3.BALANCECHECK \n4.Exit");
            int choice=int.Parse(Console.ReadLine());
                    switch(choice)
                    {
                    case 1:
                    {
                        Deposit(store);
                        break;
                    }
                    case 2:
                    {
                        Withdraw(store);
                        break;
                    }
                    case 3:
                    {
                        BalanceCheck(store);
                        break;
                    }
                    case 4:
                    {
                        option="no";
                        break;
                    }
            }
           }while(option=="yes");
        }
        /// <summary>
        /// Deposit is used to Show the Details of user Deposit Amount
        /// </summary>
        /// <param name="store"></param>
        public static void Deposit(BankDetails store)
        {
            double balance=store.Balance;
            System.Console.WriteLine("Enter a Amount to Deposit");
            int deposit=int.Parse(Console.ReadLine());
            balance=balance+deposit;
            System.Console.WriteLine("your deposit amount is"+balance);
            
        }
        /// <summary>
        /// Withdraw it is shown when user Withdraw the Amount in bank
        /// </summary>
        /// <param name="store"></param>
        public static void Withdraw(BankDetails store)
        {
            System.Console.WriteLine("Enter a amount to Withdraw:");
            double withDraw=int.Parse(Console.ReadLine());
            if((store.Balance>0)&&(store.Balance>=100))
            {
                withDraw=store.Balance-withDraw;
                store.Balance=withDraw;
                System.Console.WriteLine("your Balance is"+withDraw);
          
                
            }
            else
            {
                System.Console.WriteLine("Insufficient Balance");
              
            }
        }
        /// <summary>
        /// CheckBalance is Shown When the user call a method
        /// </summary>
        /// <param name="store"></param>
        public static void BalanceCheck(BankDetails store)
        {
            System.Console.WriteLine("Your CurrentBalance is"+store.Balance);
  
        }
    }
}
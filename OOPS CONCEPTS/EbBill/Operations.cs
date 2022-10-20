using System;
using System.Collections.Generic;
namespace EbBill
{
    public class Operations
    {
        public static EbBillDetails loggedUser = null;
        public static List<EbBillDetails> ebDatails=new List<EbBillDetails>();
        /// <summary>
        /// MainMenu is a method to display a user to register,login
        /// </summary>
        public static void Mainmenu()
        {
            string option="yes";
            do{
            System.Console.WriteLine("*********Mainmenu***********");
            System.Console.WriteLine("1.Registration \n2.Login \n3.Exit");
            System.Console.WriteLine("Enter your Choice:");
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
                    break;
                    option="no";
                }
            }
            }while(option=="yes");

        }
        /// <summary>
        /// Registration is a method used to Register a new user
        /// </summary>
        public static void Registration()
        {
            System.Console.WriteLine("|*****************|");
            System.Console.WriteLine("|REGISTRATION PAGE|");
            System.Console.WriteLine("|*****************|");
            System.Console.WriteLine("Enter your Name: ");
            string userName=Console.ReadLine();
            System.Console.WriteLine("Enter your PhoneNumber:");
            double phoneNumber=double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your MailId: ");
            string mailId=Console.ReadLine();
            System.Console.WriteLine("Enter no of Units Used: ");
            double unitsUsed=double.Parse(Console.ReadLine());
            EbBillDetails member= new EbBillDetails(userName,phoneNumber,mailId,unitsUsed);
            System.Console.WriteLine(member.MeterId);
            ebDatails.Add(member);
        }
        /// <summary>
        /// Login is a method is used to Login Exciting user
        /// </summary>
        public static void Login()
        {
           int LoginChoice;
           System.Console.WriteLine("----------------------------");
           System.Console.WriteLine("........LOGIN PAGE...........");
           System.Console.WriteLine("------------------------------");
           System.Console.WriteLine("Enter your UserId: ");
           string id=Console.ReadLine();
           int count=0;
           foreach(EbBillDetails search in ebDatails)
           {
            if(id==search.MeterId)
            {
                loggedUser = search;
                SubMenu(id);
                count=1;
            }
            else
            {
                count=0;
            }
           }
           if(count==0)
           {
            System.Console.WriteLine("Your UserId is Invalid");
            System.Console.WriteLine("#######################");
            System.Console.WriteLine("if youre New user Enter 1.Register now (or)\n 2.Login");
            System.Console.WriteLine("------------------");
            LoginChoice=int.Parse(Console.ReadLine());
            switch(LoginChoice)
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
            }

           }
        }
        /// <summary>
        /// Submenu is shown when the user register Created id
        /// </summary>
        /// <param name="id"></param>
        public static void SubMenu(string id)
        {
            string select="yes";
            do
            {
            System.Console.WriteLine("***********SUBMENU***************");
            System.Console.WriteLine("1.Calculate Amount \n2.Display User Details \n3.Exit");
            System.Console.WriteLine("*********************************");
            System.Console.WriteLine("Enter your Choice: ");
            int choice=int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                    {
                        CalculateAmount(id);
                        break;
                    }
                    case 2:
                    {
                        DisplayUserDetails(id);
                        break;
                    }
                    case 3:
                    {
                        select="no";
                        break;
                    }
                }
            }while(select=="yes");
        }
        /// <summary>
        /// Calcualte amount is used to Calcualte a Ebbill details of login user
        /// </summary>
        /// <param name="id"></param>
        public static void CalculateAmount(string id)
        {
            double ebAmount,unit=5;
            foreach(EbBillDetails calculate in ebDatails)
            {
                if(id==calculate.MeterId)
                {
                    ebAmount=calculate.UnitUsed * unit;
                    System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
                    System.Console.WriteLine("        |METERID|           |USERNAME|            |UNITUSED|           |TOTALBILL|");
                    System.Console.WriteLine($"| {calculate.MeterId} | {calculate.UserName} || {calculate.UnitUsed} | {ebAmount} |");
                    System.Console.WriteLine("------------------------------------------------------------------------------------------------------------");

                }
            }
           
        }
        /// <summary>
        /// DisplayUserDetails is a method is used to display a login Details
        /// </summary>
        /// <param name="id"></param>
        public static void DisplayUserDetails(string id)
        {
            foreach(EbBillDetails detail in ebDatails)
            {
                if(id==detail.MeterId)
                {
                    System.Console.WriteLine("----------------------------------------------------------------");
                    System.Console.WriteLine("************************YOURDETAILS******************************");
                    System.Console.WriteLine("-----------------------------------------------------------------");
                    System.Console.WriteLine("|METERID|  \t|USERNAME|  |PHONENUMBER|  |MAILID|");
                    System.Console.WriteLine($"|{detail.MeterId}| \t|{detail.UserName}| |{detail.PhoneNumber}| \t|{detail.MailId}|");
                    System.Console.WriteLine("-----------------------------------------------------------------------------------");
                }
            }
        }
    }
}
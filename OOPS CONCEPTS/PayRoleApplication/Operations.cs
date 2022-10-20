using System;
using System.Collections.Generic;
namespace PayRoleApplication
{
    public static class Operations
    {
        /// <summary>
        /// static payrole class list is created to store a members in PayroleManage
        /// </summary>
        /// <typeparam name="PayRole"></typeparam>
        /// <returns></returns>
        public static List<PayRole> PayRoleManage=new List<PayRole>();
        public static void  Mainmenu()
        { 
             string statement="yes";
            do{
            int choice;
            System.Console.WriteLine("*********MAINMENU**********");
            System.Console.WriteLine("1.REGISTRATION \n2.LOGIN \n3.EXIT");
            System.Console.WriteLine("Choose your Field");
            choice=int.Parse(Console.ReadLine());
                    switch(choice)
                    {
                        /// <summary>
                        /// Registration is used to register for a New user
                        /// </summary>
                        /// <value></value>
                        case 1:
                        {
                            System.Console.WriteLine("*************REGISTRATION*******************");
                            Registration();
                            break;
                        }
                        /// <summary>
                        /// Login is used to login Excited user
                        /// </summary>
                        /// <value></value>
                        case 2:
                        {
                        System.Console.WriteLine("*****************LOGIN**********************");
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
        /// Registration method is called to register a customer
        /// </summary>
        public static void Registration()
        {
            System.Console.WriteLine("Enter a Employee Name: ");
            string employeeName=Console.ReadLine();
            System.Console.WriteLine("Enter a DateOFJoining in format(dd/MM/year)");
            DateTime dateOfJoining = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.WriteLine("Enter your Job Role");
            string jobRole=Console.ReadLine();
            System.Console.WriteLine("Enter a Gender:");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine().ToLower(),true);
            System.Console.WriteLine("Enter your JobLocation");
            Location jobLocation=Enum.Parse<Location>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter a Number of Working Days:");
            int noOfDays=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter No of days Leave Taken:");
            int noOfLeave=int.Parse(Console.ReadLine());
            PayRole member=new PayRole(employeeName,dateOfJoining,jobRole,gender,jobLocation,noOfDays,noOfLeave);
            System.Console.WriteLine("Your registration Id is:"+member.EmployeeId);
            PayRoleManage.Add(member);
        }
        /// <summary>
        /// Login method is used to Login Exsisting user
        /// </summary>
        public static void Login()
        {
           int loginchoice=0;
           System.Console.WriteLine("Enter your Registered ID: ");
           string id=Console.ReadLine();
            foreach(PayRole search in PayRoleManage)
            {
                if(id==search.EmployeeId)
                {
                    Submenu(id);
                    loginchoice=0;
                }
                else
                {
                    loginchoice=1;
                }
            }
            if(loginchoice==0)
            {
                System.Console.WriteLine("your Entered Id is Invalid");
                System.Console.WriteLine("Do you want to 1.Login\n 2.Register");
                int choice=int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                    {
                        Login();
                        break;
                    }
                    case 2:
                    {
                        Registration();
                        break;
                    }
                }
            }
        
        }
        /// <summary>
        /// submenu shows when the Login enters a Original id
        /// </summary>
        /// <param name="id"></param>
        public static void Submenu(string id)
        {
            string option="yes";
            do{
            System.Console.WriteLine("Youre SuccessFully Loged In");
            System.Console.WriteLine();
            System.Console.WriteLine("*********SUBMENU***********");
            System.Console.WriteLine("1.Calculate Salary \n2.Display Details \nExit");
            int choice=int.Parse(Console.ReadLine());
                    switch(choice)
                    {
                        case 1:
                        {
                            CalculateSalary(id);
                            break;
                        }
                        case 2:
                        {
                            DisplayDetails(id);
                            break;
                        }
                        case 3:
                        {
                            option="no";
                            break;
                        }
                    }
            }while(option=="yes");
        }
        /// <summary>
        /// Calculatesalary is method calculate a indivual member
        /// </summary>
        /// <param name="id"></param>
        public static void CalculateSalary(string id)
        {
          int totalSalary;
          int salary=500;

          foreach(PayRole search in PayRoleManage)
          {
            if(id==search.EmployeeId)
            {
                totalSalary=search.No_Of_Working_Days * salary;
                
                System.Console.WriteLine("your TotalSalay is: "+totalSalary);
            }
          }
        }
        /// <summary>
        /// DisplayDetails is to show a details of indivual member
        /// </summary>
        /// <param name="id"></param>
        public static void DisplayDetails(string id)
        {
           foreach(PayRole search in PayRoleManage) 
           {
              if(id==search.EmployeeId)
              {
                System.Console.WriteLine("|*-----------------------------******************************************YOURDETAILS**************************************************-------------------------------");
                System.Console.WriteLine($"|{search.EmployeeId} | {search.EmployeeName} | {search.DateOfJoining.ToString("dd/MM/yyy")} | {search.Gender} | {search.No_of_Leave_Taken} | {search.No_Of_Working_Days} | {search.TeamName} | {search.WorkLocation} |");
              }
           }
        }
    }
}
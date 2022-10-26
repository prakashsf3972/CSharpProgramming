using System;
using System.Collections.Generic;
namespace BloodBank
{
    public class Operations
    {
        public static List<RegistrationDetails> registersList=new List<RegistrationDetails>();
        public static List<DonationDetails> donatorsList=new List<DonationDetails>();
        public static RegistrationDetails loggedUser=null;

        public static void MainMenu()
        {
            string statement="yes";
            do
            {
            System.Console.WriteLine("-------------------------");
            System.Console.WriteLine("*******MAINMENU**********");
            System.Console.WriteLine("--------------------------");
            System.Console.WriteLine("\t1.Registration\n\t2.Login\n\t3.FetchDonarDetails\n\t4.Exit");
            System.Console.WriteLine("Enter your Choice: ");
            int choice=int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                {
                   UserRegistration();
                    break;
                }
                case 2:
                {
                    Login();
                    break;
                }
                case 3:
                {
                    FetchDonarDetails();
                    break;
                }
                case 4:
                {
                    statement="no";
                    break;
                }
            }
            }while(statement=="yes");
        }
        public static void UserRegistration()
        {
            System.Console.WriteLine("*****************");
            System.Console.WriteLine("REGISTRATION FORM");
            System.Console.WriteLine("******************");
            System.Console.WriteLine("Enter your Name: ");
            string donarName=Console.ReadLine();
            System.Console.WriteLine("Enter your Age: ");
            int age=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Mobile NUmber: ");
            string mobileNumber=Console.ReadLine();
            System.Console.WriteLine("Enter your BLoodGroup: ");
            String bloodGroup=Console.ReadLine();
            System.Console.WriteLine("Enter your Native: ");
            string native=Console.ReadLine();
            
            RegistrationDetails member=new RegistrationDetails(donarName,mobileNumber,bloodGroup,age,native);
            registersList.Add(member);

            System.Console.WriteLine("Your Registration ID is: "+member.DonarID);
            System.Console.WriteLine("__________________________________________");
        }
        public static void DefaultUser()
        {
            RegistrationDetails member1=new RegistrationDetails("Ravichandran","8484848","O_Positive",30,"Theni");
            registersList.Add(member1);
            RegistrationDetails member2=new RegistrationDetails("Baskaran","4747447","AB_Positive",30,"Chennai");
            registersList.Add(member2);

            DonationDetails donar1=new DonationDetails(member1.DonarID,new DateTime(2022,06,10),73,120,14);
            donatorsList.Add(donar1);
            DonationDetails donar2=new DonationDetails(member1.DonarID,new DateTime(2022,10,10),74,120,14);
            donatorsList.Add(donar2);
            DonationDetails donar3=new DonationDetails(member2.DonarID,new DateTime(2022,07,11),74,120,13.6);
            donatorsList.Add(donar3);

        }
        public static void Login()
        {
            System.Console.WriteLine("****LOGIN****");
            System.Console.WriteLine("--------------");
            System.Console.WriteLine("Enter your User ID: ");
            string donarID=Console.ReadLine().ToUpper();
            int valid=0;
            foreach(RegistrationDetails register in registersList)
            {
                if(donarID==register.DonarID)
                {
                    System.Console.WriteLine("you are SuccessFully Login");
                    System.Console.WriteLine("--------------------------");
                    loggedUser=register;
                    SubMenu();
                    valid=1;
                }
                else
                {
                    valid=0;
                }
            }
            if(valid==0)
            {
                System.Console.WriteLine("Invalid UserID Please Enter a Valid Valid UserId");
            }
        }
        public static void SubMenu()
        {
            string statement="yes";
            do
            {
                System.Console.WriteLine("SUBMENU");
                System.Console.WriteLine("-------");
                System.Console.WriteLine("\t1.Donate Blood\n\t2.DonationHistory\n\t3.NextEligibleDate\n\t4.Exit");
                System.Console.WriteLine("Choose Your Option From Submenu: ");
                int choice=int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                    {
                        DonateBlood();
                        break;
                    }
                    case 2:
                    {
                        DonationHistory();
                        break;
                    }
                    case 3:
                    {
                        NextEligibleDate();
                        break;
                    }
                    case 4:
                    {
                        statement="no";
                        break;
                    }
                }


            }while(statement=="yes");
        }
        public static void DonateBlood()
        {
            int count=0;
           System.Console.WriteLine("Enter your Weight: ");
           double weight=double.Parse(Console.ReadLine());
           System.Console.WriteLine("Enter your BloodPressure: ");
           double bloodPressure=double.Parse(Console.ReadLine());
           System.Console.WriteLine("Enter your HbCount: ");
           double hbCount=double.Parse(Console.ReadLine());
            if((weight>=50)&&(bloodPressure<=130)&&hbCount>=13)
            {
                System.Console.WriteLine("Enter your Last Donation if you Donated (yes) either (no): ");
                string statement=Console.ReadLine().ToLower();
                if(statement=="yes")
                {
                    System.Console.WriteLine("Enter your Last DonationID: ");
                    string lastDonationID=Console.ReadLine().ToUpper();
                    foreach(DonationDetails donar in donatorsList)
                    {
                        if(lastDonationID==donar.DonarID)
                        {
                            DateTime lastDonationDate=donar.DonationDate;
                            DateTime eligibility=lastDonationDate.AddDays(60.0);
                            System.Console.WriteLine("Eligible to donate Blood After :"+eligibility.ToString("dd/MM/yyy"));
                            int today=DateTime.Compare(DateTime.Now,eligibility);
                            if(today<0)
                            {
                                System.Console.WriteLine("you are Not Eligible For Blood Donation");
                                count=0;
                                break;
                            }
                            else{
                                count=1;
                            }
                        }
                    }
                    if(count==1)
                    {
                        DonationDetails donator4=new DonationDetails(loggedUser.DonarID,DateTime.Now,weight,bloodPressure,hbCount);
                        donatorsList.Add(donator4);
                        System.Console.WriteLine("blood is Donated");
                        System.Console.WriteLine("your Donation ID is"+donator4.DonarID);
                    }
                    
                }
                else
                {
                    DonationDetails donator=new DonationDetails(loggedUser.DonarID,DateTime.Now,weight,bloodPressure,hbCount);
                    donatorsList.Add(donator);
                    System.Console.WriteLine("blood is Donated");
                    System.Console.WriteLine("your Donation ID is :"+donator.DonarID);
                }
            }
            else
            {
                System.Console.WriteLine("Your are Not Eligible For the Blood Donation");
            }
        }
        public static void DonationHistory()
        {
            System.Console.WriteLine("***DonationHistory***");
            System.Console.WriteLine("|DonarID|\t|DonationDate|\t|Weight|\t|BloodPlessure|\t|HBCount|");
                foreach(DonationDetails donator in donatorsList)
                {
                    if(donator.DonarID==loggedUser.DonarID)
                    {
                        System.Console.WriteLine($"{donator.DonarID}\t{donator.DonationDate.ToString("dd/MM/yyyy")}\t{donator.Weight}\t{donator.BloodPressure}\t{donator.HbCount}");
                    }
                }
        }
        public static void NextEligibleDate()
        {
            int count=0;
            System.Console.WriteLine("****ELIGIBILEDATE****");
            foreach(DonationDetails donar in donatorsList)
            {
                if(donar.DonarID==loggedUser.DonarID)
                {
                    System.Console.WriteLine("Your Last Donation Date is: "+donar.DonationDate.ToString("dd/MM/yyyy"));
                    count++;
                    DateTime lastDonation=donar.DonationDate.AddDays(60.0);
                    int eligiblity=DateTime.Compare(DateTime.Now,lastDonation);
                    if(eligiblity>0)
                    {
                        System.Console.WriteLine("you are Not Eligible to DonateBlood");
                    }
                    else
                    {
                        System.Console.WriteLine("you are Eligible to DonateBlood");
                    }
                }
            }
            System.Console.WriteLine("Blood Count is:"+count);
        }
        public static void FetchDonarDetails()
        {
            System.Console.WriteLine("***FETCHDONARDETAILS***");
            System.Console.WriteLine("Enter a Blood Group to find in the DonarsList: ");
            string bloodGroup=Console.ReadLine();
            System.Console.WriteLine("|DonarName|\t|PhoneNumber|\t|Native|\t|BloodGroup|");
            foreach(RegistrationDetails register in registersList)
            {
                if(bloodGroup==register.BloodGroup)
                {
                    System.Console.WriteLine($"{register.DonarName} \t{register.PhoneNumber} \t{register.Native} \t{register.BloodGroup}");
                }
            }
        }
        
    }
}
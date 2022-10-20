using System;
using System.Collections.Generic;
namespace CollegeAdmission
{
    public static class Operations
    {
        public static StudentDetails loggedUser=null;
        public static AdmissionDetails updated=null;
        public static List<StudentDetails> studentList=new List<StudentDetails>();
        public static List<AdmissionDetails> admissionList=new List<AdmissionDetails>();
        public static List<DepartmentDetails> departMentList=new List<DepartmentDetails>();
        public static void Mainmenu()
        {

            string option="yes";
            do
            {
                    System.Console.WriteLine("************************MAINMENU**************************************");
                    System.Console.WriteLine("1.Registration \n2.Student Login \n3.Exit");
                    System.Console.WriteLine("Enter your Choice: ");
                    int choice=int.Parse(Console.ReadLine());
                    switch(choice)
                    {
                        case 1:
                        {
                            System.Console.WriteLine("*********** Registration *************");
                            Registration();
                            break;
                        }
                        case 2:
                        {
                            System.Console.WriteLine("*********** Student Login ************");
                            StudentLogin();
                            break;
                        }
                        case 3:
                        {

                            System.Console.WriteLine("***************Exiting MainMenu************");
                            option="no";
                             break;
                        }
                    } 
            }while(option=="yes");
        }
        public static void Registration()
        {
           
            System.Console.WriteLine("ENTER YOUR DETAILS IN BELOW FORM");
            System.Console.WriteLine("Enter your Name : ");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter your FatherName :");
            string fatherName=Console.ReadLine();
            System.Console.WriteLine("Enter your Date Of Birth: ");
            DateTime dateOfBirth=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.WriteLine("Enter your Gender: ");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter your Physics Mark : ");
            int physicsMark=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Chemistry Mark :");
            int chemistryMark=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your MathsMark: ");
            int mathsMark=int.Parse(Console.ReadLine());
            StudentDetails student=new StudentDetails(name,fatherName,dateOfBirth,gender,physicsMark,chemistryMark,mathsMark);
            studentList.Add(student);
            System.Console.WriteLine("YOUR REGISTRATION ID IS :"+student.RegisterId);
            System.Console.WriteLine();
            Mainmenu();   
        }
        public static void StudentLogin()

        {
            System.Console.WriteLine("Enter your Registered Id: ");
            string originalId=Console.ReadLine().ToUpper();
            int flag=0;
            foreach(StudentDetails Valid in studentList)
            {
                if(originalId==Valid.RegisterId)
                {
                    flag=1;
                    loggedUser=Valid;
                    SubMenu(loggedUser);
                }
                else
                {
                    flag=0;
                }
            }
            if(flag==0)
            {
                System.Console.WriteLine("your Entered user Id is Incorrect \nPlease Enter Valid Id");
            }
        }

        public static void SubMenu(StudentDetails loggedUser)
        { 
            String comment="yes";
            do{
                System.Console.WriteLine("****************SUBMENU******************");
                System.Console.WriteLine("1.Check Eligiblity \n2.ShowDetails \n3.TakeAdmission \n4.CancelAdmission \n5.ShowAdmissionDetails \n6.Exit");
                System.Console.WriteLine("Enter your Choice : ");
                int selection=int.Parse(Console.ReadLine());
                switch(selection)
                {
                    case 1:
                    {
                        System.Console.WriteLine("*************CHECKELIGILITY**************");
                        bool temp=loggedUser.CheckEligiblity(75.0);
                        if(temp)
                        {
                            System.Console.WriteLine("------------------------------------------------------");
                            System.Console.WriteLine("YOU ARE ELIGIBLE");
                            System.Console.WriteLine("-------------------------------------------------------");
                        }
                        else
                        {
                            System.Console.WriteLine("-------------------------------------------------------");
                            System.Console.WriteLine("YOU ARE NOT ELIGIBLE");
                            System.Console.WriteLine("-------------------------------------------------------");
                        }
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("**************SHOWDETAILS******************");
                        ShowDetails(loggedUser);
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("**************TAKE ADMISSION*****************");
                        TakeAdmission(loggedUser);
                        break;
                    }
                    case 4:
                    {
                         System.Console.WriteLine("*************CANCELADMISSION**************");
                         CancelAdmission(loggedUser);
                         break;
                    }
                    case 5:
                    {
                        ShowAdmissionDetails(loggedUser);
                        break;
                    }
                    case 6:
                    {
                        comment="no";
                        break;
                    }
                }
            }while(comment=="yes");
        }
         public static void ShowDetails(StudentDetails loggedUser)
        {
            System.Console.WriteLine("  \tYOUR DETAILS ARE SHOWN BELOW");
            System.Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            System.Console.WriteLine(" |ADMISSIONID| |STUDENTNAME| |FATHERNAME| |DATEOFBIRTH| |GENDER| |PHYSICSMARK| |CHEMISTRYMARK| |MATHSMARK|");
            System.Console.WriteLine($" \t|{loggedUser.RegisterId}|\t|{loggedUser.StudentName}|\t|{loggedUser.DateOfBirth.ToString("dd/MM/yyyy")}|\t|{loggedUser.Gender}|\t|{loggedUser.PhysicsMark}|\t|{loggedUser.ChemistryMark}|\t|{loggedUser.MathsMark}|");
            System.Console.WriteLine("-------------------------------------------------------------------------------------------------------");
        }
        public static void ShowAdmissionDetails(StudentDetails loggedUser)
        {
        int temp=0;
                foreach(AdmissionDetails details in admissionList)
                {
                    
                    if(details.StudentId==loggedUser.RegisterId)
                    {
                    temp=1;
                    System.Console.WriteLine("|******************************ADMISSIONDETAILS*******************************************|");
                    System.Console.WriteLine("  \t|STUDENT DEPARTMENTID| \t|STUDENT ADMISSIONDATE| \t|STUDENT STATUS|");
                    System.Console.WriteLine($" \t{details.DepartmentId} \t{details.AdmissionDate} \t{details.AdmissionStatus}");
                    System.Console.WriteLine("|*******************************************************************************************|");
                  
                    }
                }
         if(temp==0)
            {
                System.Console.WriteLine("Student is Not Taken Admission");
            }
        System.Console.WriteLine();


        }
    public static void DefaultData()
    {
        StudentDetails student1=new StudentDetails("Prakash","kannan",new DateTime(2001,04,07),Gender.Male,75,80,90);
        studentList.Add(student1);
        StudentDetails student2=new StudentDetails("Abi","Palanisamy",new DateTime(2001,08,08),Gender.Male,80,90,100);
        studentList.Add(student2);

        
        DepartmentDetails department1=new DepartmentDetails("EEE",29);
        departMentList.Add(department1);
        DepartmentDetails department2=new DepartmentDetails("CSE",30);
        departMentList.Add(department2);
        DepartmentDetails department3=new DepartmentDetails("MECH",40);
        departMentList.Add(department3);
        DepartmentDetails department4=new DepartmentDetails("ECE",10);
        departMentList.Add(department4);

        AdmissionDetails admin1=new AdmissionDetails(student1.RegisterId,department1.DepartmentId,new DateTime(2000,11,12),AdmissionStatus.Admitted);
        admissionList.Add(admin1);
        AdmissionDetails admin2=new AdmissionDetails(student2.RegisterId,department2.DepartmentId,new DateTime(2000,08,12),AdmissionStatus.Cancelled);
        admissionList.Add(admin2);

    }
    public static void TakeAdmission(StudentDetails loggedUser)
    {
        System.Console.WriteLine("|-------------------------------------------------------------------------------|");
        System.Console.WriteLine("|DEPARTMENT ID|\t|DEPARTMENTNAME|\t|DEPARTMENTSEAT|");
        foreach(DepartmentDetails details in departMentList)
        {
            System.Console.WriteLine($"|{details.DepartmentId}| \t|{details.DepartName}| |\t{details.NumberOfSeats}|");
            System.Console.WriteLine("|------------------------------------------------------------------------------|");
        }
        System.Console.WriteLine("Enter your Id: ");
        string departmentUserId=Console.ReadLine().ToUpper();
        int temp=0;
        foreach(DepartmentDetails department in departMentList)        
        {
            if(department.DepartmentId==departmentUserId)
            {
                temp=0;
                System.Console.WriteLine("Department is Available");
                if(loggedUser.CheckEligiblity(75.0))
                {
                    System.Console.WriteLine("You are Eligible");
                    if(department.NumberOfSeats>0)
                    {
                        System.Console.WriteLine("Seats Are Available");
                        int flag=0;
                        foreach(AdmissionDetails admission in admissionList)
                        {
                            if(admission.StudentId==loggedUser.RegisterId && admission.AdmissionStatus==AdmissionStatus.Admitted)
                            {
                                flag=1;
                                System.Console.WriteLine("you are already Booked");
                            }
                        }
                        if(flag==0)
                        {
                            AdmissionDetails student=new AdmissionDetails(loggedUser.RegisterId,department.DepartmentId,DateTime.Now,AdmissionStatus.Admitted);
                            admissionList.Add(student);
                            System.Console.WriteLine("your Admission id is "+student.AdmissionId);
                            department.NumberOfSeats--;
                        }
                        break;

                    } 
                    else
                    {
                        System.Console.WriteLine("Seats are Not Available");
                    }  
                }
                else{
                    System.Console.WriteLine("you are not Eligible");
                }
                break;

            }
            else
            {
                temp=1;
            }
        
        }
        if(temp==1)
            {
                System.Console.WriteLine("Department is Not Available");
            }

    
    }
    public static void CancelAdmission(StudentDetails loggedUser)
    {
        int flag=0;
        foreach(AdmissionDetails admission in admissionList)
        {
            
            if(admission.StudentId==loggedUser.RegisterId && admission.AdmissionStatus==AdmissionStatus.Admitted)
            {
                admission.AdmissionStatus=AdmissionStatus.Cancelled;
                System.Console.WriteLine("your seat is cancelled");
            
                foreach(DepartmentDetails department in departMentList)
                {
                    if(department.DepartmentId==admission.DepartmentId)
                    {
                        department.NumberOfSeats++;
                    }
                }
                flag=0;
                break;
            }
            else{
                flag=1;
            }
        }
        if(flag==1)
        {
            System.Console.WriteLine("you have not taken admission");
        }

    }
}

}
  
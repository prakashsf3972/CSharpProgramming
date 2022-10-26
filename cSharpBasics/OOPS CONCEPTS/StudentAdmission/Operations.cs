using System;
using System.Collections.Generic;
namespace StudentAdmission
{
    
    public static class Operations
    {
        
     public static void Mainmenu()
     {
        
      List<StudentDetails> studentList=new List<StudentDetails>();
      List<StudentDetails> eligibleList=new List<StudentDetails>();
      string statement="";
            do{
                    System.Console.WriteLine("Enter your name :");
                    string name=(Console.ReadLine());

                    System.Console.WriteLine("Enter your Fathers Name :");
                    string fatherName=(Console.ReadLine());

                    System.Console.WriteLine("Select Gender options:Male,Female,TransGender");
                    Gender gender=Enum.Parse<Gender>(Console.ReadLine().ToLower(),true);

                    System.Console.WriteLine("Enter a Date of Birth:(dd/mm/yyyy");
                    DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

                    System.Console.WriteLine("Enter your mailid :");
                    string mailid=(Console.ReadLine());

                    System.Console.WriteLine("Enter your marks: \n 1.Physics \n 2.Chemistry \n 3.Maths");
                    int chemistryMarks=(int.Parse(Console.ReadLine()));
                    int physicsMarks=(int.Parse(Console.ReadLine()));
                    int mathsMarks=(int.Parse(Console.ReadLine()));
                    StudentDetails student=new StudentDetails(name,fatherName,gender,mailid,physicsMarks,chemistryMarks,mathsMarks);
                    System.Console.WriteLine("Your Registration id is"+student.RegisterID);
                    studentList.Add(student);
                    System.Console.WriteLine("Do you want to continue(yes/no):");
                    statement=Console.ReadLine();
                }while(statement=="yes");
                System.Console.WriteLine("Enter your Id:");
                string RegisterID=Console.ReadLine().ToUpper();

                foreach(StudentDetails student in studentList)
                {
                  if(student.RegisterID==RegisterID)
                  {
                    System.Console.WriteLine("user found");
                    ShowDetails(student);
                    bool eligibility=student.CheckEligibility(75.0);
                    {
                        if(eligibility)
                        {
                            System.Console.WriteLine("You are Eligible");
                        }
                        else{
                            System.Console.WriteLine("you are not Eligible");
                        }
                    }
                  }
                }
            
           void ShowDetails(StudentDetails student)
           {
            System.Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            System.Console.WriteLine("|STUDENT ID| |STUDENT NAME| |FATHER NAME| |GENDER| |D.O.B| |MAILID| |CHEMISTRYMARK| |PHYSICSMARK| |MATHSMARK|");
            System.Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            foreach(StudentDetails eligiblestudent in studentList)
            {
                System.Console.WriteLine("-----------------------------------------------------------------------------------------------------");
                System.Console.WriteLine($"{eligiblestudent.RegisterID} | {eligiblestudent.StudentName} | {eligiblestudent.FatherName} | {eligiblestudent.Dob} | {eligiblestudent.StudentGender} | {eligiblestudent.ChemistryMark} | {eligiblestudent.PhysicsMark} | {eligiblestudent.MathsMark}"); 
            }
           } 
            
           }

    }
}


    




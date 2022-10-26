using System;
using System.Collections.Generic;
namespace HierarchicalInheritance;
class Program{

    public static void Main(string[] args)
    {
        PersonDetails person=new PersonDetails("Prakash","Kannan",9842986818,Gender.Male);

        person.ShowDetails();
        StudentDetails student =new StudentDetails(person.AID,person.UserName,person.FatherName,person.PhoneNumber,person.Gender,Department.Mechanical,"2002");
    
        student.ShowStudent();
    }
}

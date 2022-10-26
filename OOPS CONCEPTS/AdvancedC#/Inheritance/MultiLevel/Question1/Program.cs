using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo person=new PersonalInfo("Prakash","Kannan","1234567890","prak@4989",new DateTime(2001,04,07),Gender.Male);
        person.ShowPersonalInfo();

        StudentsInfo student=new StudentsInfo("Gowtham","Kannan","1234567890","qwer1234",new DateTime(1998,12,28),Gender.Male,1518105091,10,"MECHANICAL",2022);
        student.ShowStudentInfo();

        HscDetails detail=new HscDetails("prakash","kannan","1234567890","qwe123",new DateTime(2000,12,27),Gender.Male,1518105091,10,"Mechanical",2022,0987654321,75,85,96,300,80);
        detail.ShowHseDetails();

        
    }
}

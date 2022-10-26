using System;
namespace Question1
{
    public class StudentsInfo:PersonalInfo
    {
        public int RegisterNumber { get; set; }
        public int Standard { get; set; }
        public string Branch { get; set; }
        public int AcadamicYear { get; set; }

        public StudentsInfo(string name,string fatherName,string phoneNumber,string mailID,DateTime dateOfBirth,Gender gender,int registerNumber,int standard,string branch,int academicYear): base(name,fatherName,phoneNumber,mailID, dateOfBirth, gender)
        {
            RegisterNumber=registerNumber;
            Standard=standard;
            Branch=branch;
            AcadamicYear=academicYear;
        }
        public void ShowStudentInfo()
        {
            System.Console.WriteLine("RegisterNumber:"+RegisterNumber);
            System.Console.WriteLine("Standard :"+Standard);
            System.Console.WriteLine("Branch: "+Branch);
            System.Console.WriteLine("AcadamicYear:"+AcadamicYear);
            System.Console.WriteLine("---------------------------");
        }
    }
}
using System;
namespace MultipleInheritance
{
    public class EmployementDetails: StudentDetails
    {
        private static int s_employmentId=1000;
        public string EmployMentId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public EmployementDetails(string studentId,string aid,string name,string fatherName,long phoneNumber,Gender gender,Department department) : base(studentId,aid,name,fatherName,phoneNumber,gender,department)
        {
            s_employmentId++;
            EmployMentId="EID"+s_employmentId;
            RegistrationDate=DateTime.Now;
        }
        public void showEmployement()
        {
            System.Console.WriteLine("EmployeMent Id is :"+EmployMentId);
            ShowStudent();
            System.Console.WriteLine("Registration Date :"+RegistrationDate.ToString("dd/MM/yyyy"));

        }

    }
}
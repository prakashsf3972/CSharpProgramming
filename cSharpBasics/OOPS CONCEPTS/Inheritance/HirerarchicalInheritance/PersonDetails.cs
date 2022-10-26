using System;
namespace HirerarchicalInheritance
{
    public enum Gender {Default,Male,Female,Transgender}
    public class PersonDetails
    {
        private static int a_aid=1000;
        public string AID { get; set; }
        public string  UserName { get; set; }
        public string  FatherName { get; set; }
        public long PhoneNumber { get; set; }
        public Gender Gender { get; set; }
        
        public PersonDetails(string name,string fatherName,long phoneNumber,Gender gender)
        {
            a_aid++;
            AID="AID"+a_aid++;
            UserName=name;
            FatherName=fatherName;
            PhoneNumber=phoneNumber;
            Gender=gender;
        }
        public PersonDetails(string aid,string name,string fatherName,long phoneNumber,Gender gender)
        {
            AID=aid;
            UserName=name;
            FatherName=fatherName;
            PhoneNumber=phoneNumber;
            Gender=gender;
        }
        


        public void ShowDetails()
        {
            System.Console.WriteLine("Your Id id is  :"+AID);
            System.Console.WriteLine("Your Name      : "+UserName);
            System.Console.WriteLine("Your FatherName:"+FatherName);
            System.Console.WriteLine("your PhoneNumber:"+PhoneNumber);
            System.Console.WriteLine("your Gender     :"+Gender);
        }
    }
}
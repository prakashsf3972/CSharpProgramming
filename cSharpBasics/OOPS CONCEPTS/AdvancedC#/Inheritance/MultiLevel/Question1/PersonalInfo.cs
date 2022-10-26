using System;
namespace Question1
{
    public enum Gender {Default,Male,Female,TransGender}
    public class PersonalInfo
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string PhoneNumber { get; set; }
        public string MailID { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }

        public PersonalInfo(string name,string fatherName,string phoneNumber,string mailID,DateTime dateOfBirth,Gender gender)
        {
            Name=name;
            FatherName=fatherName;
            PhoneNumber=phoneNumber;
            MailID=mailID;
            DateOfBirth=dateOfBirth;
            Gender=gender;
        }

        public  void ShowPersonalInfo()
        {
            System.Console.WriteLine("Name :"+Name);
            System.Console.WriteLine("FatherName:"+FatherName);
            System.Console.WriteLine("PhoneNumber:"+PhoneNumber);
            System.Console.WriteLine("MailID:"+MailID);
            System.Console.WriteLine("DateaOfBirth"+DateOfBirth.ToString("dd/MM/yyyy"));
            System.Console.WriteLine("Gender"+Gender);
            System.Console.WriteLine("-------------------------------------------------");

        }
 
    }
}
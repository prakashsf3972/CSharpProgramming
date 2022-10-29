using System;
namespace GroceryApplication
{
    public enum Gender {Default,Male,Female,TransGender}
    public class PersonalDetails
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public long PhoneNumber { get; set; }
        public DateTime DateOFBirth { get; set; }
        public string MailID { get; set; }
        public PersonalDetails()
        {
            
        }

        public PersonalDetails(string name,string fatherName,Gender gender,long phoneNumber,DateTime dateOfBirth,string mailID)
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            PhoneNumber=phoneNumber;
            DateOFBirth=dateOfBirth;
            MailID=mailID;
        }
    }
}
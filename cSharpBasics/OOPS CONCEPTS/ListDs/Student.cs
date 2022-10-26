using System;
namespace ListDs
{
    public enum Gender {Default,Male,Female,TransGender}
    public class Student
    {
        public string Name {get;set;}
        public string  FatherName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
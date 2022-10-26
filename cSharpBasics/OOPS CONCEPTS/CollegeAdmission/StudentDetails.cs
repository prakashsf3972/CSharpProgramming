using System;
namespace CollegeAdmission
{
    public enum Gender {Default,Male,Female,Transgender}
    public class StudentDetails
    {
        private static int s_registerId=3000;
        public string RegisterId { get; set; }
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender  { get; set; }
        public int  PhysicsMark { get; set; }
        public int ChemistryMark { get; set; }
        public int MathsMark { get; set; }

        public StudentDetails(string name,string fatherName,DateTime dateOfBirth,Gender gender,int physicsMark,int chemistryMark,int mathsMark)
        {
            s_registerId++;
            RegisterId="SF"+s_registerId;
            StudentName=name;
            FatherName=fatherName;
            DateOfBirth=dateOfBirth;
            Gender=gender;
            PhysicsMark=physicsMark;
            ChemistryMark=chemistryMark;
            MathsMark=mathsMark;
        }
        public StudentDetails(string data)
        {
            string[] values=data.Split(',');
            s_registerId=int.Parse(values[0].Remove(0,2));
            RegisterId=values[0];
            StudentName=values[1];
            FatherName=values[2];
            DateOfBirth=DateTime.ParseExact(values[3],"dd/MM/yyyy",null);
            Gender=Enum.Parse<Gender>(values[4]);
            PhysicsMark=int.Parse(values[5]);
            ChemistryMark=int.Parse(values[6]);
            MathsMark=int.Parse(values[7]);
        }
        public bool CheckEligiblity(double cutoff)
        {
        double average=(PhysicsMark+ChemistryMark+MathsMark)/3;

            if(average>=cutoff)
            {
               return true;
            }
            else
            {
                return false;
            }
        }

       
    }
}
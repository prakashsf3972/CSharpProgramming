using System;
namespace Question1
{
    public class HscDetails:StudentsInfo
    {
        public int HscMarkSheetNumber { get; set; }
        public int PhysicsMark { get; set; }
        public int ChemistryMark { get; set; }
        public int MathsMark { get; set; }
        public double Total { get; set; }
        public double Percentage { get; set; }

        public HscDetails(string name,string fatherName,string phoneNumber,string mailID,DateTime dateOfBirth,Gender gender,int registerNumber,int standard,string branch,int academicYear,int hscMarkSheetNumber,int physicsMark,int chemistryMark,int mathsMark,double total,double percentage): base(name,fatherName,phoneNumber,mailID,dateOfBirth,gender,registerNumber,standard,branch,academicYear)
        {
            HscMarkSheetNumber=hscMarkSheetNumber;
            PhysicsMark=physicsMark;
            ChemistryMark=chemistryMark;
            MathsMark=mathsMark;
            Total=total;
            Percentage=percentage;
        }
        public void ShowHseDetails()
        {
            ShowPersonalInfo();
            ShowStudentInfo();
            System.Console.WriteLine("HSCmarkSheetNumber: "+HscMarkSheetNumber);
            System.Console.WriteLine("PhysicsMark:"+PhysicsMark);
            System.Console.WriteLine("ChemistryMark:"+ChemistryMark);
            System.Console.WriteLine("MathsMark:"+MathsMark);
            System.Console.WriteLine("Total: "+Total);
            System.Console.WriteLine("Percentage: "+Percentage);

        }
     
  
    }
}
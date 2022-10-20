namespace   MultipleInheritance
{
    public enum Department {Default,Mechanical,Eee,Ece}
    public class StudentDetails:PersonDetails
    {
        private static int s_studentID=1000;
        public string StudentId { get; set; }
        public Department DepartMent { get; set; }
        public string  Year { get; set; }


         int Physics { get; set; } //property
         int Chemistry { get; set; }
         int Maths { get; set; }
         int Total { get; set; }
         int Average { get; set; }

         public void GetMark(int physics,int chemistry,int maths)
         {
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
         }
         public void Calculate()
         {
            Total=Physics+Chemistry+Maths;
            Average=(double)Total/3.0;
         }
         public void ShowMark()
         {
            System.Console.WriteLine($"PHYSICS MARK: {Physics} CHEMISTRYMARK: {Chemistry} MATHSMARK {Maths}");
         }
        public StudentDetails(string aid,string name,string fatherName,long phoneNumber,Gender gender,Department departMent,string year):base(aid,name,fatherName,phoneNumber,gender)
        {
            s_studentID++;
            StudentId="SF"+s_studentID;
            DepartMent=departMent;
            Year=year;
        }

         public StudentDetails(string studentId,string aid,string name,string fatherName,long phoneNumber,Gender gender,Department departMent):base(aid,name,fatherName,phoneNumber,gender)
        {
            StudentId=studentId;
            DepartMent=departMent;
            
        }


        public void ShowStudent()
        {
            System.Console.WriteLine($" STUDENTID :{StudentId} ");
            ShowDetails();
            System.Console.WriteLine($"DEPARTMENT:{DepartMent} YEAR :{Year}");
        }

       
    }
}
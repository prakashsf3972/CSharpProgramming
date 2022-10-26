///<summary
/// used to process the college admission using this application
/// </summary>
using System;
namespace StudentAdmission
   /// <summary>
    /// used to select a student's gender information
    /// </summary>
{
    public enum Gender {Default,Male,Female,Transgender}
 /// <summary>
 /// class <see crefs="students info"/> used to collect students details for the admission process
 /// </summary>
    internal class StudentDetails
    {
        ///Field
        /// <summary>
        /// static field used to auto increment and it uniquely identify an instance of
        /// <see crefs="studentsdetails"/>class
        
        private static int s_registerID=3000;
        /// <summary>
        /// property RegisterNumber used to uniquely identify a <see crafts="Students"/> class's object
        /// </summary>
        /// <value></value>
        public string RegisterID{get;}
        /// <summary>
        /// property Registernumber used to uniquely identify a <see cratfs="students"/> class's object
        /// </summary>
        /// <value></value>
        public string StudentName{ get; set;  }
        /// <summary>
        /// property studentName used to uniquely identify a <see cratfs="students"/> class's object
        /// </summary>
        /// <value></value>

        public string FatherName{ get; set; }
        /// <summary>
        /// property FatherName used to uniquely identify a he/she fatherName <see cratfs="students"/> class's object
        /// </summary>
        /// <value></value>
        public Gender StudentGender{ get; set; }
        /// <summary>
        /// property StudentGender used to uniquely identify a he/she Gender <see cratfs="students"/> class's object
        /// </summary>
        /// <value></value>
        public DateTime Dob  { get; set; }
        /// <summary>
        /// property Dateofbirth used to uniquely identify a bithdate,moth and year <see cratfs="students"/> class's object
        /// </summary>
        /// <value></value>
        public string Mailid { get; set; }
        /// <summary>
        /// property mailid used to receive a update mail<see cratfs="students"/> class's object
        /// </summary>
        /// <value></value>
        public  int PhysicsMark { get; set; }
        /// <summary>
        /// property PhysicsMark used to uniquely  a indivual mark<see cratfs="students"/> class's object
        /// </summary>
        /// <value></value>
        public int ChemistryMark { get; set; }
        /// <summary>
        /// property ChemistryMark used to identify a indivual mark<see cratfs="students"/> class's object
        /// </summary>
        /// <value></value>
        public int MathsMark { get; set; }
        /// <summary>
        /// property Mathsmark used to identify a indivual mark<see cratfs="students"/> class's object
        /// </summary>
        /// <value></value>
        
         ///<summary>
    /// Constructor of <see cref ="studentDetails"/> class used to initilize values to its properties
    /// <summary>
    /// <sparm name="name">Parameter name used to initilize a student's name to name property</param>
    /// <sparm name="Fathername">Parameter name used to initilize a Fathername to name property</param>
    /// <sparm name="StudentsGender>parameter name used to initilize a gender to name</param>
   /// <sparm name="mailid">parameter name used to initilize a mailid of a person</param>
   /// <sparm name="physicsmarks">parameter name used to initilize a marks of a person</param>
  /// <sparm name="chemistrymarks">parameter name used to initilize a mark of a person</param>
  /// /// <sparm name="mathsmark">parameter name used to initilize a mark of a person</param>
    public StudentDetails()
    {
   
        RegisterID="your Id";
        StudentName="your name";
        FatherName="your father name";
        StudentGender=Gender.Default;
        Mailid="Enter your mailid";
        PhysicsMark=0;
        ChemistryMark=0;
        MathsMark=0;

    }

    public StudentDetails(string name,string fatherName,Gender gender,string mailid,int chemistryMark,int physicsMark,int mathsMark)
    {
        s_registerID++;
        RegisterID ="SF"+s_registerID;
        StudentName=name;
        FatherName=fatherName;
        StudentGender=gender;
        Mailid=mailid;
        ChemistryMark=chemistryMark;
        PhysicsMark=physicsMark;
        MathsMark=mathsMark;
    }
    ~StudentDetails()
    {
        System.Console.WriteLine("The Application is Closed");
    }
    /// <summary>
    /// method check eligibility  get cutoff value as a parameter and checks the eligibility of student
    /// it cutoff is lesss or equal then student is eligible and will return true else false
    /// </summary>
    /// <param name="cutoff"></param>
    /// <returns></returns>
 public bool CheckEligibility(double cutoff)
    {
        double average=(double)(PhysicsMark+ChemistryMark+MathsMark)/3;
        if(average>=cutoff)
        {
            return true;
        }
        else{
            return false;
        }
    }

    }
}

    
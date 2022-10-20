using System;
namespace PayRoleApplication
{
    /// <summary>
    /// used to select a student's gender information
    /// </summary>
    public enum Gender {Default,Male,Female,TransGender}
     /// <summary>
    /// used to select a location information
    /// </summary>
     public enum Location {Default,Chennai,Madurai,Coimbatore,karaikudi}
    public  class PayRole
    {
         ///Field
        /// <summary>
        /// static field used to auto increment and it uniquely identify an instance of
        /// <see crefs="studentsdetails"/>class
     private static int s_EmployeeId=3000;
     /// <summary>
        /// property RegisterNumber used to uniquely identify a <see crafts="Employee"/> class's object
        /// </summary>
        /// <value></value>
     public string EmployeeId { get;  } 
     /// <summary>
        /// property EmployeeName used to uniquely identify a <see crafts="Employee"/> class's object
        /// </summary>
        /// <value></value>
     public string EmployeeName { get; set; }
     /// <summary>
        /// property JobRole used to uniquely identify a <see crafts="Employee"/> class's object
        /// </summary>
        /// <value></value>
     public string JobRole { get; set; }
     /// <summary>
        /// property WorkLocation used to uniquely identify a <see crafts="Employee"/> class's object
        /// </summary>
        /// <value></value>
     public Location WorkLocation{ get; set; }
     /// <summary>
     /// Gender is used to identify a indivual Person gender
     /// </summary>
     /// <value></value>
     public Gender Gender { get; set; }
     /// <summary>
     /// TeamName is used to Identify the TeamName
     /// </summary>
     /// <value></value>
     public string  TeamName { get; set; }
     /// <summary>
     /// DateOfJoining is used to show joiningdate
     /// </summary>
     /// <value></value>
     public  DateTime DateOfJoining { get; set; }
     /// <summary>
     /// Its shows no of Working days
     /// </summary>
     /// <value></value>
     public int No_Of_Working_Days { get; set; }
     /// <summary>
     /// Number of Working days is shown
     /// </summary>
     /// <value></value>
     public int No_of_Leave_Taken { get; set; }

    
       ///<summary>
       /// Constructor of <see cref ="PayRole"/> class used to initilize values to its properties
    /// <summary>
    /// <sparm name="name">Parameter name used to initilize a student's name to name property</param>
    /// <sparm name="Jobrole">Parameter name used to initilize a jobrole to name property</param>
    /// <sparm name="StudentsGender>parameter name used to initilize a gender to name</param>
   /// <sparm name="TeamName">parameter name used to initilize a TeamName of a person</param>
////// ///  <sparm name="dateof joining">parameter name used to initilize a dateofjoining of a person</param>
  /// <sparm name="no_of working days">parameter name used to initilize a no of working days of a person</param>
  /// /// <sparm name="no of Leave Taken">parameter name used to initilize a no of leave taken of a person</param>
     public PayRole(string employeeName,DateTime dateOfJoining,string jobRole,Gender gender,Location jobLocation,int noOfDays,int noOfLeave)
     {
        s_EmployeeId++;
        EmployeeId="SF"+s_EmployeeId;
        EmployeeName=employeeName;
        JobRole=jobRole;
        Gender=gender;
        WorkLocation=jobLocation;
        No_Of_Working_Days=noOfDays;
        No_of_Leave_Taken=noOfLeave;
     }

    }

}
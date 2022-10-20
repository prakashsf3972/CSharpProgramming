using System;
using System.Collections.Generic;
namespace BankAccountOpening
{
    public enum Gender {Default,Male,Female,TransGender}
    public class BankDetails
    {
       ///Field
        /// <summary>
        /// static field used to auto increment and it uniquely identify an instance of
        /// <see crefs="studentsdetails"/>class
        
       private static int s_customerId =1000;
       /// <summary>
        /// property Registernumber used to uniquely identify a <see cratfs="students"/> class's object
        /// </summary>
        /// <value></value>
       public string CustomerId { get;  }
       /// <summary>
        /// property CustomerName used to uniquely identify a <see cratfs="students"/> class's object
        /// </summary>
        /// <value></value>

       public string CustomerName { get; set; }
       /// <summary>
        /// property Balance used to uniquely identify a <see cratfs="students"/> class's object
        /// </summary>
        /// <value></value>

       public double Balance{ get; set; }
       /// <summary>
        /// property GENDER used to uniquely identify a<see cratfs="students"/> class's object
        /// </summary>
        /// <value></value>

       public Gender Gender { get; set; }
       /// <summary>
        /// property PhoneNumber used to uniquely identify a <see cratfs="students"/> class's object
        /// </summary>
        /// <value></value>

       public long PhoneNumber  { get; set; }
       /// <summary>
        /// property Mailid used to uniquely identify a <see cratfs="students"/> class's object
        /// </summary>
        /// <value></value>

       public string MailId { get; set; }
       /// <summary>
        /// property DateOfBirth used to uniquely identify a <see cratfs="students"/> class's object
        /// </summary>
        /// <value></value>

       public DateTime DateOfBirth { get; set; }

         /// Constructor of <see cref ="BankDetails"/> class used to initilize values to its properties
    /// <summary>
    /// <sparm name="name">Parameter name used to initilize a student's name to name property</param>
    /// <sparm name="Fathername">Parameter name used to initilize a Fathername to name property</param>
    /// <sparm name="StudentsGender>parameter name used to initilize a gender to name</param>
   /// <sparm name="mailid">parameter name used to initilize a mailid of a person</param>
   /// <sparm name="physicsmarks">parameter name used to initilize a marks of a person</param>
  /// <sparm name="chemistrymarks">parameter name used to initilize a mark of a person</param>
  /// /// <sparm name="mathsmark">parameter name used to initilize a mark of a person</param>

       public BankDetails(string name,Gender gender,long phoneNumber,string mailId,DateTime dateOfBirth)
       {
        s_customerId++;
        CustomerId="HDFC"+s_customerId;
        Gender=gender;
        PhoneNumber=phoneNumber;
        MailId=mailId;
        DateOfBirth=dateOfBirth;

       }
    }
}
///<summary
/// used to process the Ebbill Details using this application
/// </summary>
using System;
namespace EbBill;

    public class EbBillDetails
    {
        //Field
        /// <summary>
        /// static field used to auto increment and it uniquely identify an instance of
        /// <see crefs="Ebbilldetails"/>class
        private static int s_meterId=1000;
        /// <summary>
        /// meterId is a property to identify a indivual id
        /// </summary>
        /// <value></value>
        public string MeterId { get; set; }
         /// <summary>
        /// username is a property to identify a name indivual 
        /// </summary>
        /// <value></value>
        public string UserName { get; set; }
         /// <summary>
        /// PhoneNumber is a property to identify indivual number
        /// </summary>
        /// <value></value>
        public  double  PhoneNumber { get; set; }
        /// <summary>
        /// mailid is a Property to identify indivual mailid
        /// </summary>
        /// <value></value>
        public string MailId { get; set; }
        /// <summary>
        /// unitUsed is a property to calculate a amount
        /// </summary>
        /// <value></value>
        public double UnitUsed { get; set; }


             ///<summary>
    /// Constructor of <see cref ="ebBillDetails"/> class used to initilize values to its properties
    /// <summary>
    /// <sparm name="name">Parameter name used to initilize a student's name to name property</param>
    /// <sparm name="Fathername">Parameter name used to initilize a Fathername to name property</param>
    /// <sparm name="StudentsGender>parameter name used to initilize a gender to name</param>
   /// <sparm name="mailid">parameter name used to initilize a mailid of a person</param>
   /// <sparm name="physicsmarks">parameter name used to initilize a marks of a person</param>
  /// <sparm name="chemistrymarks">parameter name used to initilize a mark of a person</param>
  /// /// <sparm name="mathsmark">parameter name used to initilize a mark of a person</param>
   
        public EbBillDetails(string userName,double phoneNumber,string mailId,double unitsUsed )
        {
            s_meterId++;
            MeterId="EB"+s_meterId;
            UserName=userName;
            PhoneNumber=phoneNumber;
            MailId=mailId;
            UnitUsed=unitsUsed;
        }
    }


namespace CafeteriaCard
{
    /// <summary>
    /// Enumunator Gender Contains a List of Valid Gender
    /// </summary>
    public enum Gender {Default,Male,Female,TransGender}
    public class PersonalDetails
    {
        /// <summary>
        /// Property Name is used to provide unique Name to every user
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Property FatherName is used to provide unique FatherName to every user
        /// </summary>
        /// <value></value>
        public string FatherName { get; set; }
        /// <summary>
        /// Property Gender is used to provide unique Gender to every user
        /// </summary>
        /// <value></value>
        public Gender Gender { get; set; }
        /// <summary>
        /// Property MobileNumber is used to provide unique MobileNumber to every user
        /// </summary>
        /// <value></value>
        public long MobileNumber { get; set; }
        /// <summary>
        /// Property MailID is used to provide unique MailID to every user
        /// </summary>
        /// <value></value>
        public string MailID { get; set; }
        /// <summary>
        /// Default Constructor
        /// </summary>
        public PersonalDetails()
        {
            
        }
        /// <summary>
        /// Constructor is used to collect the details of PersonDetails
        /// </summary>
        /// <param name="name"></param>
        /// <param name="fatherName"></param>
        /// <param name="gender"></param>
        /// <param name="mobileNumber"></param>
        /// <param name="mailID"></param>
        public PersonalDetails(string name,string fatherName,Gender gender,long mobileNumber,string mailID)
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            MobileNumber=mobileNumber;
            MailID=mailID;
        }
    }
}
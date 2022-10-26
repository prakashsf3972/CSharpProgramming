namespace BloodBank
{
    public class RegistrationDetails
    {
       private static int s_donarID=1000;
       public string  DonarID { get; }
       public string DonarName { get; set; }
       public string PhoneNumber { get; set; }
       public string BloodGroup { get; set; }
       public int Age { get; set; }
       public string Native { get; set; }

       public RegistrationDetails(string donarName,string phoneNumber,string bloodGroup,int age,string native)
       {
        s_donarID++;
        DonarID="UID"+s_donarID;
        DonarName=donarName;
        PhoneNumber=phoneNumber;
        BloodGroup=bloodGroup;
        Age=age;
        Native=native;
       }
    }
}
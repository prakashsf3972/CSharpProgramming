namespace OnlineMedicalStore
{
    public class UserDetails
    {
        private static int s_userId=1000;
        public string  UserId { get;  }
        public string  UserName { get; set; }
        public int UserAge { get; set; }
        public string  UserCity { get; set; }
        public double PhoneNumber { get; set; }
        public double  Balance { get; set; }


        public UserDetails(string userName,int userAge,string city,double phoneNumber,double balance)
        {
            s_userId++;
            UserId="UID"+s_userId;
            UserName=userName;
            UserAge=userAge;
            UserCity=city;
            PhoneNumber=phoneNumber;
            Balance=balance;

        }
    }
}
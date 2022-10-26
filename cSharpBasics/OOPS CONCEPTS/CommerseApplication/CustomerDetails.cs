namespace CommerseApplication
{
    public enum Gender {Default,Male,Female,Transgender}
    public class CustomerDetails
    {
        private static int s_customerId=1000;

        public string CustomerId { get;  }
        public string CustomerName{ get; set; }
        public string CityName{ get; set; }
        public Gender Gender { get; set; }
        public long PhoneNumber{ get; set; }
        public string MailID { get; set; }
        public int Initial_wallet_Balance { get; set; }

        
        public CustomerDetails(string customerName,string cityName,Gender gender,long phoneNumber,int initial_Wallet_Balance,string mailId)
        {
            s_customerId++;
            CustomerId="CID"+s_customerId;
            CustomerName=customerName;
            CityName=cityName;
            Gender=gender;
            PhoneNumber=phoneNumber;
            MailID=mailId;
           Initial_wallet_Balance=initial_Wallet_Balance;

        }

    }
    

    
}
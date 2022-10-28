namespace BlackTicket
{
    public class UserDetails : PersonalDetails,IBalance
    {
        private static int s_userID=1000;
        public string UserID { get; }
        private double _walletBalance;
        public double WalletBalance { get {return _walletBalance;} }
        
        public UserDetails(string name,int age,long phoneNumber,double walletBalance):base(name,age,phoneNumber)
        {
            s_userID++;
            UserID="UID"+s_userID;
            _walletBalance=walletBalance;
        }
        public void RechargeWallet(double amount)
        {
            _walletBalance+=amount;
        }
        public void Deduct(double amount)
        {
            _walletBalance-=amount;
        }
        public void AddAmount(double addAmount)
        {
            _walletBalance+=addAmount;
        }
        public UserDetails(string data)
        {
            string[] values=data.Split(',');
            s_userID=int.Parse(values[0].Remove(0,3));
            UserID=values[0];
            Name=values[1];
            Age=int.Parse(values[2]);
            PhoneNumber=long.Parse(values[3]);
            _walletBalance=double.Parse(values[4]);
        }
    }
}
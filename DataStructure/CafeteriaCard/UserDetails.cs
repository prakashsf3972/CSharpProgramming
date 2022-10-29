using System;
namespace CafeteriaCard
{
    public class UserDetails:PersonalDetails,IBalance
    {
        /// <summary>
        /// Field s_userID with Auto Increment is used to provide unique userID to every user
        /// </summary>
         private static int s_userID=1000;
         /// <summary>
         /// Property UserID is used to provide unique UserID to every user
         /// </summary>
         /// <value></value>
        public string UserID { get; }
        /// <summary>
        /// Property Workstation is used to provide unique Workstation to every user
        /// </summary>
        /// <value></value>
        public string WorkStationNumber { get; set; }
        /// <summary>
        /// Field WalletBalance is used to provide unique Balance to every user
        /// </summary>
        private double _walletBalance;
        /// <summary>
        /// Property WalletBalance is used to provide unique WalletBalance to every user
        /// </summary>
        /// <value></value>
        public double WalletBalance { get; set; }
        /// <summary>
        ///Default UserDetails
        /// </summary>
        public UserDetails()
        {

        }
        /// <summary>
        ///  Property UserDetails is used to Show Details of UserDetails
        /// </summary>
        /// <param name="name"></param>
        /// <param name="fatherName"></param>
        /// <param name="gender"></param>
        /// <param name="mobileNumber"></param>
        /// <param name="mailID"></param>
        /// <param name="workStatioNumber"></param>
        /// <param name="walletBalance"></param>
        /// <returns></returns>
        public UserDetails(string name,string fatherName,Gender gender,long mobileNumber,string mailID,string workStatioNumber,double walletBalance): base(name,fatherName,gender,mobileNumber,mailID)
        {
            s_userID++;
            UserID="UID"+s_userID;
            WorkStationNumber=workStatioNumber;
            _walletBalance=walletBalance;
        }
        /// <summary>
        /// WalletRecharge is Add Amount in the Wallet
        /// </summary>
        /// <param name="amount"></param>
        public void WalletRecharge(double amount)
        {
            _walletBalance+=amount;
        }
        /// <summary>
        /// Detuct Method is used to the balance in the Wallet
        /// </summary>
        /// <param name="amount"></param>
        public void Deduct(double amount)
        {
            _walletBalance-=amount;
        }
        /// <summary>
        ///  Property UserDetails is used to Assign the data in Property
        /// </summary>
        /// <param name="data"></param>
        public UserDetails(string data)
        {
            string[] values=data.Split(",");
            s_userID=int.Parse(values[0].Remove(0,2));
            UserID=values[0];
            Name=values[1];
            FatherName=values[2];
            Gender=Gender.Parse<Gender>(values[3]);
            MobileNumber=long.Parse(values[4]);
            MailID=values[5];
            WorkStationNumber=values[6];
            WalletBalance=double.Parse(values[7]);        }
    }
}
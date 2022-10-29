using System;
namespace  GroceryApplication
{
    public class CustomerDetails:PersonalDetails
    {
        private static int s_customerID=1000;
        public string CustomerID { get; set; }
        public double WalletBalance { get; set; }
        public CustomerDetails()
        {
            
        }
        public CustomerDetails(string name,string fatherName,Gender gender,long phoneNumber,DateTime dateOfBirth,string mailID,double walletBalance):base(name,fatherName,gender,phoneNumber,dateOfBirth, mailID)
        {
            s_customerID++;
            CustomerID="CID"+s_customerID;
            WalletBalance=walletBalance;

        }
        public  CustomerDetails(string data)
        {
          string[] values=data.Split(',');
          s_customerID=int.Parse(values[0].Remove(0,3));
          CustomerID=values[0];
          Name=values[1];
          FatherName=values[2];
          Gender=Enum.Parse<Gender>(values[3]);
          PhoneNumber=long.Parse(values[4]);
          DateOFBirth=DateTime.Parse(values[5]);
          MailID=values[6];
        }
    }
}
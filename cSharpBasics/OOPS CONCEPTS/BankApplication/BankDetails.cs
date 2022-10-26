namespace BankApplication
{
    public enum Gender {Default,MAle,Female,TransGender};

    public enum AccountType {Default,SavingsAccount,Fb,Sb,Rd}
    public class BankDetails
    {
        private static int s_customerId=3000;
        public string CustomerId{get;}
        public string Name { get; set; }
        public string FatherName { get; set; }
        public  Gender CustomerGender  { get; set; }
        public AccountType CustomerAccountType{ get; set; }
       public double Balance { get; set; }
        

        public BankDetails(string name,string fatherName,Gender gender,AccountType accountType)
        {
            s_customerId++;
            CustomerId="A1"+s_customerId;
            Name=name;
            FatherName=fatherName;
            CustomerGender=gender;
           CustomerAccountType=accountType;
        }
      
            public double Deposit(double deposit)
            {
               Balance=Balance+deposit;
                return Balance;
            }
            

             public double WithDraw(double withdraw)
            {
                if(withdraw<=Balance)
                {
                    Balance=Balance-withdraw;
                     
                    return Balance;
                }
                else
                {
                    return 0;
                }

            }
    }
}
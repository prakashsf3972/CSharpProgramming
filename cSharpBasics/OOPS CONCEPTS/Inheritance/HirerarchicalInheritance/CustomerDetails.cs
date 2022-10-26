using System;
namespace HirerarchicalInheritance
{
    public class CustomerDetails : PersonDetails
    {
        private static int s_customerId=1000;
        public string  CustomerId { get; set; }
        public double Balance { get; set; }

        public CustomerDetails(string aid,string name,string fatherName,long phoneNumber,Gender gender,int phone,double balance):base(aid,name,fatherName,phoneNumber,gender)
        {
            s_customerId++;
            CustomerId="CID"+s_customerId;
            Balance=balance;
        }
        public void Recharge()
        {
            System.Console.WriteLine("Enter Amount to be Recharged");
            Balance+=double.Parse(Console.ReadLine());
        }
        public void ShowCustomerDetails()
        {
            System.Console.WriteLine("CustomerId is"+CustomerId);
            ShowDetails();
            System.Console.WriteLine("Balance is"+Balance);
        }

    }
}
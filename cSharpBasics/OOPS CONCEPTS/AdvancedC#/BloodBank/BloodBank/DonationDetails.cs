using System;
namespace BloodBank
{
    public class DonationDetails
    {
        private static int s_donationID=1000;
        public string DonationID { get; }
        public string DonarID { get; set; }
        public  DateTime DonationDate { get; set; }
        public double  Weight { get; set; }
        public double BloodPressure { get; set; }
        public double HbCount { get; set; }

        public DonationDetails(string donarID,DateTime donationDate,double weight,double bloodPressure,double hbCount)
        {
            s_donationID++;
            DonationID="DID"+s_donationID;
            DonarID=donarID;
            DonationDate=donationDate;
            Weight=weight;
            BloodPressure=bloodPressure;
            HbCount=hbCount;

        }
    }
}
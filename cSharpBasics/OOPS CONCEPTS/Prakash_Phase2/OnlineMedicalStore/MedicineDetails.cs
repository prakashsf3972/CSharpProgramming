using System;
namespace OnlineMedicalStore
{
    public class MedicineDetails
    {
        private static int s_medicineId=100;
        public string MedicineId { get;  }
        public string MedicineName { get; set; }
        public int AvailableCount { get; set; }
        public double Price { get; set; }
        public DateTime DateOFExpriy { get; set; }



        public MedicineDetails(string medicineName,int availableCount,double price,DateTime dateOfExpriy)
        {
            s_medicineId++;
            MedicineId="MD"+s_medicineId;
            MedicineName=medicineName;
            AvailableCount=availableCount;
            Price=price;
            DateOFExpriy=dateOfExpriy;
        }
    }
}
using System;
namespace OnlineMedicalStore
{
    public enum OrderStatus {Default,Purchased,Cancelled}
    public class OrderDetails
    {
        private static int s_orderId=2000;
        public string OrderId { get;  }
        public string UserID { get; set; }
        public string MedicineId { get; set; }
        public int MedicineCount { get; set; }
        public double TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }



        public OrderDetails(string userId,string medicineId,int medicineCount,double totalPrice,DateTime orderDate,OrderStatus status)
        {
            s_orderId++;
            OrderId="OID"+s_orderId;
            UserID=userId;
            MedicineId=medicineId;
            MedicineCount=medicineCount;
            TotalPrice=totalPrice;
            OrderDate=orderDate;
            Status=status;

        }
    }
}
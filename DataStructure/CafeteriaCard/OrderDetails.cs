using System;
namespace CafeteriaCard
{
    public enum OrderStatus {Default,Initiated,Ordered,Cancelled}
    public class OrderDetails
    {
        private static int s_orderID=1000;
        public string OrderID { get; set; }
        public string UserID { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalPrice { get; set; }
        public OrderStatus Status { get; set; }

        public OrderDetails()
        {

        }
        public OrderDetails(string userID,DateTime orderDate,double totalPrice,OrderStatus status)
        {
            s_orderID++;
            OrderID="OID"+s_orderID;
            UserID=userID;
            OrderDate=orderDate;
            TotalPrice=totalPrice;
            Status=status;
        }
        public OrderDetails(string data)
        {
            string[] values=data.Split(",");
            s_orderID=int.Parse(values[0].Remove(0,3));
            OrderID=values[0];
            UserID=values[1];
            OrderDate=DateTime.Parse(values[2]);
            TotalPrice=double.Parse(values[3]);
            Status=Enum.Parse<OrderStatus>(values[4]);
        }
    }
}
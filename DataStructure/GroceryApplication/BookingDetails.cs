using System;
namespace GroceryApplication
{
    public enum BookingStatus {Default,Initiated,Booked,Cancelled}
    public class BookingDetails
    {
        private static int s_bookingID=3000;
        public string BookingID { get; set; }
        public string CustomerID { get; set; }
        public double TotalPrice { get; set; }
        public DateTime DateOFBooking { get; set; }
        public BookingStatus Status { get; set; }
        
        public BookingDetails()
        {

        }
        public BookingDetails(string customerID,double totalPrice,DateTime dateOfBooking,BookingStatus status)
        {
            s_bookingID++;
            BookingID="BID"+s_bookingID;
            CustomerID=customerID;
            TotalPrice=totalPrice;
            DateOFBooking=dateOfBooking;
            Status=status;
        }
        public BookingDetails(string data)
        {
          string[] values=data.Split(',');
          s_bookingID=int.Parse(values[0].Remove(0,3)); 
          BookingID=values[0];
          CustomerID=values[1];
          TotalPrice=double.Parse(values[2]);
          DateOFBooking=DateTime.Parse(values[3]);
          Status=Enum.Parse<BookingStatus>(values[4]); 
        }
    }
}
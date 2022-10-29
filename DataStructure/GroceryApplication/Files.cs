using System.IO;
namespace GroceryApplication
{
    public class Files
    {
        public static void Create()
       {
        if(!Directory.Exists("OnlineGrocery"))
        {
            System.Console.WriteLine("Create Folder");
            Directory.CreateDirectory("OnlineGrocery");

        }
      
        if(!File.Exists("OnlineGrocery/ProductDetails.csv"))
        {
            System.Console.WriteLine("Create File");
            File.Create("OnlineGrocery/ProductDetails.csv");
        }
        if(!File.Exists("OnlineGrocery/BookingDetails.csv"))
        {
            System.Console.WriteLine("Create File");
            File.Create("OnlineGrocery/BookingDetails.csv");
        }
        if(!File.Exists("OnlineGrocery/CustomerDetails.csv"))
        {
            System.Console.WriteLine("Create File");
            File.Create("OnlineGrocery/CustomerDetails.csv");
        }
        if(!File.Exists("OnlineGrocery/OrderDetails.csv"))
        {
            System.Console.WriteLine("Create File");
            File.Create("OnlineGrocery/OrderDetails.csv");
        }
       }
       public static void ReadFile()
       {

            string[] users=File.ReadAllLines("OnlineGrocery/CustomerDetails.csv");
            {
                foreach(string data in users)
                {
                    CustomerDetails user=new CustomerDetails(data);
                    Operations.customersList.Add(user);
                }
            }

            string[] products=File.ReadAllLines("OnlineGrocery/ProductDetails.csv");
            {
                foreach(string data in products)
                {
                    ProductDetails product=new ProductDetails(data);
                    Operations.productsList.Add(product);
                }
            }

            string[] orders=File.ReadAllLines("OnlineGrocery/OrderDetails.csv");
            {
                foreach(string data in orders)
                {
                  OrderDetails order=new OrderDetails(data);
                    Operations.ordersList.Add(order);
                }
            }

            string[] bookings=File.ReadAllLines("OnlineGrocery/BookingDetails.csv");
            {
                foreach(string data in bookings)
                {
                    BookingDetails booking=new BookingDetails(data);
                    Operations.bookersList.Add(booking);
                }
            }

       } 
       public static void WriteFile()
       {
           string[] CustomerDetails=new string[Operations.customersList.Count];
           for(int i=0;i<Operations.customersList.Count;i++)
           {
              CustomerDetails[i]=Operations.customersList[i].CustomerID+","+Operations.customersList[i].Name+","+Operations.customersList[i].FatherName+","+Operations.customersList[i].Gender+","+Operations.customersList[i].DateOFBirth.ToString("dd/MM/yyyy")+","+Operations.customersList[i].MailID+","+Operations.customersList[i].WalletBalance;
           }
           File.WriteAllLines("OnlineGrocery/CustomerDetails.csv",CustomerDetails);

           string[] ProductDetails=new string[Operations.productsList.Count];
           for(int i=0;i<Operations.productsList.Count;i++)
           {
            ProductDetails[i]=Operations.productsList[i].ProductID+","+Operations.productsList[i].ProductName+","+Operations.productsList[i].QuantityAvailable+","+Operations.productsList[i].PricePerQuantity;
           }
          File.WriteAllLines("OnlineGrocery/ProductDetails.csv",ProductDetails);

           string[] OrderDetails=new string[Operations.ordersList.Count];
           for(int i=0;i<Operations.ordersList.Count;i++)
           {
            OrderDetails[i]=Operations.ordersList[i].OrderID+","+Operations.ordersList[i].BookingID+","+Operations.ordersList[i].ProductID+","+Operations.ordersList[i].PurchaseCount+","+Operations.ordersList[i].PriceOfOrder;
           }
           File.WriteAllLines("OnlineGrocery/OrderDetails.csv",OrderDetails);

           string[]  BookingDetails=new string[Operations.bookersList.Count];
           for(int i=0;i<Operations.bookersList.Count;i++)
           {
            BookingDetails[i]=Operations.bookersList[i].BookingID+","+Operations.bookersList[i].CustomerID+","+Operations.bookersList[i].TotalPrice+","+Operations.bookersList[i].DateOFBooking.ToString("dd/MM/yyyy")+","+Operations.bookersList[i].Status;
           }
            File.WriteAllLines("OnlineGrocery/BookingDetails.csv",BookingDetails);
       }
    }
}
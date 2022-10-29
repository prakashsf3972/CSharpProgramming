using System.IO;
namespace CafeteriaCard
{
    public class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("CafeteriaCard"))
            {
                System.Console.WriteLine("Create Folder");
                Directory.CreateDirectory("CafeteriaCard");

            }
            if(!File.Exists("CafeteriaCard/UserDetails.csv"))
            {
                System.Console.WriteLine("Create File");
                File.Create("CafeteriaCard/UserDetails.csv");
            }
            if(!File.Exists("CafeteriaCard/FoodDetails.csv"))
            {
                System.Console.WriteLine("Create File");
                File.Create("CafeteriaCard/FoodDetails.csv");
            }
            if(!File.Exists("CafeteriaCard/OrderDetails.csv"))
            {
                System.Console.WriteLine("Create File");
                File.Create("CafeteriaCard/OrderDetails.csv");
            }
            if(!File.Exists("CafeteriaCard/CartItem.csv"))
            {
                System.Console.WriteLine("Create File");
                File.Create("CafeteriaCard/CartItem.csv");
            }
       }  
       public static void ReadFile()
       {
            string[] users=File.ReadAllLines("CafeteriaCard/UserDetails.csv");
            {
                foreach(string data in users)
                {
                    UserDetails user=new UserDetails(data);
                    Operations.usersList.Add(user);
                }
            }
            string[] foods=File.ReadAllLines("CafeteriaCard/FoodDetails.csv");
            {
                foreach(string data in foods)
                {
                    FoodDetails food=new FoodDetails(data);
                    Operations.foodsList.Add(food);
                }
            }
            string[] orders=File.ReadAllLines("CafeteriaCard/OrderDetails");
            {
                foreach(string data in orders)
                {
                    OrderDetails order=new OrderDetails("CafeteriaCard/OrderDetails");
                    Operations.ordersList.Add(order);
                }
            }
            string[] carts=File.ReadAllLines("CafeteriaCard/CartItem");
            {
                foreach(string data in carts)
                {
                    CartItem cart=new CartItem("CafeteriaCard/OrderDetails");
                    Operations.itemsList.Add(cart);
                }
            }
       }
       public static void WriteFile()
       {
            
           string[] UserDetails=new string[Operations.usersList.Count];
           for(int i=0;i<Operations.usersList.Count;i++)
           {
              UserDetails[i]=Operations.usersList[i].UserID+","+Operations.usersList[i].Name+","+Operations.usersList[i].FatherName+","+Operations.usersList[i].Gender+","+Operations.usersList[i].MobileNumber+","+","+Operations.usersList[i].MailID+","+Operations.usersList[i].WorkStationNumber+","+Operations.usersList[i].WalletBalance;
           }
           File.WriteAllLines("CafeteriaCard/UserDetails.csv",UserDetails);
           
             
           string[] FoodDetails=new string[Operations.foodsList.Count];
           for(int i=0;i<Operations.foodsList.Count;i++)
           {
              FoodDetails[i]=Operations.foodsList[i].FoodID+","+Operations.foodsList[i].FoodName+","+Operations.foodsList[i].FoodPrice+","+Operations.foodsList[i].AvailableQuantity;
           }
           File.WriteAllLines("CafeteriaCard/FoodDetails.csv",FoodDetails);

           string[] OrderDetails=new string[Operations.ordersList.Count];
           for(int i=0;i<Operations.ordersList.Count;i++)
           {
            OrderDetails[i]=Operations.ordersList[i].OrderID+","+Operations.ordersList[i].UserID+","+Operations.ordersList[i].OrderDate.ToString("dd/MM/yyyy")+","+Operations.ordersList[i].TotalPrice+","+Operations.ordersList[i].Status;
           }
           File.WriteAllLines("CafeteriaCard/OrderDetails.csv",OrderDetails);

           string[] CartItem=new string[Operations.itemsList.Count];
           for(int i=0;i<Operations.itemsList.Count;i++)
           {
            CartItem[i]=Operations.itemsList[i].ItemID+","+Operations.itemsList[i].OrderID+","+Operations.itemsList[i].FoodID+","+Operations.itemsList[i].OrderPrice+","+Operations.itemsList[i].OrderQuantity;
           }
            File.WriteAllLines("CafeteriaCard/CartItem.csv",CartItem);
       }
    }
}
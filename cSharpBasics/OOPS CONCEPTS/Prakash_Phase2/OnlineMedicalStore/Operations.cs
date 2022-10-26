///<summary
/// used to process the OnlineMedicalStore using this application
/// </summary>
using System;
using System.Collections.Generic;
namespace OnlineMedicalStore
{
    /// <summary>
    /// Operation is a method which start from the mainProgram
    /// </summary>
    public static class Operations
    {
        public static List<UserDetails> userList=new List<UserDetails>();
        public static List<MedicineDetails> medicineList=new List<MedicineDetails>();
        public static List<OrderDetails> orderList=new List<OrderDetails>();
        public static UserDetails loggedUser;
        /// <summary>
        /// mainmenu is a method which shows the user to enter into the application
        /// </summary>
        public static void MainMenu()
        {
            string loop="yes";
            do{
            System.Console.WriteLine("***********Welcome*************");
            System.Console.WriteLine("--------------------------------");
            System.Console.WriteLine("**********MAINMENU**************");
            System.Console.WriteLine("---------------------------------");
            System.Console.WriteLine("\t1.Registration \n\t2.Login \n\t3.Exit");
            System.Console.WriteLine("Enter your Choice : ");
            int choice=int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                    {
                        System.Console.WriteLine("--------------------------------------");
                        System.Console.WriteLine("************REGISTRATION**************");
                        System.Console.WriteLine("---------------------------------------");
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("----------------------------------------");
                        System.Console.WriteLine("***************LOGIN********************");
                        System.Console.WriteLine("-----------------------------------------");
                        Login();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("******************EXITED*****************");
                        loop="no";
                        break;
                    }
                }
            }while(loop=="yes");

        }
        /// <summary>
        /// defaultUser is a method which Already store in the application
        /// </summary>
        public static void DefaultUser()
        {
            UserDetails user1=new UserDetails("Ravi",33,"Theni",9877774440,400);
            userList.Add(user1);
            UserDetails user2=new UserDetails("Baskaran",33,"Chennai",88477574770,500);
            userList.Add(user2);

            MedicineDetails medicine1=new MedicineDetails("Paracitamol",40,5,new DateTime(2022,06,30));
            medicineList.Add(medicine1);
            MedicineDetails medicine2=new MedicineDetails("Calpol",10,5,new DateTime(2022,05,30));
            medicineList.Add(medicine2);
            MedicineDetails medicine3=new MedicineDetails("Gelucil",10,5,new DateTime(2022,04,30));
            medicineList.Add(medicine3);
            MedicineDetails medicine4=new MedicineDetails("Metrogel",5,50,new DateTime(2022,10,30));
            medicineList.Add(medicine4);
            MedicineDetails medicine5=new MedicineDetails("PovidinIodin",10,50,new DateTime(2022,10,30));
            medicineList.Add(medicine5);

            OrderDetails order1=new OrderDetails(user1.UserId,medicine1.MedicineId,3,15,new DateTime(2022,05,13),OnlineMedicalStore.OrderStatus.Purchased);
            orderList.Add(order1);
            OrderDetails order2=new OrderDetails(user1.UserId,medicine2.MedicineId,2,10,new DateTime(2022,05,13),OnlineMedicalStore.OrderStatus.Cancelled);
            orderList.Add(order2);
            OrderDetails order3=new OrderDetails(user1.UserId,medicine4.MedicineId,2,100,new DateTime(2022,04,13),OrderStatus.Purchased);
            orderList.Add(order3);
            OrderDetails order4=new OrderDetails(user2.UserId,medicine3.MedicineId,3,120,new DateTime(2022,05,15),OrderStatus.Cancelled);
            orderList.Add(order4);
            OrderDetails order5=new OrderDetails(user2.UserId,medicine5.MedicineId,5,250,new DateTime(2022,05,15),OrderStatus.Purchased);
            orderList.Add(order5);
            OrderDetails order6=new OrderDetails(user2.UserId,medicine2.MedicineId,3,15,new DateTime(2022,05,15),OrderStatus.Purchased);
            orderList.Add(order6);

        }
        public static void Registration()
        {
            System.Console.WriteLine("-----------------------------------");
            System.Console.WriteLine("**********CREATEACCOUNT*************");
            System.Console.WriteLine("------------------------------------");
            System.Console.Write("Enter your Name : ");
            string userName=Console.ReadLine();
            System.Console.Write("Enter your Age  : ");
            int age=int.Parse(Console.ReadLine());
            System.Console.Write("Enter your City : ");
            string city=Console.ReadLine();
            System.Console.Write("Enter your PhoneNumber : ");
            double phoneNumber=double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Balance : ");
            double balance=double.Parse(Console.ReadLine());
            UserDetails newUser=new UserDetails(userName,age,city,phoneNumber,balance);
            userList.Add(newUser);
            System.Console.WriteLine("------------------------------------------------");
            System.Console.WriteLine("Your UserId is :"+newUser.UserId);
            System.Console.WriteLine("-------------------------------------------------");

        }
        public static void Login()
        {
            System.Console.WriteLine("------------------------------------");
            System.Console.WriteLine("Enter your UserId : ");
            string createdId=Console.ReadLine().ToUpper();
            int temp=0;
            foreach(UserDetails user in userList)
            {
                if(createdId==user.UserId)
                {
                    System.Console.WriteLine("*********************************");
                    System.Console.WriteLine("USER ID FOUND");
                    System.Console.WriteLine("*********************************");
                    loggedUser=user;
                    SubMenu();
                    temp=1;
                }
                else
                {
                    temp=0;
                }
                if(temp==0)
                {
                    System.Console.WriteLine("*************************");
                    System.Console.WriteLine("Your User Id is Not Found");
                    System.Console.WriteLine("**************************");
                    break;
                }
            }
            
        }
        public static void SubMenu()
            { 
                string condition="yes";
                do{
                System.Console.WriteLine("************SUBMENU***************");
                System.Console.WriteLine("-----------------------------------");
                System.Console.WriteLine("1.Show Medicine List \n2.Purchase Medicine \n3.Cancel Purchase \n4.Show Purchase History \n5.Recharge \n6.Exit");
                System.Console.WriteLine("Enter your Choice : ");
                int choice=int.Parse(Console.ReadLine());
                    switch(choice)
                    {
                        case 1:
                        {
                            System.Console.WriteLine("__________________________________");
                            System.Console.WriteLine("MEDICINE LIST");
                            System.Console.WriteLine("__________________________________");
                            ShowMedicineList();
                            break;
                        }
                        case 2:
                        {
                            System.Console.WriteLine("_______________________________________");
                            System.Console.WriteLine("PUCHASE MEDICINE");
                            System.Console.WriteLine("________________________________________");
                            PurchaseMedicine();
                            break;
                        }
                        case 3:
                        {
                            System.Console.WriteLine("___________________________________________");
                            System.Console.WriteLine("CANCELPURCHASE");
                            System.Console.WriteLine("____________________________________________");
                            CancelPurchase();
                            break;
                        }
                        case 4:
                        {
                            System.Console.WriteLine("______________________________________________");
                            System.Console.WriteLine("SHOWMEDICINE PURCHASE HISTORY");
                            System.Console.WriteLine("______________________________________________");
                            PurchaseHistory();
                            break;
                        }
                        case 5:
                        {
                            System.Console.WriteLine("________________________________________________");
                            System.Console.WriteLine("RECHARGE");
                            System.Console.WriteLine("________________________________________________");
                            Recharge();
                            break;
                        }
                        case 6:
                        {
                            condition="no";
                            break;
                        }
                    }

                }while(condition=="yes");

            }
        public static void ShowMedicineList()
        {
             System.Console.WriteLine("|MEDICINEID|\t|MEDICINENAME|\t|AVAILABLECOUNT|\t|PRICE|\t|EXPIRYDATE|");
            foreach(MedicineDetails medicine in medicineList)
            {
               System.Console.WriteLine($"{medicine.MedicineId} \t{medicine.MedicineName} \t{medicine.AvailableCount} \t{medicine.Price} \t{medicine.DateOFExpriy.ToString("dd/MM/yyyy")}");
            }
        }
        public static void PurchaseMedicine()
        {
             System.Console.WriteLine("|MEDICINEID|\t|MEDICINENAME|\t|AVAILABLECOUNT|\t|PRICE|\t|EXPIRYDATE|");
            foreach(MedicineDetails medicine in medicineList)
            {
               System.Console.WriteLine($"{medicine.MedicineId} \t{medicine.MedicineName} \t{medicine.AvailableCount} \t{medicine.Price} \t{medicine.DateOFExpriy.ToString("dd/MM/yyyy")}");
            }
            System.Console.Write("Ente a MedicineId wish to Buy: ");
            string medichineId=Console.ReadLine().ToUpper();
            System.Console.WriteLine("Enter no.of.stock wish to buy: ");
            int count=int.Parse(Console.ReadLine());
            double totalAmount=0;
            double dectutedAmount=0;
            int temp=0;
            double avaialableBalance=0;
            foreach(MedicineDetails medicine in medicineList)
            {
                if(medichineId==medicine.MedicineId)
                {
                    temp=1;
                    System.Console.WriteLine("Medicine is Available");
                    if(count<=medicine.AvailableCount)
                    {
                        totalAmount=medicine.Price*count;
                        foreach(UserDetails user in userList)
                        {
                            if(user.Balance>=totalAmount)
                            {
                                System.Console.WriteLine("Total PUrchasing Amount is :"+totalAmount);
                                System.Console.WriteLine("Order is Purchased");
                                dectutedAmount=user.Balance-totalAmount;
                                System.Console.WriteLine("Deductedamount is"+dectutedAmount);
                                avaialableBalance=user.Balance-dectutedAmount;
                                System.Console.WriteLine("Available Balance is "+avaialableBalance);
                                System.Console.WriteLine("Order Date is "+DateTime.Now);
                                medicine.AvailableCount = medicine.AvailableCount-count;
                                System.Console.WriteLine(" Order is Purchased ");
                                OrderDetails customer1=new OrderDetails(user.UserId,medicine.MedicineId,medicine.AvailableCount,totalAmount,DateTime.Now,OrderStatus.Purchased);
                                orderList.Add(customer1);
                                System.Console.WriteLine("------------------------------------");
                                System.Console.WriteLine("Your Order Id is :"+customer1.OrderId);
                                System.Console.WriteLine("-------------------------------------");
                                break;

                            }
                            else
                            {
                                System.Console.WriteLine("Please Recharge Your Wallet");
                            }
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("Stock is Not Available");
                    }
                }
                else
                {
                 temp=0;    
                }
                if(temp==0)
                {
                    System.Console.WriteLine("Medicine is Not Available");
                    break;
                }
            }
        }
        public static void CancelPurchase()
        {
            System.Console.WriteLine("************CANCELPURCHASE***********");
            System.Console.WriteLine("Enter your OrderID: ");
            string orderId=Console.ReadLine();
            foreach(OrderDetails order in orderList)
            {
                if(orderId==order.OrderId && order.Status==OrderStatus.Purchased)
                {
                    foreach(MedicineDetails medicine in medicineList)
                    {
                        if(medicine.MedicineId==order.MedicineId)
                        {
                          medicine.AvailableCount=medicine.AvailableCount+order.MedicineCount;
                          loggedUser.Balance=order.TotalPrice+loggedUser.Balance;
                          System.Console.WriteLine("Updated Balance is : "+loggedUser.Balance);
                          System.Console.WriteLine("Your Order is Cancelled SuccessFully");
                          break;
                        }
                    }
                }
                else
                {
                    System.Console.WriteLine("your Id is Not Exsisted");
                    break;
                }
            }
        }
        public static void PurchaseHistory()
        {
            System.Console.WriteLine("|ORDERID| |USERID| |MEDICINEID| |AVAILABILITYCOUNT| |TOTALAMOUNT| |DATE| |STATUS|");
            foreach(OrderDetails order in orderList)
            {
                
                if(order.UserID==loggedUser.UserId)
                {
                 System.Console.WriteLine($"{order.OrderId} \t {order.UserID} \t{order.MedicineId} \t{order.MedicineCount} \t{order.TotalPrice} \t{order.OrderDate} \t{order.Status}");   
                }
            }
        }
        public static void Recharge()
        {
            foreach(UserDetails user in userList)
            {
                if(user.UserId==loggedUser.UserId)
                {
                    System.Console.WriteLine("Enter a Amount to Add in Wallet : ");
                    double addAmount=double.Parse(Console.ReadLine());
                    loggedUser.Balance+=addAmount;
                }
            }
        }
    }
}

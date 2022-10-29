using System;
namespace GroceryApplication;
public delegate void EventManager();
public class Operations
{
    public static List<CustomerDetails> customersList=new List<CustomerDetails>();
    public static List<ProductDetails>  productsList=new List<ProductDetails>();
    public static List<BookingDetails> bookersList=new List<BookingDetails>();
    public static List<OrderDetails> ordersList=new List<OrderDetails>();
    public static CustomerDetails loggedUser=null;
       public static event EventManager eventlink=null;
        private static void subscribe()
        {
            eventlink+=new EventManager(Files.Create);
            eventlink+=new EventManager(Files.ReadFile);
            eventlink+=new EventManager(DefaultUser);
            eventlink+=new EventManager(MainMenu);
            eventlink+=new EventManager(Files.WriteFile);
        }
        public static void HandleEvent()
        {
            subscribe();
            eventlink();
        }
    public static void DefaultUser()
    {
        CustomerDetails customer1=new CustomerDetails("RAVI","Ettaparajan",Gender.Male,974774646,new DateTime (1999,11,11),"ravi2gmail.com",10000);
        customersList.Add(customer1);
        CustomerDetails customer2=new CustomerDetails("Baskaran","Sethurajan",Gender.Male,847575775,new DateTime (1999,11,11),"baskaran499@gmail",15000);
        customersList.Add(customer2);


        ProductDetails product1=new ProductDetails("Sugar",20,40);
        productsList.Add(product1);
        ProductDetails product2=new ProductDetails("Rice",100,50);
        productsList.Add(product2);
        ProductDetails product3=new ProductDetails("Milk",10,40);
        productsList.Add(product3);
        ProductDetails product4=new ProductDetails("Coffee",10,10);
        productsList.Add(product4);
        ProductDetails product5=new ProductDetails("Tea",10,10);
        productsList.Add(product5);
        ProductDetails product6=new ProductDetails("MasalaPowder",10,20);
        productsList.Add(product6);
        ProductDetails product7=new ProductDetails("Salt",10,10);
        productsList.Add(product7);
        ProductDetails product8=new ProductDetails("Turmeric Powder",10,25);
        productsList.Add(product8);
        ProductDetails product9=new ProductDetails("Chilli Powder",10,20);
        productsList.Add(product9);
        ProductDetails product10=new ProductDetails("Groundnut Oil",10,140);
        productsList.Add(product10);

        BookingDetails booked1=new BookingDetails(customer1.CustomerID,220,new DateTime(2022,07,26),BookingStatus.Booked);
        bookersList.Add(booked1);
        BookingDetails booked2=new BookingDetails(customer2.CustomerID,400,new DateTime(2022,07,26),BookingStatus.Booked);
        bookersList.Add(booked2);
        BookingDetails booked3=new BookingDetails(customer1.CustomerID,280,new DateTime(2022,07,26),BookingStatus.Cancelled);
        bookersList.Add(booked3);
        BookingDetails booked4=new BookingDetails(customer2.CustomerID,0,new DateTime(2022,07,26),BookingStatus.Initiated);
        bookersList.Add(booked4);


        OrderDetails order1=new OrderDetails(booked1.BookingID,product1.ProductID,2,80);
        ordersList.Add(order1);
        OrderDetails order2=new OrderDetails(booked1.BookingID,product2.ProductID,2,180);
        ordersList.Add(order2);
        OrderDetails order3=new OrderDetails(booked1.BookingID,product3.ProductID,1,40);
        ordersList.Add(order3);
        OrderDetails order4=new OrderDetails(booked2.BookingID,product1.ProductID,1,40);
        ordersList.Add(order4);
        OrderDetails order5=new OrderDetails(booked2.BookingID,product2.ProductID,4,200);
        ordersList.Add(order5);
        OrderDetails order6=new OrderDetails(booked2.BookingID,product10.ProductID,1,140);
        ordersList.Add(order6);
        OrderDetails order7=new OrderDetails(booked2.BookingID,product9.ProductID,1,20);
        ordersList.Add(order7);
        OrderDetails order8=new OrderDetails(booked3.BookingID,product2.ProductID,2,100);
        ordersList.Add(order8);
        OrderDetails order9=new OrderDetails(booked3.BookingID,product8.ProductID,4,100);
        ordersList.Add(order9);
        OrderDetails order10=new OrderDetails(booked3.BookingID,product1.ProductID,2,80);
        ordersList.Add(order10);
    }
    public static void MainMenu()
    {
        string statement="yes";
        do
        {
                System.Console.WriteLine("*****MAINMENU******");
        System.Console.WriteLine("\t1.1.Customer Registration\n\t2.CustomerLogin\n\t3.Exit");
        System.Console.WriteLine("Enter your Choice: ");
        int choice=int.Parse(Console.ReadLine());
        switch(choice)
        {
            case 1:
            {
                CustomerRegistration();
                break;
            }
            case 2:
            {
                CustomerLogin();
                break;
            }
            case 3:
            {
                statement="no";
                break;
            }
        }

        }while(statement=="yes");
    }
    public static void CustomerRegistration()
    {
        System.Console.WriteLine("*******REGISTRATION FORM********");
        System.Console.WriteLine("Enter your Name:  ");
        string name=Console.ReadLine();
        System.Console.WriteLine("Enter your FatherName: ");
        string fatherName=Console.ReadLine();
        System.Console.WriteLine("Enter your Gender: ");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
        System.Console.WriteLine("Enter your MobileNumber: ");
        long phoneNumber=long.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter your DateOfBirth: ");
        DateTime dateOfBirth=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        System.Console.WriteLine("Enter your MailId: ");
        string mailID=Console.ReadLine();
        System.Console.WriteLine("Enter your WalletBalance: ");
        double walletBalance=double.Parse(Console.ReadLine());

        CustomerDetails person=new CustomerDetails(name,fatherName,gender,phoneNumber,dateOfBirth,mailID,walletBalance);
        customersList.Add(person);

        System.Console.WriteLine("your RegistrationID is: "+person.CustomerID);
        
    }
    public static void CustomerLogin()
    {
        System.Console.WriteLine("*****LOGIN******");
        System.Console.WriteLine("Enter your Registered UserID: ");
        string customerID=Console.ReadLine().ToUpper();
        int temp=0;
        foreach(CustomerDetails customer in customersList)
        {
            if(customerID==customer.CustomerID)
            {
                System.Console.WriteLine("******LOGIN SUCCESSFULLY******");
                loggedUser=customer;
                SubMenu();
                temp=1;
            }
            else
            {
                temp=0;
            }
        }
        if(temp==0)
        {
            System.Console.WriteLine("UserID is Invalid Please Enter Valid UserID");
        }
    }
    public static void SubMenu()
    {
        string statement="yes";
        do
        {
            System.Console.WriteLine("*****SUBMENU********");
        System.Console.WriteLine();
        System.Console.WriteLine("\t1.Show Customer Details\n\t2.Show Product Details\n\t3.Wallet Recharge\n\t4.Take Order\n\t5.Modify Order Quantity\n\t6.Cancel Order\n\t7.Exit");
        System.Console.WriteLine("Enter your Choice: ");
        int choice=int.Parse(Console.ReadLine());
        switch(choice)
        {
            case 1:
            {
                ShowCustomerDetails();
                break;
            }
            case 2:
            {
                ShowProductDetails();
                break;
            }
            case 3:
            {
                WalletBalance();
                break;
            }
            case 4:
            {
                TakeOrder();
                break;
            }
            case 5:
            {
                ModifyOrder();
                break;
            }
            case 6:
            {
                CancelOrder();
                break;
            }
            case 7:
            {
                statement="no";
                break;
            }
        }
        }while(statement=="yes");
    }
    public static void ShowCustomerDetails()
    {
        System.Console.WriteLine("|Name|\t\t|FatherName|\t\t|Gender|\t\t|PhoneNumber|\t\t|DateOfBirth|\t\t|MailID|\t\t|WalletBalance|");
        foreach(CustomerDetails customer in customersList)
        {
            if(loggedUser.CustomerID==customer.CustomerID)
            {
                System.Console.WriteLine($"{customer.CustomerID}\t\t{customer.FatherName}\t\t{customer.Gender}\t\t{customer.PhoneNumber}\t\t{customer.DateOFBirth}\t\t{customer.MailID}\t\t{customer.WalletBalance}");
            }
        }
    }
    public static void ShowProductDetails()
    {
        System.Console.WriteLine("|ProductID|\t\t|ProductName|\t\t|QuantityAvailable|\t\t|PricePerQuantity|");
        foreach(ProductDetails product in productsList)
        {
            System.Console.WriteLine($"{product.ProductID}\t\t{product.ProductName}\t\t{product.QuantityAvailable}\t\t{product.PricePerQuantity}");
        }
        System.Console.WriteLine();
    }
    public static void WalletBalance()
    {
        System.Console.WriteLine("***WALLETBALANCE***");
        System.Console.WriteLine("Do you want to Add Balance in your Account (yes/no):");
        string statement=Console.ReadLine().ToLower();
        if(statement=="yes")
        {
            System.Console.WriteLine("your Current Balance is: "+loggedUser.WalletBalance);
            System.Console.WriteLine("Enter a Amount to Add in your Wallet: ");
            double amount=double.Parse(Console.ReadLine());
            loggedUser.WalletBalance+=amount;
            System.Console.WriteLine("Updated Balance in wallet is: "+loggedUser.WalletBalance);
        }
    }
    public static void TakeOrder()
    {
        System.Console.WriteLine("****TAKEORDER*****");
        System.Console.WriteLine("Do you Want to Purchase Order(yes/no): ");
        string statement=Console.ReadLine().ToLower();
        if(statement=="yes")
        {
            BookingDetails bookednew1=new BookingDetails(loggedUser.CustomerID,0,DateTime.Now,BookingStatus.Initiated);

            List<OrderDetails> tempOrderList=new List<OrderDetails>();
            string pick="no";
            int quantity=0;
            double totalPrice=0;
            do
            {
            ShowProductDetails();
            System.Console.WriteLine("Enter a Product to Purchase: ");
            string productID=Console.ReadLine().ToUpper();
            System.Console.WriteLine("Enter how much Quantity do you Want: ");
            quantity=int.Parse(Console.ReadLine());
            int temp=0;
            foreach(ProductDetails product in productsList)
            {
                if(productID==product.ProductID)
                {
                    System.Console.WriteLine("The Product is Available to Purchase");
                    temp=1;
                    if(product.QuantityAvailable>=quantity)
                    {
                        System.Console.WriteLine("The Product Quantity is Available");
                        product.QuantityAvailable-=quantity;
                        totalPrice=quantity*product.PricePerQuantity;
                        loggedUser.WalletBalance-=totalPrice;
                        OrderDetails orderednew1=new OrderDetails(bookednew1.BookingID,product.ProductID,quantity,totalPrice);
                        tempOrderList.Add(orderednew1);
                        System.Console.WriteLine("Total OrderAmount  is :"+totalPrice);
                        System.Console.WriteLine("Product SuccessFully Added");
                        System.Console.WriteLine();
                        //System.Console.WriteLine("Do you want to Purchase Again(yes/no): ");
                        //pick=Console.ReadLine().ToLower();
                            
                    }
                    else
                    {
                        System.Console.WriteLine("The Product Count is Not Available");
                    }
                }  
            }
            System.Console.WriteLine("Do you want to Purchase Again(yes/no): ");
            pick=Console.ReadLine().ToLower();
            if(temp==0)
            {
                System.Console.WriteLine("“Invalid Product ID”");
            }

            }while(pick=="yes");

            System.Console.WriteLine("Do you want to confirm the order(yes/no): ");
            string status=Console.ReadLine();
            bool check=false;
            if(status=="yes")
            {
                do
                {
                    if(totalPrice<=loggedUser.WalletBalance)
                    {
                        totalPrice-=loggedUser.WalletBalance;
                        check=true;
                        bookednew1.Status=BookingStatus.Booked;
                        bookednew1.TotalPrice=totalPrice;
                        foreach(OrderDetails order in tempOrderList)
                        {
                            ordersList.Add(order);
                        } 
                        System.Console.WriteLine("Order Added SuccessFully");             
                    }
                    else
                    {
                        System.Console.WriteLine("Available Wallet Balance is :"+loggedUser.WalletBalance);
                        WalletBalance();
                    } 
                }while(!check);
            }
            else if(status=="no")
            {
                foreach(OrderDetails order in tempOrderList)
                {
                    foreach(ProductDetails product in productsList)
                    {
                        product.QuantityAvailable+=quantity;
                    }
                }
                System.Console.WriteLine("Cart Removed SuccessFully");
            }
        }
    }
    public static void ModifyOrder()
    {
        System.Console.WriteLine("*****MODIFYORDER******");
        System.Console.WriteLine("Enter your BookingID: ");
        System.Console.WriteLine("|OrderID|\t|BookingID|\t|ProductID|\t|PurchaseCount|\t|PriceOfOrder|");
        double totalAmount=0;
        foreach(BookingDetails booked in bookersList)
        {
            if(loggedUser.CustomerID==booked.CustomerID && booked.Status==BookingStatus.Booked)
            { 
                foreach(OrderDetails order in ordersList)
                {
                    if(order.BookingID==booked.BookingID)
                    {
                        System.Console.WriteLine($"{order.OrderID}\t\t{order.BookingID}\t\t{order.ProductID}\t\t{order.PurchaseCount}\t\t{order.PriceOfOrder}");
                        
                    }
                }
            }
        }
        System.Console.WriteLine("Enter a OrderID to Modify Order: ");
        string modify=Console.ReadLine();
                foreach(OrderDetails order in ordersList) 
                {                           
                    if(modify==order.OrderID)
                        {
                            System.Console.WriteLine("Enter a New Quantity of a Product: ");
                            int newQuantity=int.Parse(Console.ReadLine());
                            foreach(ProductDetails product in productsList)
                            {
                                if(order.ProductID==product.ProductID)
                                {
                                    totalAmount=product.PricePerQuantity * newQuantity;
                                    product.QuantityAvailable-=newQuantity;
                                    order.PriceOfOrder=totalAmount;
                                    loggedUser.WalletBalance-=totalAmount;
                                }
                            }
                        }
                }
    }
    public static void CancelOrder()
    {
        System.Console.WriteLine("CANCEL ORDER");
        System.Console.WriteLine("Enter a ProductID to Cancel Order: ");
        string exisitedBookingID=Console.ReadLine().ToUpper();
        foreach(BookingDetails bookings in bookersList)
        {
           foreach(ProductDetails product in productsList)
           {
                if(bookings.BookingID==loggedUser.CustomerID)
                bookings.Status=BookingStatus.Cancelled;
                loggedUser.WalletBalance+=bookings.TotalPrice;
                System.Console.WriteLine("Booking Status is Cancelled");
           }
        } 
    }

}               
    
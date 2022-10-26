using System;
using System.Collections.Generic;
namespace CommerseApplication
{
    public class Operations
    {
        public static CustomerDetails logginUser=null;
        public static List<CustomerDetails> customerList=new List<CustomerDetails>();
        public static List<Orderdetails>  orderList=new List<Orderdetails>();
        public static List<ProductDetails> productList=new List<ProductDetails>();
        public static void Mainmenu()
        {
            string statement="yes";
            do{
            System.Console.WriteLine("_____mainmenu____");
            System.Console.WriteLine("Enter your Choice");
            System.Console.WriteLine("1.Customer Registration \n2.Login and Purchase \n3.Exit");
            int choice=(int.Parse(Console.ReadLine()));

            switch(choice)
            {
                case 1:
                {
                    System.Console.WriteLine("Registration is Called: ");
                    Registration();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("you are in Login");
                    Login();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Exit");
                    statement="no";
                    break;
                }
            }
            }while(statement=="yes");

        }
            public static void Registration()
            {
                System.Console.WriteLine("Enter a customer Name: ");
                string customerName=Console.ReadLine();
                System.Console.WriteLine("Enter a City:");
                string cityName=Console.ReadLine();
                System.Console.WriteLine("Enter a Gender: Male Female Transgender");
                Gender gender=Enum.Parse<Gender>(Console.ReadLine().ToLower(),true);
                System.Console.WriteLine("Enter a Phone Number:");
                long phoneNumber=long.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter your Balance: ");
                int wallet_initial_Balance=(int.Parse(Console.ReadLine()));
                System.Console.WriteLine("Enter a Mailid:");
                string mailId=Console.ReadLine();
                CustomerDetails member=new CustomerDetails(customerName,cityName,gender,phoneNumber,wallet_initial_Balance,mailId);
                customerList.Add(member);
                System.Console.WriteLine("-----------------------------------");
                System.Console.WriteLine("REGISTRATION ID IS:"+member.CustomerId);
                System.Console.WriteLine("------------------------------------");
            }

            public static void defaultUser()
            {
                CustomerDetails customer1=new CustomerDetails("Ravi","Chennai",Gender.Male,9878986732,50000,"ravi@gmail.com");
                customerList.Add(customer1);
                CustomerDetails customer2=new CustomerDetails("Baskaran","chennai",Gender.Male,9994289172,60000,"sabaskaran123@gmail.com");
                customerList.Add(customer2);

                Orderdetails order1=new Orderdetails("CID1001","PID101",20000,DateTime.Now,2,OrderStatus.Ordered);
                orderList.Add(order1);
                Orderdetails order2=new Orderdetails("CID1001","PID101",40000,DateTime.Now,2,OrderStatus.Ordered);
                orderList.Add(order2);

                ProductDetails product1=new ProductDetails("Mobile",10000,10,3);
                productList.Add(product1);
                ProductDetails product2=new ProductDetails("Tablet",15000,5,3);
                productList.Add(product2);
                ProductDetails product3=new ProductDetails("camera",20000,3,3);
                productList.Add(product3);
                ProductDetails product4=new ProductDetails("iphone",30000,5,3);
                productList.Add(product4);
                ProductDetails product5=new ProductDetails("Laptop",40000,3,3);
                

            }
            public static void Login()
            {
                System.Console.WriteLine("************************LOGIN PAGE***************************");
                System.Console.WriteLine("Enter your CustomerId: ");
                string customerId=Console.ReadLine().ToUpper();
                int temp=0;
                foreach(CustomerDetails customer in customerList)
                {
                    if(customer.CustomerId==customerId)
                    {
                        System.Console.WriteLine("*****SUBMENU******");
                        System.Console.WriteLine("-------------------");
                        logginUser=customer;
                        SubMenu(logginUser);
                        temp=1;
                    }
                    
                }
                if(temp==0)
                {
                    System.Console.WriteLine("Invalid User ID");
                }
            
            }
            public static void SubMenu(CustomerDetails logginUser)
            {
                string condition="yes";
                do
                {

                System.Console.WriteLine("**********SUBMENU***********");
                System.Console.WriteLine("a,Purchase \nb.Order History \nc.Cancel Order \nd.Wallet Balance \ne.Exit");
                System.Console.WriteLine("Enter your Choice : ");
                char choice=char.Parse(Console.ReadLine().ToLower());
                    switch(choice)
                    {
                        case 'a':
                        {
                            System.Console.WriteLine("**************PURCHASE****************");
                            Purchase(logginUser);
                            break;
                        }
                        case 'b':
                        {
                            OrderHistoy();
                            break;

                        }
                        case 'c':
                        {
                            CancelOrder();
                            break;
                        }
                        case 'd':
                        {
                            WalletBalance();
                            break;
                        }
                        case 'e':
                        {
                            System.Console.WriteLine("****************EXIT******************");
                            condition="no";
                            break;
                        }
                    }
                }while(condition=="yes");
            }
            public static void Purchase(CustomerDetails logginUser)
            {
                int deliveryCharge=50;
                foreach(ProductDetails product in productList)
                {
                    System.Console.WriteLine("*************PRODUCTMENU****************");
                    System.Console.WriteLine("|PRODUCTID|  |PRODUCT NAME| |Available Stock Quantity| |Price Per Quantity| |Shipping Duration|");
                    System.Console.WriteLine($"|{product.ProductId} |{product.ProductName}| |{product.Stock}| |{product.Price}| |{product.ShippingDuration}|");
                    System.Console.WriteLine("|-----------------------------------------------------------------------------------------|");
                }
                System.Console.WriteLine("Enter a Product Id u wish to Purchase: ");
                string productId=Console.ReadLine().ToUpper();
                
                int totalAmount=0;
                foreach(ProductDetails product in productList)
                {
                        if(productId==product.ProductId)
                        {
                            System.Console.WriteLine("How Much of Count would you use to Purchase");
                            int count=int.Parse(Console.ReadLine());
                            if(count<=product.Stock)
                            {
                                    totalAmount=(count*product.Price)+deliveryCharge;
                                    System.Console.WriteLine("Your Total Amount is :"+totalAmount);
                                    if(logginUser.Initial_wallet_Balance>=totalAmount)
                                    {
                                
                                        logginUser.Initial_wallet_Balance=totalAmount-logginUser.Initial_wallet_Balance;
                                        product.Stock=product.Stock-count;
                                        System.Console.WriteLine("your Amount is Debited Successfully");
                                        DateTime today=DateTime.Now;
                                        DateTime deliveryDate=today.AddDays(product.ShippingDuration);
                                        System.Console.WriteLine("your Product is Ordered SuccessFully");
                                        System.Console.WriteLine($"your Order delivery date is {deliveryDate.ToString("dd/MM/yyyy")}"); 
                                        Orderdetails orderedItem=new Orderdetails(logginUser.CustomerId,product.ProductId,totalAmount,DateTime.Now,count,OrderStatus.Ordered);
                                        orderList.Add(orderedItem);
                                        System.Console.WriteLine("your Order Id is "+orderedItem.OrderId);
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("Your Balance is InSuffient Plaese Recharge your Wallet");
                                    }
                            }
                            else
                            {
                               System.Console.WriteLine("“Required count not available. Current availability is {product's stock count}”");
                
                            }   
              
                        }        
                }  
            }
            public static void OrderHistoy()
            {
                foreach(Orderdetails orders in orderList)
                {
                    if(logginUser.CustomerId==orders.CustomerId)
                    {
                        System.Console.WriteLine("--------------------------------------------------------------------------------------------");
                        System.Console.WriteLine("CUSTOMER ID IS :"+orders.CustomerId);
                        System.Console.WriteLine("PRODUCT ID  IS :"+orders.ProductId);
                        System.Console.WriteLine("TOTALAMOUNT IS :"+orders.TotalPrice);
                        System.Console.WriteLine("DATE           :"+DateTime.Now);
                        System.Console.WriteLine("NO.OF.STOCK IS :"+orders.Quantity);
                        System.Console.WriteLine("ORDER STATUS IS:"+OrderStatus.Ordered);
                    }
                }
            }
            public static void WalletBalance()
            {
                int recharge=0;
                string statement=null;
                foreach(CustomerDetails customer in customerList)
                {
                    if(logginUser.CustomerId==customer.CustomerId)
                    {
                        System.Console.WriteLine("your Wallet balance is : ");
                        System.Console.WriteLine(logginUser.Initial_wallet_Balance);
                        System.Console.WriteLine("Do you want to Recharge  the Wallet: ");
                        statement=Console.ReadLine().ToLower(); 
                    }
                    if(statement=="yes")
                    {
                        System.Console.WriteLine("Enter your Amount to Add in Wallet :");
                        recharge=int.Parse(Console.ReadLine());
                        logginUser.Initial_wallet_Balance+=recharge;
                        System.Console.WriteLine("Your updated Amountm in Wallet is :"+logginUser.Initial_wallet_Balance);
                        break;
                    } 
                }
            }
            public static void CancelOrder()
            {
                string ordercustomerId=null;
                foreach(Orderdetails order in orderList)
                {
                    if(order.CustomerId==logginUser.CustomerId)
                    {
                         System.Console.WriteLine("--------------------------------------------------------------------------------------------");
                        System.Console.WriteLine("CUSTOMER ID IS :"+order.CustomerId);
                        System.Console.WriteLine("PRODUCT ID  IS :"+order.ProductId);
                        System.Console.WriteLine("TOTALAMOUNT IS :"+order.TotalPrice);
                        System.Console.WriteLine("DATE           :"+DateTime.Now);
                        System.Console.WriteLine("NO.OF.STOCK IS :"+order.Quantity);
                        System.Console.WriteLine("ORDER STATUS IS:"+OrderStatus.Ordered);
                    }
                    System.Console.WriteLine("Select an order to be cancelled by the OrderID: ");


                    foreach(Orderdetails order1 in orderList)
                    {
                        if(order1.OrderId==ordercustomerId)
                        {
                            foreach(ProductDetails product in productList)
                            {
                                product.Stock+=order1.Quantity;
                                logginUser.Initial_wallet_Balance+=order.TotalPrice;
                            }
                        }
                    }
                }
            }    
    }
}

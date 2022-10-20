using System;
namespace CommerseApplication
{
    public class ProductDetails
    {
        private static int s_productId=1000;
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public int  Price { get; set; }
        public int Stock { get; set; }
        public int ShippingDuration{ get; set; }

        public ProductDetails(string productName,int price,int stock,int shippingDuration)
        {
            s_productId++;
            ProductId="PID"+s_productId;
            ProductName=productName;
            Price=price;
            Stock=stock;
            ShippingDuration=shippingDuration;

        }
    }
}
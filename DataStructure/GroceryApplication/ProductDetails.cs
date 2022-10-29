namespace GroceryApplication
{
    public class ProductDetails
    {
        private static int s_productID=100;
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public int QuantityAvailable { get; set; }
        public double PricePerQuantity { get; set; }
        public ProductDetails()
        {

        }
        public ProductDetails(string productName,int quantityAvailable,double pricePerQuantity)
        {
            s_productID++;
            ProductID="PID"+s_productID;
            ProductName=productName;
            QuantityAvailable=quantityAvailable;
            PricePerQuantity=pricePerQuantity;
        }
        public ProductDetails(string data)
        {
          string[] values=data.Split(',');
          s_productID=int.Parse(values[0].Remove(0,3));
          ProductID=values[0];
          ProductName=values[1];
          QuantityAvailable=int.Parse(values[2]);
          PricePerQuantity=double.Parse(values[3]);
        }
    }
}
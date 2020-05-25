namespace Core.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int QuantityOnHand { get; set; }
        public string ProductDesc { get; set; }
        public int MinimumStockLevel { get; set; }
    }
}
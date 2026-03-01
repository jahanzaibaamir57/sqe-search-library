namespace SearchLibrary
{
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }

        public Order(int orderId, string customerName)
        {
            OrderId = orderId;
            CustomerName = customerName;
        }
    }
}
namespace ComputerStore.Models
{
    
    public class AllOrders
    {
        private static List<OrderItem> _orders = new List<OrderItem>();

        public static IEnumerable<OrderItem> ListOrders
        {
            get { return _orders; }
        }

        public static void AddOrder(OrderItem newOrder)
        {
            _orders.Add(newOrder);
        }
    }
}

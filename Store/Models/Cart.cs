
namespace Store.Models
{
    public class Cart
    {
        private int id;

        public int OrderId { get; }

        public int TotalCount { get; set; }

        public decimal TotalPrice { get; set; }
        public Cart(int orderId, int totalCount, decimal totalPrice)
        {
            OrderId = orderId;
            TotalCount = totalCount;
            TotalPrice = totalPrice;
        }

        public Cart(int id)
        {
            this.id = id;
        }
    }
}

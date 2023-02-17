using System;
using System.Text;
using ExComposicao3.Entities.Enums;

namespace ExComposicao3.Entities {
    class Order {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public Product Product { get; set; }
        public List<OrderItem> OrderItem { get; set; } = new List<OrderItem>();

        public Order() {

        }

        public Order(DateTime moment, OrderStatus status) {
            Moment = moment;
            Status = status;

        }

        public Order(DateTime moment, OrderStatus status, Product product) : this(moment, status) {
            Product = product;
        }
        
        public void AddItem(OrderItem item) {
            OrderItem.Add(item);
        }
        public void RemoveItem(OrderItem item) {
            OrderItem.Remove(item);
        }
        public double Total() {
            double sum = 0;
            foreach (OrderItem item in OrderItem) {
                sum += item.SubTotal();
            }
            return sum;
        }
    }
}

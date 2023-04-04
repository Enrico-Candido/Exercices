using System;

namespace ExComposicao3.Entities {
    class OrderItem {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
        public OrderItem() {
        }
        public OrderItem(int quantity, double price) {
            Quantity = quantity;
            Price = price;
        }

        public OrderItem(int quantity, double price, Product product) : this(quantity, price){
            Product = product;
        }
        public double SubTotal() {
            return Quantity * Price;
        }
    }
}

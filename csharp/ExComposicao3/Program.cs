using System;
using System.Globalization;
using ExComposicao3.Entities;
using ExComposicao3.Entities.Enums;

namespace ExComposicao3 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime dateOfBirth = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Client client = new Client(name, email, dateOfBirth);

            Console.WriteLine();
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: (PendingPayment, Processing, Shipped, Delivered): ");
            string status = Console.ReadLine();
            OrderStatus orderSatus = Enum.Parse<OrderStatus>(status);
            Order order = new Order(DateTime.Now, orderSatus);
            Console.WriteLine();
            Console.Write("How many items to this order: ");
            int quantity = int.Parse(Console.ReadLine());

            Product product;
            for (int i = 1; i <= quantity; i++) {
                Console.WriteLine("Enter #" + i + " item data:");
                Console.Write("Product name: ");
                string nameOfProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double priceOfProduct = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantityOfProduct = int.Parse(Console.ReadLine());
                product = new Product(nameOfProduct, priceOfProduct);
                OrderItem item = new OrderItem(quantityOfProduct, priceOfProduct, product);
                order.AddItem(item);
            }

            Console.WriteLine();
            Console.WriteLine("Order Summary:"); 
            Console.WriteLine("Order Moment: " + order.Moment.ToString("dd/MM/yyyy HH:mm:ss")); ; 
            Console.WriteLine("Order Status: " + order.Status);  
            Console.WriteLine("Client: " + client.Name + "(" + client.BirthDate.ToString("dd/MM/yyyy") + ")" + " - " + client.Email);
            Console.WriteLine("Order items: ");
            foreach (OrderItem i in order.OrderItem) {
                Console.WriteLine(i.Product.Name + ", $" + i.Product.Price.ToString("F2") + ", Quantity: " + i.Quantity + ", Subtotal: $" + i.SubTotal().ToString("F2"));
            }
            Console.WriteLine("Total price: $" + order.Total().ToString("F2"));

        }
    }
}
using System;
using System.Globalization;
using ExHerancaPolimorfismo2.Entities;

namespace ExHerancaPolimorfismo2 {
    class Program {
        static void Main(string[] args) {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int quantity = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= quantity; i++) {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i): ");
                string status = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                if (status == "i") {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());

                    list.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (status == "c") {
                    list.Add(new Product(name, price));
                }
                else if (status == "u") {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                    list.Add(new UsedProduct(name, price, date));
                }
                Console.WriteLine();
            }

            Console.WriteLine("PRICE TAGS:");
            foreach (Product product in list) {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}

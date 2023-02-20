using System;
using ExHerancaPolimorfismo3.Entities;

namespace ExHerancaPolimorfismo3 {
    class Program {
        static void Main(string[] args) {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int quantity = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= quantity; i++) {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company? (i/c): ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());

                if (ch == 'i') {
                    Console.Write("Health expenditures: ");
                    double healhCost = double.Parse(Console.ReadLine());
                    list.Add(new Individual(name, anualIncome, healhCost));
                }
                else if (ch == 'c') {
                    Console.Write("Number of employees: ");
                    int qttOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, qttOfEmployees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double sum = 0;
            foreach (TaxPayer taxPayer in list) {
                Console.WriteLine($"{taxPayer.Name}: $ {taxPayer.Tax():F2}");
                sum += taxPayer.Tax();
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2"));
        }
    }
}

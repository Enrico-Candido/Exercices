using ExExceptions2.Entities;
using ExExceptions2.Entities.Exceptions;

namespace ExExceptions2 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter account data:");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Holder: ");
            string holder = Console.ReadLine();

            Console.Write("Initial balance: ");
            double initialBalance = double.Parse(Console.ReadLine());

            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Account account = new Account(number, holder, initialBalance, withdrawLimit);

            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine());

            try {
                account.WithDraw(amount);
                Console.Write(account);
            }

            catch (DomainException e) {
                Console.WriteLine(e.Message);
            }
            catch (Exception e) {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
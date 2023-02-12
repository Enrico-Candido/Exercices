using System;

namespace ExFor6 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite um numero inteiro: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++) if (number % i == 0) Console.WriteLine(i);
        }
    }
}
using System;

namespace ExFor7 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite um numero natural: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++) Console.WriteLine($"{i} {i*i} {Math.Pow(i, 3)}");
        }
    }
}
using System;

namespace ExFor5 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite um numero natural: ");
            long natural = long.Parse(Console.ReadLine());

            long guarda = 1L;
            for (long i = natural; i > 0; i--) guarda *= i;

            Console.WriteLine(guarda);
        }
    }
}
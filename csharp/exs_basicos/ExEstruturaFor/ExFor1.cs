using System;

namespace ExFor1 {
    class Proigram {
        static void Main(string[] args) {

            Console.WriteLine("Digite um valor inteiro no intervalo de [1, 1000]");

            int number = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= number; i++) {
                if (i % 2 == 1) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
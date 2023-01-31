using System;

namespace ExEstruturaCondicional2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite um numero inteiro");
            int number = int.Parse(Console.ReadLine());
            if (number >= 0) Console.WriteLine("Nao negativo");
            else Console.WriteLine("negativo");
        }
    }
}
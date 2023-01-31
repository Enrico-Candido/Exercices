using System;

namespace ExEstruturaCondicional1 {
    class Program {
        static void Main(string[] args) {
           
            Console.WriteLine("Digite um numero inteiro");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0) Console.WriteLine("Par");
            else Console.WriteLine("Impar");
        }
    }
}
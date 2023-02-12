using System;

namespace ExFor4 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite quantas vezes deseja inserir: ");
            int qtde = int.Parse(Console.ReadLine());
            Console.WriteLine("Digte 2 valores inteiros separados por espaco");

            for (int i = 0; i < qtde; i++) {
                string[] numbers = Console.ReadLine().Split(' ');
                double valorA = double.Parse(numbers[0]);
                double valorB = double.Parse(numbers[1]);
                if (valorB == 0) Console.WriteLine("Divisao impossivel");
                else Console.WriteLine((valorA/valorB).ToString("F2"));
            }
        }
    }
}
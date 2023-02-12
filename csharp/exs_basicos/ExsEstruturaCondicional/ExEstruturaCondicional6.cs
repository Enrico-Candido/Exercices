using System;

namespace ExEstruturaCondicional6 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite um numero");
            double number = double.Parse(Console.ReadLine());
            if (number < 0 || number > 100) Console.WriteLine("Fora do intervalo 0 - 100");
            else if (number <= 25) Console.WriteLine("[0, 25]");
            else if (number <= 50) Console.WriteLine("]25, 50]");
            else if (number <= 75) Console.WriteLine("]50, 75]");
            else if (number <= 100) Console.WriteLine("]75, 100]");
        }
    }
}
using System;

namespace ConApp4 {
    class Program {
        static void Main(string[] args) {
            int numberOne, numberTwo, numberThree, numberFour, diff;
            Console.WriteLine("Digite o primeiro numero:");
            numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            numberTwo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro numero:");
            numberThree = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o quarto numero:");
            numberFour = int.Parse(Console.ReadLine());
            diff = numberOne * numberTwo - numberThree * numberFour;
            Console.WriteLine("Diferenca: " + diff);
        }
    }
}
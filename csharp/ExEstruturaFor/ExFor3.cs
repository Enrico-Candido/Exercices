using System;

namespace ExFor3 {
    class Program {
        static void Main(string[] args) {
            // primeiro valor: peso 2 | segundo valor: peso 3 | terceiro valor: peso 5
            Console.Write("Quantas vezes deseja inserir: ");
            int qtde = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite 3 valores separados por espaco e com uma casa decimal");
            double mediaPonderada;
            for (int i = 0; i < qtde; i++) {
                string[] numbers = Console.ReadLine().Split(' ');
                double numberOne = double.Parse(numbers[0]);
                double numberTwo = double.Parse(numbers[1]);
                double numberThree = double.Parse(numbers[2]);  
                mediaPonderada = (numberOne * 2 + numberTwo * 3 + numberThree * 5)/10;
                Console.WriteLine(mediaPonderada.ToString("F1"));
            }
        }
    }
};
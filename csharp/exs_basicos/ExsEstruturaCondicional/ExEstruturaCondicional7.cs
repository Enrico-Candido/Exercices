using System;

namespace ExEstruturaCondicional7 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite 2 valores com uma casa decimal (na mesma linha");
            string[] valores = Console.ReadLine().Split(' ');
            double valorX = double.Parse(valores[0]);
            double valorY = double.Parse(valores[1]);

            if (valorX == 0 && valorY == 0) Console.WriteLine("Origem");
            else if (valorX == 0) Console.WriteLine("Eixo Y");
            else if (valorY == 0) Console.WriteLine("Eixo X");
            else if (valorX > 0 && valorY > 0) Console.WriteLine("Q1");
            else if (valorX < 0 && valorY > 0) Console.WriteLine("Q2");
            else if (valorX < 0 && valorY < 0) Console.WriteLine("Q3");
            else if (valorX > 0 && valorY < 0) Console.WriteLine("Q4");
        }
    }
}

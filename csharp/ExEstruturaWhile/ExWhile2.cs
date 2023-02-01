using System;

namespace ExWhile2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite dois pontos de um plano cartesiano (na mesma linha)");

            string[] valores = Console.ReadLine().Split(' ');
            double valorX = double.Parse(valores[0]);
            double valorY = double.Parse(valores[1]);

            while (valorX != 0 && valorY != 0) {
                if (valorX > 0 && valorY > 0) Console.WriteLine("Primeiro quadrante");
                else if (valorX < 0 && valorY > 0) Console.WriteLine("Segundo quadrante");
                else if (valorX < 0 && valorY < 0) Console.WriteLine("Terceiro quadrante");
                else Console.WriteLine("Quarto quadrante");
                valores = Console.ReadLine().Split(' ');
                valorX = double.Parse(valores[0]);
                valorY = double.Parse(valores[1]);
            }
        }
    }
}
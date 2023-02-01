using System;

namespace ExWhile3 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite um numero de 1 - 4: 1.Álcool 2.Gasolina 3.Diesel 4.Fim ");
            int number = int.Parse(Console.ReadLine());
            int qtdeAlcool = 0, qtdeGasolina = 0, qtdeDiesel = 0;

            while (number != 4) {
                if (number == 1) ++qtdeAlcool;
                else if (number == 2) ++qtdeGasolina;
                else if (number == 3) ++qtdeDiesel;
                else Console.WriteLine("Digite um valor de 1 ~ 4");
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + qtdeAlcool);
            Console.WriteLine("Gasolina: " + qtdeGasolina);
            Console.WriteLine("Diesel: " + qtdeDiesel);
        }
    }
}
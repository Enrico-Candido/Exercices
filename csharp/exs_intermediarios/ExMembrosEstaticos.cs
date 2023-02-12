using System;

namespace ExMembrosEstaticos1 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Qual e a cotacao do dolar? ");
            double cotacao = double.Parse(Console.ReadLine());
            Console.Write("Quantos dolares voce vai comprar? ");
            double qtdeDolares = double.Parse(Console.ReadLine());

            double resultado = ConversorMoeda.Conversao(cotacao, qtdeDolares);

            Console.WriteLine();
            Console.Write("Valor a ser pago em reais: " + resultado.ToString("F2"));
        }
    }
}

/*
 Classe ConversorMoeda usada

using System;

namespace ExMembrosEstaticos1 {
    class ConversorMoeda {
        public static double Conversao(double Cotacao, double QtdeDolares) {
            return Cotacao * QtdeDolares + 6 * Cotacao * QtdeDolares / 100;
        }
    }
}
 */
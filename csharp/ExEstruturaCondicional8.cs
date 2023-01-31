using System;

namespace ExEstruturaCondicional8 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite o valor do salario com 2 casas decimais para ver o imposto de renda do funcionario");
            
            double valor = double.Parse(Console.ReadLine());
            double guarda = valor;

            if (valor > 2000 && valor <= 3000) {
                valor = (valor - 2000.01) * 8 / 100;
            }
            else if (valor <= 4500) {
                valor = 999.99 * 8 / 100 + (valor - 3000.01) * 18 / 100;
            }
            else if (valor > 4500) {
                valor = 999.99 * 8 / 100 + 1499.99 * 18 / 100 + (valor - 4500.01) * 28 / 100;
            }

            if (guarda < 0) Console.WriteLine("Digite um valor positivo");
            else if (guarda <= 2000) Console.WriteLine("Isento");
            else Console.WriteLine("R$ " + valor.ToString("F2"));
        }
    }
}
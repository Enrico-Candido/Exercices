using System;

namespace ConApp6 {
    class Program {
        static void Main(string[] args) {
            int quantidadePeca1, quantidadePeca2;
            double valorUnidade1, valorUnidade2, calculo;
            Console.WriteLine("Digite o codigo da peca 1, quantidade solicidada e o valor de sua unidade:");
            string[] peca1 = Console.ReadLine().Split(' ');
            quantidadePeca1 = int.Parse(peca1[1]);
            valorUnidade1 = double.Parse(peca1[2]);
            Console.WriteLine("Digite o codigo da peca 2, quantidade solicidada e o valor de sua unidade:");
            string[] peca2 = Console.ReadLine().Split(' ');
            quantidadePeca2 = int.Parse(peca2[1]);
            valorUnidade2 = double.Parse(peca2[2]);
            calculo = quantidadePeca1 * valorUnidade1 + quantidadePeca2 * valorUnidade2;    
            Console.WriteLine("Valor a pagar: " + calculo.ToString("F2"));
        }
    }
}
using System;

namespace ExEstruturaCondicional3 {
    class Porogram {
        static void Main(string[] args) {
            int valorA, valorB;
            Console.WriteLine("Digite dois numeros inteiros (na mesma linha)");
            string[] valores = Console.ReadLine().Split(' ');
            valorA = int.Parse(valores[0]);
            valorB = int.Parse(valores[1]);
            if (valorA % valorB == 0 || valorB % valorA == 0) Console.WriteLine("Sao multiplos");
            else Console.WriteLine("Nao sao multiplos");
        }
    }
}
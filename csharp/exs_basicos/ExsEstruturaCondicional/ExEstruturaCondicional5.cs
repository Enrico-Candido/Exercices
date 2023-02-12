using System;

namespace ExEstruturaCondicional5 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("CODIGO    ESPECIFICAO        PRECO");
            Console.WriteLine("1         CACHORRO QUENTE    4.00");
            Console.WriteLine("2         X-SALADA           4.50");
            Console.WriteLine("3         X-BACON            5.00");
            Console.WriteLine("4         TORRADA SIMPLES    2.00");
            Console.WriteLine("5         REFRIGERANTE       1.50");
            Console.WriteLine();
            Console.WriteLine("Digite o codigo do lanche e a quantidade (na mesma linha)");

            string[] valores = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valores[0]);
            double quantidade = double.Parse(valores[1]);

            if (codigo == 1) Console.WriteLine("Total: R$ {0:F2}", quantidade * 4);
            else if (codigo == 2) Console.WriteLine("Total: R$ {0:F2}", quantidade * 4.5);
            else if (codigo == 3) Console.WriteLine("Total: R$ {0:F2}", quantidade * 5);
            else if (codigo == 4) Console.WriteLine("Total: R$ {0:F2}", quantidade * 2);
            else if (codigo == 5) Console.WriteLine("Total: R$ {0:F2}", quantidade * 1.5);
        }
    }
}

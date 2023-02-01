using System;

namespace ExFor2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Quantas vezes deseja inserir numeros?");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int x = 0;
            int y = 0;
            for (int i = 1; i <= n; i++) {
                int valor = int.Parse(Console.ReadLine());
                if (valor >= 10 && valor <= 20) ++x;
                else ++y;
            }

            Console.WriteLine();
            Console.WriteLine($"{x} in");
            Console.WriteLine($"{y} out");
        }
    }
}
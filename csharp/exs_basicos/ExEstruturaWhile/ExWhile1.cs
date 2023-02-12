using System;

namespace ExWhile1 {
    class Program {
        static void Main(string[] args) {
            string senhaCorreta = "2002";
            string senha = Console.ReadLine();

            while (senha != senhaCorreta) {
                Console.WriteLine("Senha invalida");
                senha = Console.ReadLine();
            }
            Console.WriteLine("Acesso permitido");
        }
    }
}
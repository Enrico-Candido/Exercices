using System;

namespace ExPOOSimples1 {
    class Program {
        static void Main(string[] args) {
            
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Digite o nome e idade da primeira pessoa");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome e idade da segunda pessoa");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade == p2.Idade) Console.WriteLine("Mesma idade");
            else if (p1.Idade > p2.Idade) Console.WriteLine("Pessoa mais velha: " + p1.Nome);
            else Console.WriteLine("Pessoa mais velha: " + p2.Nome);
        }
    }
}

/* 
 Classe Pessoa usada:

namespace ExPOOSimples1 {
    class Pessoa {
        public string Nome;
        public int Idade;
    }
}
 */
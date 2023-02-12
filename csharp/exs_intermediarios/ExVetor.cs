using System;

namespace ExVetores {
    class Program {
        static void Main(string[] args) {

            Console.Write("Quantos quartos serao alugados? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Aluguel[] vect = new Aluguel[10];

            for (int i = 1; i <= n; i++) {
                Console.WriteLine("Aluguel #" + i);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Aluguel { Nome = nome, Email = email };
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++) {
                if (vect[i] != null) Console.WriteLine(i + ": " + vect[i]);
            }
            Console.WriteLine();
        }
    }
}

/*
Classe Aluguel usada 

using System;

namespace ExVetores {
    internal class Aluguel {
        public string Nome { get; set; }
        public string Email { get; set; }

        override public string ToString() {
            return Nome + ", " + Email;
        }
    }
}
 */
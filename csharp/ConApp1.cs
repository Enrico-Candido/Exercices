using System;

namespace ConApp1 {
    class Program {
        static void Main(string[] args) {
             
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa:");
            int quantQuartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preco de um produto:");
            double precoProduto = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com seu ultimo nome, idade e altura (na mesma linha):");
            string[] frase = Console.ReadLine().Split(' ');
            string lastName = frase[0];
            int idade = int.Parse(frase[1]);
            double altura = double.Parse(frase[2]);
            Console.WriteLine(nome);
            Console.WriteLine(quantQuartos);
            Console.WriteLine(precoProduto);
            Console.WriteLine(lastName);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
        }
    }
}
using System;

namespace ExPOOSimples2 {
    class Program {
        static void Main(string[] args) {
            Funcionario f1, f2;
            f1 = new Funcionario();
            f2 = new Funcionario();
            
            Console.WriteLine("Dados do primeiro funcionario");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionario");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f2.Salario = double.Parse(Console.ReadLine());

            double mediaSalarial = (f1.Salario + f2.Salario) / 2;
            Console.WriteLine("Salario medio: " + mediaSalarial.ToString("f2"));
        }
    }
}

/* 
 Classe Funcionario usada

namespace ExPOOSimples2 {
    internal class Funcionario {
        public string Nome;
        public double Salario;
    }
}
 */
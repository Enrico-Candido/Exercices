using System;

namespace ExPOO4 {
    class Program {
        static void Main(string[] args) {
            Funcionario funcionario = new Funcionario();
            Console.WriteLine("Digite os valores do funcionario:");
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            funcionario.Salario = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine($"Funcionario: " + funcionario);

            Console.WriteLine();

            Console.Write("Digite a porcetagem para aumentar o salario: ");
            double porcentagem = double.Parse(Console.ReadLine());
            funcionario.AumentarSalario(porcentagem);

            Console.WriteLine($"Dados atualiados: " + funcionario);
        }
    }
}

/*
 Classe Funcionario usada

using System;

namespace ExPOO4 {
    class Funcionario {
        public string Nome;
        public double Salario, Imposto;

        public double SalarioLiquido() {
            return Salario - Imposto;
        }

        public void AumentarSalario(double porcentagem) {
            Salario += Salario * porcentagem/100;
        }

        public override string ToString() {
            return Nome
            + ", R$ "
            + SalarioLiquido().ToString("F2");
        }
    }
}
 */
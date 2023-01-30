using System;

namespace ConApp5 {
    class Program {
        static void Main(string[] args) {
            int idFuncionario, horasTrabalhadas;
            double valorHora, calculoSalario;
            Console.WriteLine("ID do funcionario:");
            idFuncionario = int.Parse(Console.ReadLine());
            Console.WriteLine("Horas trabalhdas do funcionario:");
            horasTrabalhadas = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor por hora do funcionario");
            valorHora = double.Parse(Console.ReadLine());
            calculoSalario = horasTrabalhadas * valorHora;
            Console.WriteLine("ID funcionario: " + idFuncionario);
            Console.WriteLine("Salario: U$ " + calculoSalario.ToString("F2"));
        }
    }
}
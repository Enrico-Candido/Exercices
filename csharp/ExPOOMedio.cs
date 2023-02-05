using System;

namespace ExPOOMedio {
    class Program {
        static void Main(string[] args) {
            Console.Write("Entre com o numero da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string nomeTitular = Console.ReadLine();
            Console.Write("Havera deposito inicial? (s/n): ");
            char respostaPergunta = char.Parse(Console.ReadLine());

            ContaBancaria contaBancaria;

            if (respostaPergunta == 's' || respostaPergunta == 'S') {
                Console.Write("Entre com o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                contaBancaria = new ContaBancaria(numConta, nomeTitular, depositoInicial);
            }
            else {
                contaBancaria = new ContaBancaria(numConta, nomeTitular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(contaBancaria);

            Console.WriteLine();
            Console.Write("Entre com um valor de deposito: ");
            double quantia = double.Parse(Console.ReadLine());
            contaBancaria.Deposito(quantia);
            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(contaBancaria);

            Console.WriteLine();
            Console.Write("Entre com um valor do saque: ");
            quantia = double.Parse(Console.ReadLine());
            Console.WriteLine();
            contaBancaria.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(contaBancaria);
        }
    }
}

/*
Classe ContaBancaria usada

 using System;

namespace ExPOOMedio {
    class ContaBancaria {
        public int NumeroConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numeroConta, string nome) {
            NumeroConta = numeroConta;
            Nome = nome;
        }

        public ContaBancaria(int numeroConta, string nome, double depositoInicial) : this(numeroConta, nome) {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia) {
            Saldo += quantia;
        }

        public void Saque(double quantia) {
            Saldo -= quantia + 5;
        }
        public override string ToString() {
            return $"Conta: {NumeroConta}, Titular: {Nome}, Saldo: $ {Saldo.ToString("F2")}";
        }
    }
}
 */
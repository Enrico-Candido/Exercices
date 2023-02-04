using System;

namespace ExPOO5 {
    class Program {
        static void Main(string[] args) {
            Aluno aluno = new Aluno();
            Console.Write("Digite o nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as 3 notas do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine());
            aluno.Nota2 = double.Parse(Console.ReadLine());
            aluno.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("NOTA FINAL: " + aluno.SomaNotas().ToString("F2"));
            if (aluno.SomaNotas() >= 60) Console.WriteLine("APROVADO");
            else Console.WriteLine("REPROVADO\r\n" + "FALTARAM " + aluno.PontosFaltantes().ToString("F2") + " PONTOS");
        }
    }
}

/*
Classe Aluno usada 
 
using System;

namespace ExPOO5 {
    class Aluno {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double SomaNotas() {
            return Nota1 + Nota2 + Nota3;
        }

        public double PontosFaltantes() {
            return 60 - SomaNotas();
        }
    }
}
 */

/*
 Outro modo de resolver o exercicio

using System;
using System.Globalization;
namespace Course {
    class Program {
        static void Main(string[] args) {
            Aluno aluno = new Aluno();
            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("NOTA FINAL = "
            + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            if (aluno.Aprovado()) {
                Console.WriteLine("APROVADO");
            }
            else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM "
                + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
                + " PONTOS");
            }
        }
    }
}

namespace Course {
    class Aluno {
        public string Nome;
        public double Nota1, Nota2, Nota3;
        public double NotaFinal() {
            return Nota1 + Nota2 + Nota3;
        }
        public bool Aprovado() {
            if (NotaFinal() >= 60.0) {
                return true;
            }
            else {
                return false;
            }
        }
        public double NotaRestante() {
            if (Aprovado()) {
                return 0.0;
            }
            else {
                return 60.0 - NotaFinal();
            }
        }
    }
}
 */

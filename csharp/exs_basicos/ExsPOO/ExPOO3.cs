using System;

namespace ExPOO3 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com a largura e altura do retangulo:");
            Retangulo retangulo = new Retangulo();

            retangulo.Largura = double.Parse(Console.ReadLine());
            retangulo.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine(retangulo);
        }
    }
}

/*
 Classe Retangulo usada

using System;

namespace ExPOO3 {
    class Retangulo {
        public double Largura, Altura;
        
        public double Area() {
            return Largura * Altura;
        }

        public double Perimetro() {
            return 2 * (Largura + Altura);
        }

        public double Diagonal() {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }

        public override string ToString() {
            return $"Area: " + Area().ToString("F2") +
                    "\r\nPerimetro: " + Perimetro().ToString("F2") +
                    "\r\nDiagonal: " + Diagonal().ToString("F2");
        }
    }
}
 */
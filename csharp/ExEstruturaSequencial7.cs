using System;

namespace ConApp7 {
    class Program {
        static void Main(string[] args) {
            double numberOne, numberTwo, numberThree, pi = 3.14159, triangulo, circulo, trapezio, quadrado, retangulo;
            Console.WriteLine("Digite 3 numeros para calculos de areas (na mesma linha)");
            string[] numbers = Console.ReadLine().Split(' ');
            numberOne = double.Parse(numbers[0]);
            numberTwo = double.Parse(numbers[1]);
            numberThree = double.Parse(numbers[2]);

            triangulo = numberOne * numberThree / 2;
            circulo = pi * Math.Pow(numberThree, 2);
            trapezio = (numberOne + numberTwo) * numberThree / 2;
            quadrado = Math.Pow(numberTwo, 2);
            retangulo = numberOne * numberTwo;

            Console.WriteLine("Triangulo: " + triangulo.ToString("F3"));
            Console.WriteLine("Circulo: " + circulo.ToString("F3"));
            Console.WriteLine("Trapezio: " + trapezio.ToString("F3"));
            Console.WriteLine("Quadrado: " + quadrado.ToString("F3"));
            Console.WriteLine("Retangulo: " + retangulo.ToString("F3"));
        }
    }
}
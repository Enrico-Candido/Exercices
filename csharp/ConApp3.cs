using System;

namespace ConApp3 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite o valor do raio do circulo:");
            double pi = 3.14159;
            double raio = double.Parse(Console.ReadLine());
            double area = pi * Math.Pow(raio, 2);
            Console.WriteLine("Area: " +  area.ToString("F4"));
        }
    }
}
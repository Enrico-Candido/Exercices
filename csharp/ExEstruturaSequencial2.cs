using System;

namespace ConApp2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Primeiro numero a ser somado:");
            int numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo numero a ser somado:");
            int numberTwo = int.Parse(Console.ReadLine());
            int sum = numberOne + numberTwo;
            Console.WriteLine("Soma: " + sum);
        }
    }
}
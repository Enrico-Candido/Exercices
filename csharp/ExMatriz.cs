using System;

namespace ExMatriz {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Quantas linhas e colunas tera a matriz? (digite na mesma linha)");
            string[] valoresMatriz = Console.ReadLine().Split(' ');
            int Linhas = int.Parse(valoresMatriz[0]);
            int Colunas = int.Parse(valoresMatriz[1]);

            int[,] mat = new int[Linhas, Colunas];

            for (int i = 0; i < Linhas; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < Colunas; j++) {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine();
            Console.Write("Digite um numero que se encontre na matriz: ");
            int valor = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < Linhas; i++) {
                for (int j = 0; j < Colunas; j++) {
                    if (mat[i, j] == valor) {
                        Console.WriteLine("Position: " + i + "," + j +":");
                        if (j > 0) Console.WriteLine("Left: " + mat[i, j - 1]);
                        if (j + 1 < Colunas) Console.WriteLine("Right: " + mat[i, j + 1]);
                        if (i > 0) Console.WriteLine("Up: " + mat[i - 1, j]);
                        if (i + 1 < Linhas) Console.WriteLine("Down: " + mat[i + 1, j]);
                    }
                }
            }
        }
    }
}
using System;
using System.Globalization;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de linhas: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Digite o número de colunas: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];

            for(int i = 0; i < m; i++)
            {
                string[] num = Console.ReadLine().Split(" ");
                for(int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(num[j]);
                }
            }

            Console.Write("Digite um número para informações: ");
            int x = int.Parse(Console.ReadLine());

            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(mat[i,j] == x)
                    {                        
                        Console.WriteLine("Posição: (" + i + ", " + j + ")" );

                        if (j > 0)
                        {
                            Console.WriteLine("Número a esquerda: " + mat[i, j-1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Número em cima: "+ mat[i-1,j]);
                        }
                        if(j < n - 1)
                        {
                            Console.WriteLine("Número a direita: " + mat[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Número em baixo: " + mat[i + 1, j]);
                        }

                    }
                }
                
            }
            
        }
    }
}

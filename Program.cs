using System;

namespace Diagonal_Principal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n,n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i,j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Diagonal principal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i,i] + " ");
            }
            Console.WriteLine();

            int cont = 0;
             for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i,j] < 0)
                    {
                        cont++;
                    } 
                }
            }
            
            Console.WriteLine("Números negativos: " + cont);
        }
    }
}

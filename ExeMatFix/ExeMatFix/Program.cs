using System;

namespace ExeMatFix
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] texto = Console.ReadLine().Split(" ");
            int m = int.Parse(texto[0]);
            int n = int.Parse(texto[1]);
            int[,] mat = new int[m, n];

            for (int i  = 0; i < m; i++)
            {
                string[] vec = Console.ReadLine().Split(" ");
                
                for ( int j = 0; j < n; j++)
                {

                    
                    mat[i, j] = int.Parse(vec[j]);

                }

            }

            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == numero)
                    {
                        Console.WriteLine("posição  " + i + " , " + j);
                        if ( i > 0)
                        {
                            Console.WriteLine("UP: " + mat[i - 1 ,  j]);
                        }
                        if (j > 0)
                        {
                            Console.WriteLine("Left :" + mat[i , j - 1]);
                        }
                        if (i < m - 1 )
                        {
                            Console.WriteLine("Down :" + mat[i + 1, j]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Right : " + mat[ i , j + 1]);
                        }
                    }

                }

            }


            /*
            foreach (int obj in mat) {
                Console.WriteLine(obj.ToString());
            
            }*/



        }
    }
}

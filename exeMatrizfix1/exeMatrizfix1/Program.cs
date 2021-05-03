using System;

namespace exeMatrizfix1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] mat = new int[6, 6];
            Console.WriteLine("digite os calores da matriz");
            int menor = 0;
            int pos = 0;

            for (int i = 0; i < 6; i++)
            {


                for (int j = 0; j < 6; j++)
                {
                    Console.WriteLine(i + " , " + j);

                    mat[i, j] = int.Parse(Console.ReadLine());



                }

            }
            menor = mat[0, 0];
            
            for (int i = 0; i < 6; i++)
            {
                if (menor > mat[i, i]) {
                    menor = mat[i, i];
                    pos = i;
                        }
            }

            Console.WriteLine("menor numero da diagonal princial" + menor + "posição" + pos + ","+ pos);

            /*
            for (int i = 0; i < 6; i++)
            {


                for (int j = 0; j < 6; j++)
                {
                     Console.Write("  posição:"+ i + " , "+ j+" valor: ", mat[i,j]);
            Console.Write("  " + mat[i, j] + "  ");
                    
                }
                Console.WriteLine();

            }*/


        }
    }
}

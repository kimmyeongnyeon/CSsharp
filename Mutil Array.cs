using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MutilArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] ar2 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            for(int i=0; i<3; i++)
            {
                for (int j=0; j<2; j++)
                {
                    Console.Write(ar2[i, j]);
                    Console.Write(",");
                }
            }

            Console.WriteLine();
            foreach (int n in ar2)
            {
                Console.Write(n);
                Console.Write(",");

            }

            Console.WriteLine();

            int[][] aar = new int[3][];
            //행만 잡아주고
            //aar은 배열 전체 참조 변수 aar[0] 배열 첫번째
            //aar[1] 배열 두번째 참조변수
            //aar[2] 배열 세번쨰 참조변수

            aar[0] = new int[] { 1, 2, 3, 4 };
            aar[1] = new int[] { 5, 6 };
            aar[2] = new int[] { 7, 8, 9, 10, 11, 12 };
            for (int i = 0; i < aar.Length; i++)
            {
                for (int j = 0; j < aar[i].Length; j++)
                {
                    Console.Write(aar[i][j]);
                    Console.Write(",");
                }
            }
        }
    }
}

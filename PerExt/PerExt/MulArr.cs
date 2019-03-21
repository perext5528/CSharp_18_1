//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MulArr
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[,] A = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
//            int[,] B = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
//            int[,] C = new int[2, 2];
//            Array.Clear(C, 0, C.Length);

//            for (int i = 0; i < 2; i++)
//            {
//                for (int j = 0; j < 2; j++)
//                {
//                    for (int k = 0; k < 3; k++)
//                    {
//                        C[i, j] += A[i, k] * B[k, j];

//                    }
//                    Console.Write(C[i, j] + " ");
//                }
//                Console.WriteLine();
//            }

//        }
//    }
//}

//using System;

//namespace Lab
//{
    
//    class MagicSqu
//    {
//        static int MAX = 50;
//        static int ROW, COL, NUM;
//        static int[,] square = new int[MAX, MAX];
        
//        static void GetNewPosition()
//        {
            
//            int r = ROW;
//            int c = COL;
//            r--; c--;
//            if (r < 0) r = NUM - 1;
//            if (c < 0) c = NUM - 1;
//            if (square[r, c] != 0)
//            {
//                r = ROW + 1;
//                if (r > (NUM - 1)) r = 0;
//                c = COL;
//            }
//            ROW = r;
//            COL = c;
//        }

//        static void Main(string[] args)
//        {        
//            int i, j;
//            Console.Write("Input N x N Magic Square(N : 홀수) : ");
//            NUM = Convert.ToInt32(Console.ReadLine());
//            if (NUM % 2 != 1) return;
//            ROW = 0;
//            COL = NUM / 2;
//            square[ROW, COL] = 1;

//            for (i = 2; i <= NUM * NUM; i++)
//            {
//                GetNewPosition();
//                square[ROW, COL] = i;
//            }

//            Console.WriteLine("Magic Square : ");

//            for (i = 0; i < NUM; i++)
//            {
//                for (j = 0; j < NUM; j++)
//                {
//                    Console.Write("{0,4:D}",square[i, j]);
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}

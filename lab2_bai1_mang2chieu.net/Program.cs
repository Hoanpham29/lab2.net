﻿using System;
namespace Csharp
{
    class TestCsharp
    {
        public static void Main()
        {

            int i, j;
            int[,] arr1 = new int[3, 3];
            Console.Write("\nDoc va in mang hai chieu trong C#:\n");
            Console.Write("--------------------------------\n");
            /* nhap cac phan tu vao trong mang*/
            Console.Write("Nhap cac phan tu vao mang hai chieu:\n");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("Phan tu - [{0},{1}]: ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("\nIn mang hai chieu: \n");
            for (i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 3; j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }
            Console.Write("\n\n");
            Console.ReadKey();
        }
    }
}
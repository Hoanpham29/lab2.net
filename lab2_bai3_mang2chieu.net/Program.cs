using System;
namespace Csharp
{
    class TestCsharp
    {
        public static void Main()
        {
            int i, j, sum = 0, n;
            int[,] arr1 = new int[50, 50];
            Console.Write("\nTinh tong cac phan tu tren duong cheo chinh cua ma tran trong C#:\n"); 
            Console.Write("-----------------------\n");
            Console.Write("Nhap kich co ma tran vuong: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap cac phan tu cua ma tran:\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("Phan tu - [{0}],[{1}]: ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                    //tinh tong cac phan tu tren duong cheo chinh 
                    if (i == j) sum = sum + arr1[i, j];
                }
            }
            Console.Write("In ma tran:\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                    Console.Write("{0} ", arr1[i, j]);
                Console.Write("\n");
            }
            Console.Write("Tong cac phan tu tren duong cheo chinh la: { 0}\n", sum);        
            Console.ReadKey();
        }
    }
}
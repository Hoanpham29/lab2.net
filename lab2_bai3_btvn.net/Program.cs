using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        // 1. Nhập một ma trận số thực gồm n hàng, m cột (với n và m là hai số nguyên dương)
        Console.Write("Enter number of rows (n): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter number of columns (m): ");
        int m = int.Parse(Console.ReadLine());

        double[,] matrix = new double[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"Enter element at position [{i},{j}]: ");
                matrix[i, j] = double.Parse(Console.ReadLine());
            }
        }

        // 2. Hiển thị ma trận
        Console.WriteLine("\nMatrix:");
        DisplayMatrix(matrix, n, m);

        // 3. Tìm số âm nhỏ nhất của ma trận
        double minNegative = double.MaxValue;
        foreach (var value in matrix)
        {
            if (value < 0 && value < minNegative)
            {
                minNegative = value;
            }
        }
        Console.WriteLine($"\nSmallest negative number in matrix: {minNegative}");

        // 4. Sắp xếp từng cột của ma trận theo thứ tự tăng dần
        for (int j = 0; j < m; j++)
        {
            double[] column = new double[n];
            for (int i = 0; i < n; i++)
            {
                column[i] = matrix[i, j];
            }
            Array.Sort(column);
            for (int i = 0; i < n; i++)
            {
                matrix[i, j] = column[i];
            }
        }
        Console.WriteLine("\nMatrix after sorting each column:");
        DisplayMatrix(matrix, n, m);

        // 5. Nhập số nguyên dương k, xóa cột thứ k của ma trận nếu có
        Console.Write("\nEnter the column number (k) to delete: ");
        int k = int.Parse(Console.ReadLine());
        if (k >= 0 && k < m)
        {
            double[,] newMatrix = new double[n, m - 1];
            for (int i = 0; i < n; i++)
            {
                int newColumnIndex = 0;
                for (int j = 0; j < m; j++)
                {
                    if (j == k) continue;
                    newMatrix[i, newColumnIndex] = matrix[i, j];
                    newColumnIndex++;
                }
            }
            m--;
            matrix = newMatrix;
            Console.WriteLine("\nMatrix after deleting column k:");
            DisplayMatrix(matrix, n, m);
        }
        else
        {
            Console.WriteLine("\nInvalid column number.");
        }

        // 6. Tính trung bình cộng các phần tử có giá trị chẵn trong ma trận
        double sumEven = 0;
        int countEven = 0;
        foreach (var value in matrix)
        {
            if (value % 2 == 0)
            {
                sumEven += value;
                countEven++;
            }
        }
        double avgEven = countEven > 0 ? sumEven / countEven : 0;
        Console.WriteLine($"\nAverage of even numbers in matrix: {avgEven}");
    }

    public static void DisplayMatrix(double[,] matrix, int n, int m)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

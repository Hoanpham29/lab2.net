using System;

public class Program
{
    public static void Main()
    {
        // 1. Nhap mot ma tran so thuc vuong cap n
        Console.Write("Nhap kich thuoc cua ma tran vuong (n): ");
        int n = int.Parse(Console.ReadLine());

        double[,] maTran = new double[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"Nhap phan tu tai vi tri [{i},{j}]: ");
                maTran[i, j] = double.Parse(Console.ReadLine());
            }
        }

        // 2. Hien thi ma tran
        Console.WriteLine("\nMa tran:");
        HienThiMaTran(maTran, n);

        // 3. Tinh tong cac phan tu nam tren duong cheo phu cua ma tran
        double tongCheoPhu = 0;
        for (int i = 0; i < n; i++)
        {
            tongCheoPhu += maTran[i, n - 1 - i];
        }
        Console.WriteLine($"\nTong cac phan tu tren duong cheo phu: {tongCheoPhu}");

        // 4. Tim so am lon nhat tren duong cheo chinh cua ma tran
        double soAmLonNhatCheoChinh = double.MinValue;
        for (int i = 0; i < n; i++)
        {
            if (maTran[i, i] < 0 && maTran[i, i] > soAmLonNhatCheoChinh)
            {
                soAmLonNhatCheoChinh = maTran[i, i];
            }
        }
        if (soAmLonNhatCheoChinh == double.MinValue)
        {
            Console.WriteLine("Khong co so am tren duong cheo chinh.");
        }
        else
        {
            Console.WriteLine($"\nSo am lon nhat tren duong cheo chinh: {soAmLonNhatCheoChinh}");
        }

        // 5. Dem cac phan tu cua ma tran co gia tri chia het cho 3 va 5
        int demChiaHetCho3Va5 = 0;
        foreach (var value in maTran)
        {
            if (value % 15 == 0)
            {
                demChiaHetCho3Va5++;
            }
        }
        Console.WriteLine($"\nSo phan tu chia het cho 3 va 5: {demChiaHetCho3Va5}");
    }

    public static void HienThiMaTran(double[,] maTran, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(maTran[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

using System;

public class Program
{
    public static void Main()
    {
        // 1. Nhap vao mot xau ky tu sau do hien thi xau ky tu vua nhap ra man hinh
        Console.Write("Nhap vao mot xau ky tu: ");
        string inputString = Console.ReadLine();
        Console.WriteLine("\nXau ky tu vua nhap: " + inputString);

        // 2. Dem xem trong xau co bao nhieu chu thuong, bao nhieu chu hoa
        int lowerCaseCount = 0, upperCaseCount = 0;
        foreach (char c in inputString)
        {
            if (char.IsLower(c)) lowerCaseCount++;
            if (char.IsUpper(c)) upperCaseCount++;
        }
        Console.WriteLine($"So chu thuong: {lowerCaseCount}");
        Console.WriteLine($"So chu hoa: {upperCaseCount}");

        // 3. Dem so tu trong xau vua nhap
        string[] words = inputString.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        int wordCount = words.Length;
        Console.WriteLine($"So tu trong xau: {wordCount}");

        // 4. Dem so phu am va nguyen am trong xau vua nhap
        int vowelCount = 0, consonantCount = 0;
        foreach (char c in inputString.ToLower())
        {
            if ("aeiou".Contains(c)) vowelCount++;
            else if (char.IsLetter(c)) consonantCount++;
        }
        Console.WriteLine($"So nguyen am: {vowelCount}");
        Console.WriteLine($"So phu am: {consonantCount}");

        // 5. Nhap vao mot xau con va dem so lan xuat hien cua xau con trong xau da nhap o tren
        Console.Write("Nhap vao mot xau con: ");
        string subString = Console.ReadLine();
        int subStringCount = 0, index = 0;
        while ((index = inputString.IndexOf(subString, index)) != -1)
        {
            subStringCount++;
            index += subString.Length;
        }
        Console.WriteLine($"So lan xuat hien cua xau con '{subString}' trong xau da nhap: {subStringCount}");
    }
}

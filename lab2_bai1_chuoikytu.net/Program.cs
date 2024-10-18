using System;
namespace Csharp
{
    class TestCsharp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("So sanh chuoi trong C#");
            Console.WriteLine("-------------------------------");
            string str1 = "So sanh chuoi trong C#";
            string str2 = "So sanh chuoi trong Csharp";
            if (String.Compare(str1, str2) == 0)
            {
                Console.WriteLine(str1 + "va" + str2 + "la giong nhau");
            }
            else
            {
                Console.WriteLine(str1 + " va" + str2 + "la khong giong nhau."); 
            }
            Console.ReadKey();
        }
    }
}
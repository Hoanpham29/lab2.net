using System;
namespace Csharp
{
    class TestCsharp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiem tra chuoi con trong C#");
            Console.WriteLine("---------------------------");
            string str = "Chuoi con trong C#";
            if (str.Contains("trong"))
            {
                Console.WriteLine("Tim thay chuoi con 'trong'.");
            }
            Console.ReadKey();
        }
    }
}
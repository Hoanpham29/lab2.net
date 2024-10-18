using System;
namespace Csharp
{
    class TestCsharp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lay chuoi con trong C#");
            Console.WriteLine("-----------------------");
            string str = "Lay chuoi con trong C#";
            Console.WriteLine("Chuoi ban dau: " + str);
            string substr = str.Substring(10);
            Console.WriteLine("Chuoi con: " + substr);
            Console.ReadKey();
        }
    }
}
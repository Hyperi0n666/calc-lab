using System;

namespace CalcLab
{
    internal static class Program
    {
        private static void Main()
        {
            var calc = new Calculator();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("=== Калькулятор ===");
                Console.WriteLine("1. Ввести A");
                Console.WriteLine("2. Ввести B");
                Console.WriteLine("3. Выполнить операцию \"+\"");
                Console.WriteLine("4. Выполнить операцию \"-\"");
                Console.WriteLine("5. Выполнить операцию \"*\"");
                Console.WriteLine("6. Выполнить операцию \"/\"");
                Console.WriteLine("0. Выход");
                Console.Write("Выбор: ");

                string choice = Console.ReadLine();
                if (choice == null) return;

                try
                {
                    switch (choice.Trim())
                    {
                        case "1": calc.ReadA(); break;
                        case "2": calc.ReadB(); break;
                        case "3": calc.Add(); break;
                        case "4": calc.Sub(); break;
                        case "5": calc.Mul(); break;
                        case "6": calc.Div(); break;
                        case "0": return;
                        default: Console.WriteLine("Неизвестный пункт меню."); break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка: " + e.Message);
                }
            }
        }
    }
}

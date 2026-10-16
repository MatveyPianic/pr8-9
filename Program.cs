using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Проверка чередования регистра букв ===");
        Console.WriteLine("Вариант 8\n");

        char[][] arrays = ArrayInput.ReadArrays();
        ArrayOutput.PrintArrays(arrays);

        Console.WriteLine("\n=== Результаты проверки ===");
        ArrayLogic.CheckArrays(arrays);

        Console.WriteLine("\nНажмите любую клавишу...");
        Console.ReadKey();
    }
}
using System;

public static class ArrayLogic
{
    public static bool IsAlternatingCase(char[] array)
    {
        if (array == null || array.Length < 2)
            return false;

        for (int i = 1; i < array.Length; i++)
        {
            bool prevUpper = char.IsUpper(array[i - 1]);
            bool currUpper = char.IsUpper(array[i]);
            if (prevUpper == currUpper)
                return false;
        }
        return true;
    }

    public static void CheckArrays(char[][] arrays)
    {
        bool found = false;
        for (int i = 0; i < arrays.Length; i++)
        {
            if (IsAlternatingCase(arrays[i]))
            {
                Console.WriteLine($"Массив №{i + 1}: чередование есть");
                found = true;
            }
            else
            {
                Console.WriteLine($"Массив №{i + 1}: чередования нет");
            }
        }
        if (!found)
            Console.WriteLine("Ни в одном массиве нет чередования регистра.");
    }
}
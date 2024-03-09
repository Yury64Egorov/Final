using System;

class Program
{
    static void Main()
    {
        // Входной массив строк
        string[] inputArray = { "Hello", "2", "world", ":-)" };

         // Вызываем функцию фильтрации и выводим результат
        string[] outputArray = FilterShortStrings(inputArray);
        Console.WriteLine("Результат:");
        foreach (string str in outputArray)
        {
            Console.WriteLine(str);
        }
    }

    static string[] FilterShortStrings(string[] arr)
    {
        // Считаем количество строк, подходящих по условию
        int count = 0;
        foreach (string str in arr)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }
 // Создаем новый массив нужной длины
        string[] result = new string[count];
        int index = 0;

        // Заполняем новый массив подходящими строками
        foreach (string str in arr)
        {
            if (str.Length <= 3)
            {
                result[index] = str;
                index++;
            }
        }

        return result;
    }
        
}

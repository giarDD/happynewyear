// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. |
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите массив:");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(',');

        string[] resultArray = FilterStrings(inputArray);

        Console.WriteLine("Результат:");
        Console.WriteLine(string.Join(", ", resultArray));
    }

    static string[] FilterStrings(string[] inputArray)
    {
    
        int count = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                count++;
            }
        }
        string[] resultArray = new string[count];
        int index = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                resultArray[index] = inputArray[i];
                index++;
            }
        }

        return resultArray;
    }
}

using System.Collections.Generic;
using System;
using System.Linq;
public class Program
{
    public static void Main(string[] args)
    {
        bool success = false;
        int size = 0;
        do
        {
            Console.WriteLine("Введите размер коллекции:");
            success = int.TryParse(Console.ReadLine(), out size);
            if (!success)
            {
                Console.WriteLine("ОШИБКА! Введенно неверное значение. Попробуйте еще раз.");
            }
        }
        while (!success);

        Random random = new Random();
        List<int> numbers = new List<int>();
        for (int i = 0; i < size; i++)
        {
            numbers.Add(random.Next(0, 10000));
        }

        Console.WriteLine("Начальная коллекция :");
        foreach (int number in numbers)
        {
            Console.Write($"{number} ");
        }

        Console.WriteLine();

        List<int> result = numbers.OrderBy(x => x)
                                  .Where((x, i) => i + 1 > numbers.Count / 2)
                                  .OrderByDescending(x => x)
                                  .Select(x => x * x)
                                  .ToList();

        Console.WriteLine("Начальная коллекция :");
        foreach (int number in result)
        {
            Console.Write($"{number} ");
        }

        Console.WriteLine();
    }
}
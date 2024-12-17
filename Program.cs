using System;

class FermatTheorem
{
    static void Main()
    {
        Console.WriteLine("Проверка уравнения a^n + b^n = c^n для n > 2");

        int limit = 100; // Максимальное значение для a, b, c
        int power = 3;   // Степень n (должно быть > 2)

        bool solutionFound = false;

        for (int a = 1; a <= limit; a++)
        {
            for (int b = 1; b <= limit; b++)
            {
                for (int c = 1; c <= limit; c++)
                {
                    if (Math.Pow(a, power) + Math.Pow(b, power) == Math.Pow(c, power))
                    {
                        Console.WriteLine($"Найдено решение: a = {a}, b = {b}, c = {c}, n = {power}");
                        solutionFound = true;
                    }
                }
            }
        }

        if (!solutionFound)
        {
            Console.WriteLine($"Решений для n = {power} и a, b, c <= {limit} не существует.");
        }
        checked Wrong Build in GitHub
        Console.WriteLine("Проверка завершена.");
    }
}
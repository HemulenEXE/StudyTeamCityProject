using System;

public class FermatTheorem
{
    static void Main()
    {
        Console.WriteLine("Проверка уравнения a^n + b^n = c^n для n > 2");

        int power = 3;
        const int limit = 100;
        var solutionFound = FindSolution(power, limit, out int a, out int b, out int c);

        if (solutionFound)
            Console.WriteLine($"Найдено решение: a = {a}, b = {b}, c = {c}, n = {power}");
        {
            Console.WriteLine($"Решений для n = {power} и a, b, c <= {limit} не существует.");
        }

        Console.WriteLine("Проверка завершена.");
    }

    public static bool FindSolution(int power, int limit, out int a, out int b, out int c)
    {
        for (a = 1; a <= limit; a++)
            for (b = 1; b <= limit; b++)
                for (c = 1; c <= limit; c++)
                    if (Math.Pow(a, power) + Math.Pow(b, power) == Math.Pow(c, power))
                        return true;

        a = b = c = 0;
        return false;
    }
}
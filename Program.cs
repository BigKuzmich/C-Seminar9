using System;

void Task1()
{
    int n = InputInt("Введите положительное число");
    int m = 1;
    if (n < 1)
    {
        Console.WriteLine("Ввели не положительное число");
    }
    Console.WriteLine(NaturalNumber(n, m));

    int NaturalNumber(int n, int m)
    {
        if (n == m)
            return n;
        else
            Console.Write($"{NaturalNumber(n, m + 1)}, ");
        return m;
    }

    int InputInt(string output)
    {
        Console.Write(output);
        return int.Parse(Console.ReadLine());
    }
}

void Task2()
{
    int m = InputInt("Введите M:");
    int n = InputInt("Введите N:");
    Console.WriteLine($"Сумма элементов от {m} до {n} = {CountNaturalSum(m, n)}");

    int InputInt(string output)
    {
        Console.Write(output);
        return int.Parse(Console.ReadLine());
    }

    int CountNaturalSum(int m, int n)
    {
        if (m == n)
            return n;
        return n + CountNaturalSum(m, n - 1);
    }
}

void Task3()
{
    Console.WriteLine("Введите два положительных числа: M и N.");
    int m = InputInt("Введите M: ");
    int n = InputInt("Введите N: ");
    Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");

    int InputInt(string output)
    {
        Console.Write(output);
        return int.Parse(Console.ReadLine());
    }

    int Akkerman(int m, int n)
    {
        if (m == 0)
            return n + 1;
        if (m > 0 && n == 0)
            return Akkerman(m - 1, 1);
        else
            return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}

while (true)
{
    Console.WriteLine("Введите номер задачи");
    int a = int.Parse(Console.ReadLine());
    if (a == 1)
    {
        Task1();
    }
    if (a == 2)
    {
        Task2();
    }
    if (a == 3)
    {
        Task3();
    }
}
// Задача 1 - Вычислить фактоориал от натурального числа N

// Этаапы создания рекрсии
// 1. Рекрсивный вызов
// 2. Условия остановки рекурсии

int Fact(int n)
{
    if (n == 1 || n == 0)
    {
        Console.WriteLine("Stop: {n}");
        return 1;
    }
    Console.WriteLine(n);
    return n * Fact(n - 1);
}

Console.Write(Fact(5));
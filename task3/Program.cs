// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AkkermanRec(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return AkkermanRec(m - 1, 1);
    return (AkkermanRec(m - 1, AkkermanRec(m, n - 1)));
}

Console.Write("Введите целое число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A({m},{n}) = {AkkermanRec(m, n)}");
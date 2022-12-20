// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
int temp = 1;
Console.WriteLine($"{N} -> {Posl(N)}");
Console.WriteLine($"{N} ->{Posled(N,temp)}");

string Posl(int N)
{
    string res = "";
    int temp = 1;
    while (true)
    {
        res = temp + " " + res;
        temp++;
        if (temp - 1 == N)
            break;
    }
    return res;
}

string Posled(int N, int temp)
{
    if (temp > N) return "";
    else return Posled(N, temp + 1) + " " + Convert.ToString(temp);
}
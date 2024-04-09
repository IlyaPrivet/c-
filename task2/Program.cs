// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akkerman (int n, int m)
{
    if (n == 0) return m = m + 1;
    if (m == 0) return Akkerman(n-1,1);
    return Akkerman(n-1, Akkerman(n, m-1));
}

Console.Write("Введите значение M: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine()!);

if (m < 0 || n < 0) Console.WriteLine("Числа должны быть положительными");
else Console.WriteLine($"{Akkerman(n,m)}");

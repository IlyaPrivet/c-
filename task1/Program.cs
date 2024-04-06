// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

int RecursiveNumber(int start, int finish)
{
    Console.Write($"{start} ");
    if (start == finish) return 0;
    return RecursiveNumber(start+1, finish);
}

Console.Write("Введите значение M: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine()!);

if (m > n) Console.WriteLine("M должно быть меньше N");
else RecursiveNumber(m,n);


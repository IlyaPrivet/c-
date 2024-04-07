// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

void PrintArray(int[] array, int i)
{
    if (i == array.Length) return;
    // for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
    // Console.WriteLine();
    Console.Write($"{array[i]} ");
    PrintArray(array,i+1);
}


int[] FillInArray(int n)
{
    int[] array = new int [n];
    for (int i = 0; i < n; i++) array[i] = new Random().Next(0,100);
    Console.WriteLine("Оригинал:");
    // PrintArray(array);
    PrintArray(array, 0);
    return array;
}


void ReverseArray(int[] array, int i)
{   
    if (i < 0) return;
    Console.Write($"{array[i]} ");    
    ReverseArray(array, i-1);
}

Console.Write("Введите длину массива: ");
int[] arrayfirst = FillInArray(int.Parse(Console.ReadLine()!));
Console.WriteLine("Реверс:");
ReverseArray(arrayfirst, arrayfirst.Length-1);


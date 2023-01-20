// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array = new int[m, n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 15);

        Console.Write($"{array[i, j]} ");

    }
    Console.WriteLine();
}
Console.WriteLine();

int minSum = 0;
int minLine = 0;
int sum = 0;

for (int i = 0; i < array.GetLength(1); i++)
{
    minSum = minSum + array[0, i];
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        sum = sum + array[i, j];
    if (sum < minSum)
    {
        minSum = sum;
        minLine = i;
    }
    sum = 0;
}
Console.Write($"Наименьшая строка № {minLine + 1} , значение которой равно {minSum}.");



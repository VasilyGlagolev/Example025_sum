// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3
int[,] array = new int[3, 4];

Console.WriteLine("Введите элементы массива:");

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write("Элемент [{0}, {1}]: ", i, j);
        array[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("Массив:");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write("{0}\t", array[i, j]);
    }
    Console.WriteLine();
}

double[] averages = new double[array.GetLength(1)];
for (int j = 0; j < array.GetLength(1); j++)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    averages[j] = (double)sum / array.GetLength(0);
}

Console.WriteLine("Среднее арифметическое каждого столбца:");
for (int j = 0; j < array.GetLength(1); j++)
{
    Console.Write("{0:F1}\t", averages[j]);
}
Console.WriteLine();

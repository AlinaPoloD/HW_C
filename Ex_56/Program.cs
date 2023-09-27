/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int IndexLineMin(int[,] array)
{

    int[] sumLine = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
            sumLine[i] = sum;
        }

    }
    int minSum = sumLine[0];
    int index = 0;
    for (int n = 1; n < sumLine.Length; n++)
    {
        if (sumLine[n] < minSum)
            index = n;
    }
    return index;

}



void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,] array = {
        {1, 4, 7, 2},
        {5, 9, 2, 3},
        {8, 4, 2, 4},
        {5, 2, 6, 7}
        };

PrintArray(array);
Console.WriteLine($"Номер строки с наименьшей суммой элементов:{IndexLineMin(array)+1}");
﻿/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/


int[,] GetArray(int rows, int cols, int min = 1, int max = 10)
{
    int[,] array = new int[rows, cols];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 15);
        }

    }
    return array;

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

void GetSortArray(int[,] array)
{
    if (array.GetLength(1) == 1)
    {
        Console.WriteLine("Всего один элемент в строке,массив остался прежним");
    }
    else
    {
        Console.WriteLine("Массив отсортирован");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int n = 0; n < array.GetLength(1); n++)
            {

                for (int j = 0; j < array.GetLength(1) - 1; j++)
                {
                    if (array[i, j] < array[i, j + 1])
                    {
                        int temp = array[i, j];
                        array[i, j] = array[i, j + 1];
                        array[i, j + 1] = temp;
                    }
                }
            }
        }
    }


}

int[,] array = GetArray(3, 4);


PrintArray(array);
GetSortArray(array);
PrintArray(array);

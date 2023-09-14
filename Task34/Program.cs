/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/


int[] GetArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = new Random().Next(minValue, maxValue + 1);
	}

	return array;
}

void PrintArray(int[] array)
{
    foreach (int a in array)
    {
        Console.Write(a + " ");
    }
}

int CountEven(int[] array) 
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Введите количество элементов в массиве: ");

int length = Convert.ToInt32(Console.ReadLine());
int minValue = 100;
int maxValue = 999;
int[] massive = GetArray(length, minValue, maxValue);
Console.Write("Массив:[ ");
PrintArray(massive);
Console.WriteLine("]");
Console.WriteLine("Количество чётных чисел в массиве: " + CountEven(massive));
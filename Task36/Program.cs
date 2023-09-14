/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

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
    Console.Write("Массив:[ ");
    foreach (int a in array)
    {
        Console.Write(a + " ");
    }
    Console.WriteLine("]");
}

int sumOddPositions(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
        {
            sum += array[i];
        }
    }
    return sum;
}



Console.WriteLine("Введите количество элементов в массиве: ");

int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число в диапазоне: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число в диапазоне: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

checkMinMax();

void checkMinMax()
{
    if (minValue < maxValue)
    {
        int[] massive = GetArray(length, minValue, maxValue);
        PrintArray(massive);
        Console.WriteLine("Cумма элементов, стоящих на нечётных позициях = " + sumOddPositions(massive));
    }
    else Console.WriteLine("Миниальное число должно быть меньше максимального!");
}
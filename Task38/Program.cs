/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76*/

double[] GetArray(int length, double minValue, double maxValue)
{
    double[] array = new double[length];
    for (int i = 0; i < array.Length; i++)

    {
        array[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;
    }

    return array;
}

void PrintArray(double[] array)
{
    Console.Write("Массив:[ ");
    foreach (double a in array)
    {
        Console.Write($"{a:f}" + " ");
    }
    Console.WriteLine("]");
}

double GetMax(double[] array)
{
    double max = array[0];
    int length = array.Length;
    for (int i = 1; i < length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }

    return max;
}

double GetMin(double[] array)
{
    int length = array.Length;
    double min = array[0];
    for (int i = 1; i < length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}


Console.WriteLine("Введите количество элементов в массиве: ");

int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число в диапазоне: ");
double minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число в диапазоне: ");
double maxValue = Convert.ToInt32(Console.ReadLine());

checkMinMax();

void checkMinMax()
{
    if (minValue < maxValue)
    {
        double[] massive = GetArray(length, minValue, maxValue);
        PrintArray(massive);
        Console.WriteLine("Разница между максимальным и минимальным элементами массива" + $" = {(GetMax(massive) - GetMin(massive)):f}");
    }
    else Console.WriteLine("Миниальное число должно быть меньше максимального!");
}
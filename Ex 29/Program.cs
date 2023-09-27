
/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/
Console.WriteLine("Введите количество чисел которое вы хотите ввести: ");
int count = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите диапазон значений массива. ");
Console.WriteLine("Начальное значение для диапазона случайного числа: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Максимальное значение для диапазона случайного числа: ");
int max = Convert.ToInt32(Console.ReadLine());



PrintMassive(GenerateMassive(min, max, count));


int [] GenerateMassive (int minValue, int maxValue, int count)
{
    int [] massive = new int[count];
    
    for (int i = 0; i < massive.Length; i++)
    {

     int value = new Random().Next(minValue,maxValue-1);
        massive[i] = value;
    }
    return massive;
    }


    void PrintMassive(int [] massive) {
    Console.Write("[");
   
    for (int i = 0; i < massive.Length-1; i++)
    {
        Console.Write($"{massive[i]}, ");
    }
    Console.Write(massive[massive.Length - 1]);
    Console.Write("]");
    }
   
    

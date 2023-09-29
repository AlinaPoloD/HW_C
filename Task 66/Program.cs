/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int SumElements(int m, int n)
{   
    if (m > n) return 0;
    return m + SumElements(m + 1, n);
}

void PrintSumElements(int m, int n)
{
    if (m >= n) 
    {
        Console.WriteLine($"Число {m} должно быть меньше чем {n}");
    }
    else Console.WriteLine(SumElements(m, n));
}
PrintSumElements(1,15);
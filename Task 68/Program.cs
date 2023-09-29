/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/



int FunctionAckermann(int m, int n)
{   int func = 0;
    if (m==0) func = n + 1;
    if (m > 0 && n==0) func = FunctionAckermann(m-1,1);
    if (m > 0 && n > 0) func = FunctionAckermann(m-1,FunctionAckermann(m, n-1));
    return func;
}

void PrintSumElements(int m, int n)
{
    if (m < 0 || n < 0) 
    {
        Console.WriteLine($"Числа должны быть больше 0 и m не больше 3");
    }
    else if (m > 3) Console.WriteLine($"Число m должно быть от 0 до 3");
    else if (m ==3 && n > 10) Console.WriteLine($"Раз число m равно 3, n должно быть не больше 10");
    else Console.WriteLine(FunctionAckermann(m, n));
}
PrintSumElements(1,10000);
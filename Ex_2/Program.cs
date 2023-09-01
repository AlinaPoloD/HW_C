/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/


Console.WriteLine("Введите два числа, чтобы узнать какое из них большее ");
int numA = Convert.ToInt32(Console.ReadLine()!);
int numB = Convert.ToInt32(Console.ReadLine()!);
if (numA != numB)
{
    int max = numB > numA ? numB : numA;
    Console.WriteLine("max = " + max);
}
else { Console.WriteLine("Два числа равны"); }


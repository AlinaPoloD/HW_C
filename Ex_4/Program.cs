/*  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.WriteLine("Введите три числа, чтобы узнать какое из них максимальное ");
int numA = Convert.ToInt32(Console.ReadLine()!);
int numB = Convert.ToInt32(Console.ReadLine()!);
int numC = Convert.ToInt32(Console.ReadLine()!);
int max = 0;
if (numA > numB)
{
   max = numA > numC ? numA : numC ;
}
else if (numB > numC) {
max = numB ;
}
else max = numC ;
Console.WriteLine("max = " + max);
/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/



int a = Convert.ToInt32(Console.ReadLine());
   int b = Convert.ToInt32(Console.ReadLine());

int Degree(int a, int b)
{

    if (b > 0)
    {
        return Convert.ToInt32(Math.Pow(a, b));
    }
    else return 0;

}
void printResult()
{
    if (Degree(a, b) == 0)
    {
        Console.WriteLine("Степень должна быть больше 0!");
    }

    else
    {
        Console.WriteLine($"Число {a} в степени {b} = {Degree(a, b)}");
    }
    }
  
    printResult();





/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int[,,] GetArray(int firstLength, int secondLength, int thirdLength)
{
    int[,,] array = new int[firstLength, secondLength, thirdLength];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int n = 0; n < array.GetLength(2); n++)
            {
                int temp = new Random().Next(10, 99+1);
                while (isContains(array, temp))
                {
                    temp = new Random().Next(10, 99+1);
                }
                array[i, j, n] = temp;
                
            }

        }

    }
    return array;

}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int n = 0; n < array.GetLength(2); n++)
            {
                Console.WriteLine($"{array[i, j, n]} ({i}, {j}, {n})");
            }

        }

    }

}
bool isContains(int[,,] array, int element)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int n = 0; n < array.GetLength(2); n++)
            {
                if (array[i, j, n] == element) return true;
            }
        }
    }
    return false;
}

int[,,] array = GetArray(2, 2, 2);
PrintArray(array);
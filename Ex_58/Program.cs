/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}



int[,] ProductMatrix(int[,] arrayFirst, int[,] arraySecond)
{

    int[,] productMatrix = new int[arrayFirst.GetLength(0), arraySecond.GetLength(1)];
    for (int i = 0; i < productMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < productMatrix.GetLength(1); j++)
        {
            for (int n = 0; n < arrayFirst.GetLength(1); n++)
            {
                productMatrix[i, j] += arrayFirst[i, n] * arraySecond[n, j];
            }

        }
    }
    return productMatrix;
}



bool CheckMatrix(int[,] arrayFirst, int[,] arraySecond)
{
    if (arrayFirst.GetLength(1) != arraySecond.GetLength(0)) return false;
    else return true;
}


void PrintProductMatrix(int[,] arrayFirst, int[,] arraySecond)
{
    if (CheckMatrix(arrayFirst, arraySecond))
    {
        Console.WriteLine("Произведение матриц: ");
        int[,] productMatrix = ProductMatrix(arrayFirst, arraySecond);


        for (int i = 0; i < productMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < productMatrix.GetLength(1); j++)
            {
                Console.Write(productMatrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    else Console.WriteLine("Невозможно посчитать произведение матриц, так как количество столбцов первой матрицы и количество строк второй матрицы не совпадают!");
}



/*int[,] matrixFirst = {
        {2,4},
        {3,2}
        };

int[,] matrixSecond = {
        {3,4,3},
        {3,3,4},
        {5,8,8}
        };*/
int[,] matrixFirst = {
        {2,4},
        {3,2}
        };

int[,] matrixSecond = {
        {3,4,3},
        {3,3,4}
        };

Console.WriteLine($"Первая матрица: ");
PrintArray(matrixFirst);
Console.WriteLine($"Вторая матрица: ");
PrintArray(matrixSecond);
PrintProductMatrix(matrixFirst, matrixSecond);

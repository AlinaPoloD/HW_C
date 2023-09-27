/*Задача 62. Напишите программу, которая заполнит спирально прямоугольный массив.
Например, на выходе может получиться вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

int[,] GetArray(int rows, int min = 1, int max = 10)
{
    int[,] array = new int[rows, rows];
    int value = 1;
    int count = rows * rows;
    int i = 0;
     int j = 0;
 
    while (value <= count){
    
    
    array[i,j] = value;
    value++;
    if (i <= j + 1 && i + j < rows - 1)
    j++;
  else if (i < j && i + j >= rows - 1)
    i++;
  else if (i >= j && i + j > rows - 1)
    j--;
  else
    i--;
    }

/*
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < rows-1; j++)
        {
        if (i == 0){
            array[i, j] = value++;
            count ++;
        }
        else if (i==1) continue;
        }
        
        array[i, rows-1] = value++;
            count++;

}
for (int j = rows - 2 ; j >= 0; j--)
{
            array[rows-1, j] = value++;
            count++;
            
}
*/










   /*
        
        for (int j = array.GetLength(1) - 2 ; j >= 0; j--)
        {
            array[array.GetLength(0)-1, j] = value++;
            count++;
            
        }
        for (int i = array.GetLength(0) - 2 ; i > 0; i--)
        {
            array[i, 0] = value++;
            count++;
            
        }
        

        }*/



    
        /*int j = 0;
        int i = 0;
        
        while (j < array.GetLength(1))
        {
            array[i, j] = value++;
            j++;
        }

        for (i = 1; i< array.GetLength(0);i++)
        {   j = array.GetLength(1) - 1;
            array[i, j] = value++;
         */   
       // }

    
    return array;

}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j].ToString("00") + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] array = GetArray(10);
PrintArray(array);
// Сформируйте трёхмерный массив двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] CreateMatrix(int x, int y, int z, int leftRange, int rightRange)
{
    int[,,] matrix = new int[x, y, z];
    Random rand = new Random();

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                matrix[i, j, k] = rand.Next(leftRange, rightRange + 1);
            }
        }
    }
    return matrix;
}

void PrintArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                System.Console.Write($"{matrix[i, j, k]} ({i},{j},{k}) \t");
            }
            System.Console.WriteLine();
        }
    }
}


int[,,] myMatrix = CreateMatrix(2, 2, 2, 10, 99);
PrintArray(myMatrix);
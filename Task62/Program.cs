//Заполните спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//1   2  3 4
//12 13 14 5
//11 16 15 6
//10  9  8 7

Console.Clear();

//Метод вывода матрицы в консоль
void PrintMatrix(int[,] array)
{
    //Выводим все элементы, за исключением последнего
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1);j++)
        {   
            if(array[i,j]<10) Console.Write($"  {array[i,j]}");
            else Console.Write($" {array[i,j]}");        
        }
        Console.WriteLine();
    }
}

//Метод заполнения улитки
int[,] FillSnail(int[,] matrix)
{
    for (int startPosition = 0; startPosition < matrix.GetLength(0) / 2; startPosition++)
    {
        int steps = matrix.GetLength(0) - 1 - startPosition;
        int value = (steps + 1) * 4 * startPosition + 1;
        for (int i = startPosition; i < steps; i++)
        {
            matrix[startPosition, i] = value;
            matrix[i, steps] = value + steps - startPosition;
            matrix[steps, steps - i + startPosition] = value + (steps - startPosition) * 2;
            matrix[steps - i + startPosition, startPosition] = value + (steps - startPosition) * 3;
            value++;
        }
    }
    //Для нечетных матриц заполняем центр
    if (matrix.GetLength(0) % 2 != 0)
    {
        matrix[matrix.GetLength(0)/2,matrix.GetLength(1)/2]=matrix.GetLength(0)*matrix.GetLength(1);
    }
    return matrix;
}

Console.WriteLine("Введите размер квадратной матрицы ");
int sizeMatrix = Convert.ToInt32(Console.ReadLine());
int[,] matrix= new int[sizeMatrix,sizeMatrix];


FillSnail(matrix);
PrintMatrix(matrix);
//Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//1 2 4 7
//2 3 5 9
//2 4 4 8

Console.Clear();

//Метод вывода матрицы в консоль
void PrintMatrix(int[,] array)
{
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

//Метод заполнения массива случайными значениями
int[,] FillMatrix(int[,] matrix,Random rnd)
{
   for(int i=0;i<matrix.GetLength(0);i++)
   {
        for(int j=0; j<matrix.GetLength(1);j++)
        {
            matrix[i,j]=rnd.Next(1,10);
        }
   }
    return matrix;
}

//Метод сортировки строк матрицы
int [,] SortLine(int[,] matrix)
{
    int tmp;
    for(int j=0;j < matrix.GetLength(0); j++)
    {
        for(int i=0;i<matrix.GetLength(1)-1; i++)
        {
            for(int k=i+1;k<matrix.GetLength(1); k++)
            {
                if (matrix[j,i]>matrix[j,k])
                {
                    tmp=matrix[j,i];
                    matrix[j,i]=matrix[j,k];
                    matrix[j,k]=tmp;
                }
            }

        }
        
    }
    return matrix;
}

Random rnd = new Random();
int[,] matrix= new int[rnd.Next(4,6),rnd.Next(3,5)];

matrix=FillMatrix(matrix,rnd);
Console.WriteLine("Исходная матрица");
PrintMatrix(matrix);
Console.WriteLine("Отсортированная матрица");
matrix=SortLine(matrix);
PrintMatrix(matrix);
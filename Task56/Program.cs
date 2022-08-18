//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

//Метод поиска строки с наименьшой суммой
int MinSumLine(int[,] matrix)
{
    int line=0,min=0,sum=0;
    for(int i=0;i < matrix.GetLength(0); i++)
    {
        for(int j=0;j<matrix.GetLength(1); j++)
        {
            sum=matrix[i,j]+sum;
        }
        
        if(i==0 || min>sum)
        {
         min=sum;
         line=i+1;   
        }
        sum=0;
     }
    return line;
}

Random rnd = new Random();
int[,] matrix= new int[rnd.Next(4,6),rnd.Next(3,5)];
matrix=FillMatrix(matrix,rnd);
Console.WriteLine("Исходная матрица");
PrintMatrix(matrix);
Console.WriteLine($"Строка с наименьшой суммой элементов - {MinSumLine(matrix)}");

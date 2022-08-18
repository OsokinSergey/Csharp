 //Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, заданы 2 массива:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//и
//1 5 8 5
//4 9 4 2
//7 2 2 6
//2 3 4 7
//Их произведение будет равно следующему массиву:
//1 20 56 10
//20 81 8 6
//56 8 4 24
//10 6 24 49

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

//Метод умножения двух матриц
int[,] Multiplication(int[,] matrix1,int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0),matrix1.GetLength(0)];
    for(int i=0;i < matrix1.GetLength(0); i++)
    {
        for(int j=0;j<matrix1.GetLength(1); j++)
        {
            result[i,j]=matrix1[i,j]*matrix2[i,j];
        }
       
    }
    return result;
}

Random rnd = new Random();
int rows =rnd.Next(4,6);
int columns =rnd.Next(3,5);

int[,] matrix1= new int[rows,columns];
int[,] matrix2= new int[rows,columns];

matrix1=FillMatrix(matrix1,rnd);
Console.WriteLine("Первая матрица");
PrintMatrix(matrix1);
matrix2=FillMatrix(matrix2,rnd);
Console.WriteLine("Вторая матрица");
PrintMatrix(matrix2);
Console.WriteLine("Матрица произведения");
PrintMatrix(Multiplication(matrix1,matrix2));

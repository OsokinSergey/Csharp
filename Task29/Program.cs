//Задача 29: Напишите программу, которая задаёт массив из 8 элементов, заполненный
//псевдослучайными числами и выводит их на экран.
//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] FillArray(int[] inputArray)
{
    Random rnm = new Random();
    for(int i=0; i < inputArray.Length;i++)
    {
        inputArray[i]=(int)rnm.Next(0,99);
    }
    return inputArray;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    //Выводим все элементы, за исключением последнего
    for(int i=0; i < array.Length-1;i++)
    {
        Console.Write($"{array[i]}, ");
    }
    //За последним элементом не должны следовать запятая и пробел.
    Console.WriteLine($"{array[array.Length-1]}]");
}

int[] array = new int[8];
PrintArray(FillArray(array));

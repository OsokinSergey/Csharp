//Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

//Meтод заполнения случайными положительными
//трехзначными числами
Console.Clear();
int[] FillArray(int[] inputArray)
{
    Random rnm = new Random();
    for(int i=0; i < inputArray.Length;i++)
    {
        inputArray[i]=(int)rnm.Next(100,1000);
    }
    return inputArray;
}

//Метод вывода результата в консоль
void PrintResult(int[] array, int evenNumber)
{
    Console.Write("[");
    //Выводим все элементы, за исключением последнего
    for(int i=0; i < array.Length-1;i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length-1]}] -> {evenNumber}");
}

//Метод подсчета четных
int EvenCount(int[] inputArray)
{
    int evenCount=0;
    for(int i=0; i<inputArray.Length;i++)
    {
        if(inputArray[i]%2==0) evenCount++;
    }
    return evenCount;
}

//Размер массива может быть произвольным
//В данном случае - в диапазоне от 3 до 9
int sizeArray = new Random().Next(3,10);
int[] threeDigitArray= new int[sizeArray];
threeDigitArray=FillArray(threeDigitArray);
PrintResult(threeDigitArray,EvenCount(threeDigitArray));
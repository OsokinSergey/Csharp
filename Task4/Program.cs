Console.Clear();
Console.Write("Введите первое число: ");
int maxNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
if (secondNum>maxNum)
{
    maxNum=secondNum;
}
Console.Write("Введите третье число: ");
int thirdNum = Convert.ToInt32(Console.ReadLine());
if (thirdNum>maxNum)
{
    maxNum=thirdNum;
}

Console.WriteLine($"Максимальным является число {maxNum}");

Console.Clear();
Console.Write("Введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

if (firstNum==secondNum){
    Console.WriteLine("Введенные числа равны");
    return;
}

if (firstNum>secondNum)  
{
    Console.WriteLine($"max = {firstNum}, min = {secondNum}");
}
else
{
    Console.WriteLine($"max = {secondNum}, min = {firstNum}");
}


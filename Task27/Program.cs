//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int SumNumber(int number)
{
    //Инициализируем результирующую переменную последней цифрой входного числа
    int result=number%10;
    while(number>9) {
        //"Обрезаем" последнюю цифру
        number=number/10;
        result=result+number%10;
    }
    return result;
}


Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{number} -> {SumNumber(number)}");
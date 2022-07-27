Console.Write("Введите пятизначное число ");
int num=Convert.ToInt32(Console.ReadLine());
if(num > 99999 || num < 10000 )
{
    Console.Write("Необходимо пятизначное число");
    return;
}

if(Reverse(num)==num) Console.WriteLine($"{num} -> Да");
else Console.WriteLine($"{num} -> Нет");

int Reverse(int num) 
{
    //Начальная инициализация
    int reverse=num%10;
    //Теперь последняя цифра входного числа стала первой цифрой выходного числа.
    //Далее организовываем цикл по оставшимся цифрам входного числа
    while(num>9)
    {   //Сбрасываем последний разряд у входного числа
        num=num/10;
        //Добавляем разряд к выходному числу и прибавляем остаток
        reverse=reverse*10+num%10;
    }
    return reverse;
}

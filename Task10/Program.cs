/*
Опеределим два режима ввода: ручной и автоматический
При ручном вводе программа получает значение и проверяет
на соответствие условиям - трехзначное число
При автоматическом режиме число генерируется случайным образом
*/
Console.WriteLine("Выберете способ ввода трехзначного числа");
Console.WriteLine("1 - ручной ввод, 2 - автоматический");
int input = Convert.ToInt32(Console.ReadLine());
int ?num=null;
if(input != 1 & input != 2) {
    Console.WriteLine("Нет такого режима");
    return;
}

if(input==1)
{
    //Ручной режим
    Console.WriteLine("Введите число");
    num=Convert.ToInt32(Console.ReadLine());
    //Проверяем, что число трехзначное
    if(num < 100 ^ num > 999)
    {
        Console.WriteLine("Ошибка ввода. Требуется трехзначное число");
        return;
    }
}
else
{
    //Автоматический режим    
    num=new Random().Next(100,1000);
}

if(num!=null){
    int result=(int)(num%100)/10;
    Console.WriteLine($"Второй цифрой числа {num} является {result}");
}


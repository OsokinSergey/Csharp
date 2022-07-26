int num=new Random().Next(10,10000000);
int result=ThirdDig(num);

if(result!=-1) Console.WriteLine($"{num} -> {result}");
else Console.WriteLine("Третьей цифры нет");

int ThirdDig(int num)
{   
    if(num<100)
    {
        //Третьей цифры нет точно
         num=-1;
    }
    else
    {   //Последовательно уменьшаем число на порядок, пока оно не станет трехзначным
        while (num > 999 )
        {
            num=num/10;
        }
    }
    return num%10;
}
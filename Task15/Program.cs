int num = new Random().Next(1,8);
Console.WriteLine($"{num} -> {Weekend(num)}");

string Weekend(int day)
{
    if(day < 6) return "Нет";
    return "Да";
}

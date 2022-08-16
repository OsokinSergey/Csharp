//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Exponentiation(int bas, int power){
    int result=1;
    for(int i=0;i<power;i++){
        result=result*bas;
    }
    return result;
}

Console.Clear();
Console.Write("Введите основание: ");
int bas = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int power = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{bas},{power} -> {Exponentiation(bas,power)}");
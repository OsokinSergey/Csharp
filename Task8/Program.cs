Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int counter=1;
string row="";

while(counter<=num){
    if(counter%2==0){
        row = row + counter +  ",";
     }
    counter++; 
}

//При выводе на консоль удаляем последнюю запятую, т.е. последний символ. Для красоты.
Console.WriteLine(row.Remove(row.Length-1));



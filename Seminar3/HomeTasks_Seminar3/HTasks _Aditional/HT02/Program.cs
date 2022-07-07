// Задача 2. Дано трёхзначное число N. Определить кратна ли трём сумма всех его цифр.
Random Thousand = new Random();
int number = Thousand.Next(1,1000);
Console.WriteLine(number);
Console.WriteLine();
Console.Write("Ответ задачи:");
void Multipli()
{
    int currentNum = (number/100)+(number%100/10) + (number%10);
    if (currentNum % 3 == 0)
    {
        Console.WriteLine ($" Сумма цифр числа {number} кратна 3");
    }
    else
    {
        Console.WriteLine ($" Сумма цифр числа {number} не кратна 3");
    }
}
Multipli();
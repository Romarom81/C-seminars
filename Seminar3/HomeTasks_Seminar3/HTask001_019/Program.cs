// Прога , которая проверяет ,является ли целое пятизначное число полиндромом
// Полиндром - это зеркальное выражение или фраза, которую можно читать прямо и наоборот.
Console.WriteLine("Введите пятизначное число:");
string number = Console.ReadLine();
void Polindrom()
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"Введенное число {number} является полиндромом");
    }
    else
    {
        Console.WriteLine($"Введенное число {number} не является полиндромом");
    }
}
Polindrom();
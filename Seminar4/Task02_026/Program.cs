

void Zadacha26()
{
    // Напишите программу, которая принимает
    //на вход число и выдаёт количество цифр в числе.

    Console.WriteLine("Введите число:");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Число {number} состоит из {Longnumber(number)} чисел");
}
Zadacha26();
int Longnumber(int number)
{
    int count = 0;
    while (number % 10 > 0)
    {
        number = number / 10;
        count++;
    }
    return count;

}

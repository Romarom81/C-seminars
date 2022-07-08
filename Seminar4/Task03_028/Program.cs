void Zadacha28()
{
    // Напишите программу, которая принимает на вход число N и выдаёт
    // произведение чисел от 1 до N
    Random Rand = new Random();
    int number = Rand.Next(2, 10);
    Console.WriteLine($" Произведение чисел от 1 до {number} равно {Multi(number)} ");
}
int Multi(int number)
{
    int Factorial = 1;
    int count = 2;
    while (count<=number)
    {
        Factorial = Factorial*count;
        count++;
    }
    return Factorial;
}
Zadacha28();
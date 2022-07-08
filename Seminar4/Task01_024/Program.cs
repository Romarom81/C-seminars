void Zadacha24()
{
    // Напишите программу, которая
    // принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

    Console.WriteLine("Введите число:");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Сумма чисел от 1 до {number} равна {FindeSum(number)}");
}
int FindeSum(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}
Zadacha24 ();
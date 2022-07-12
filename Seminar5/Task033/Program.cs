// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
void Zadacha33()
{
    int size = 15;
    int[] array = new int[size];
    FillArray(array);
    PrintArray(array);
    Console.Write("Введите число:");
    int num = Convert.ToInt32(Console.ReadLine());
    PresentDigit(array, num);

}
Zadacha33();
void FillArray(int[] array) // заполение массива случайными числами

{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 100);
    }
}
void PrintArray(int[] array) // метод печати массива
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}   ");
    }
    Console.WriteLine(" ");
}
void PresentDigit(int[] array, int num)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) count++;
    }
    if (count == 0)
    {
        Console.WriteLine($"Число {num} отсутсвует в заданном массиве");
    }
    else
    {
        Console.Write($"Число {num} присутсвует в заданном массиве {count} раз");
    }
}



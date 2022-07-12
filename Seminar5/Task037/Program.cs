// Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.

void Zadacha37()
{
    Random random = new Random();
    int size = random.Next(4, 20);
    int[] array = new int[size];
    FillArray(array);
    Console.WriteLine ("Произвольный массив:");
    PrintArray(array);
    Console.WriteLine ();
    Console.WriteLine ("Произведение смежных пар:");
    MultipliCoupe (array);
    Console.WriteLine ();
}
Zadacha37();
void FillArray(int[] array) // заполение массива случайными 
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 10);
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

void MultipliCoupe(int [] array)
{
    int MaxIndex = array.Length - 1;
    for (int i = 0; i < array.Length / 2; i++)
    {
        Console.WriteLine($" {array[i]} * {array[MaxIndex-i]} = {array[i] * array[MaxIndex-i]}");
    }
    if (array.Length%2==1) Console.WriteLine($"элемент без пары: {array[array.Length / 2]}");

}

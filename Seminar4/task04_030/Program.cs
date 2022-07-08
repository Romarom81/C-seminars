void Zadacha30() // создание массива
{
    // Напишите программу, которая выводит  массив из 8 элементов, 
    // заполненный нулями и единицами в случайном порядке.
    int size = 8;
    int[] array = new int[size];
    //array = FillArrayFunction(size); // вызов функции
    FillArray(array); // вызов метода
    PrintArray(array); // вызов метода

}
Zadacha30();
int[] FillArrayFunction(int size) // заполнение массива с помощью функции, которая возвращает массив

{
    int[] FillArray = new int[size];
    Random rand = new Random();
    for (int i = 0; i < FillArray.Length; i++)
    {
        FillArray[i] = rand.Next(0, 2);
    }
    return FillArray;

}
void FillArray(int[] array) // заполнение массива с помощью метода
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0, 2);
    }

}
void PrintArray(int[] array) // вывод/печать массива
{
    Console.WriteLine("Вывод массива на экран:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}



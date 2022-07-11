// Напишите программу, которая задаёт массив из 8 случайных целых чисел
//  и выводит отсортированный по модулю массив.
int[] array = new int[8];
Random Rand = new Random();
void FillArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Rand.Next(-10, 100);
        Console.Write($" {array[i]}");

    }
    Console.WriteLine(" ");
}
FillArray();

Console.WriteLine(" ");
void Modul()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Abs(array[i]);
        Console.Write($" {array[i]}");
    }
    Console.WriteLine("  ");
}
Modul();
Console.WriteLine(" ");
void Sort()
{
    int index = 0;
    int length = array.Length;
    while (index < length)
    {
        int temp;
        int min = array[0];
        if (array[index] < min)
        {
            temp = min;
            min = array[index];
            array[index] = temp;
        }
        index++;
        
    }

}
Sort();

void PrintArray(int[] array)
{
    Console.WriteLine(" Сортированный массив: ");
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {

        Console.Write($" {array[i]}");
        
    }
    Console.WriteLine(" ");
}

PrintArray(array);

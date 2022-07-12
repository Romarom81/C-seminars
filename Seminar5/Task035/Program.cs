// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,50]. 

void Zadacha35()
{
    int size = 30;
    int[] array = new int[size];
    FillArray(array);
    PrintArray(array);
    FindDigit (array);
     Console.WriteLine (); 
     Console.WriteLine ();
}
Zadacha35();
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
void FindDigit (int[] array)
{
    int  count =0;
 for (int i = 0; i < array.Length; i++)
 {
    if ( array[i]>=10 && array[i]<=50) count++;
 }
 Console.Write ($"Заданный массив содержит {count} чисел в диапазоне от 10до 50");
}

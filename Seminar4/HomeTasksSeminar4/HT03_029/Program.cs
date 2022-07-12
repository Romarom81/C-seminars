// Напишите программу, которая задаёт массив из 8 случайных целых чисел
//  и выводит отсортированный по модулю массив.
Console.Write("Введите количество аргументов массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
Random Rand = new Random();
Console.WriteLine($" Задан массив {size} рандомных чисел:");
void FillArray()// метод заполенние массива произвольными значениями  от -10 до 10
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Rand.Next(-10, 10);
        Console.Write($"{array[i]}  ");

    }
}
FillArray();
void Modul() // метод перевод в массив по модулю
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Abs(array[i]);
    }
}
//Modul();
Console.WriteLine(" ");
void Sort(int[] CurrArray) // метод сортировка массива пузырьком
{
    int temp;
    int length = CurrArray.Length;
    for (int i = length - 1; i > 0; i--)
    {
        for (int j = 0; j < i; j++)
        {
            if (Math.Abs(CurrArray[j]) > Math.Abs (CurrArray[j + 1]))
            {
                temp = CurrArray[j];
                CurrArray[j] = CurrArray[j + 1];
                CurrArray[j + 1] = temp;
            }
        }
    }
    
}
Sort(array);
void PrintArray(int[] array) // метод печати массива
{
    Console.WriteLine(" Отсортированный по модулю массив: ");
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {

        Console.Write($"{array[i]}   ");

    }
    Console.WriteLine(" ");
}
PrintArray(array);

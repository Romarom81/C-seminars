// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
void Zadacha036()
{
  int size = 15;
  int[] array = new int[size];
  FillArray(array);
  Console.WriteLine("Задан массив случайных чисел:");
  PrintArray(array);
  Console.WriteLine();
  Console.WriteLine($"Сумма чисел расположенных на нечётных позициях данного массива равна {SumPisitiveIndex (array)}");
  Console.WriteLine();
}
Zadacha036();
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
    Console.Write($"{array[i]}, ");
  }
  Console.WriteLine(" ");
}

int SumPisitiveIndex (int[] array)
{
  int sum = 0;
  for (int i = 1; i < array.Length; i=i+2)
  {
    sum = sum + array [i];
  }
  return sum;
}
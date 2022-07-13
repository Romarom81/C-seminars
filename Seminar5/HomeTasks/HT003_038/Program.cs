// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
void Zadacha038()
{
  int size = 10;
  double[] array = new double[size];
  FillArray(array);
  Console.WriteLine("Задан массив вещественных чисел:");
  PrintArray(array);
  Console.WriteLine();
  Console.WriteLine($"В разница между максимальным ( {Max(array)}) и минимальным ({Min(array)}) равна ({Max(array) - Min(array)})");
  Console.WriteLine();
}
Zadacha038();
void FillArray(double[] array) // заполение массива случайными вещественными числами

{
  Random random = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = Math.Sqrt(random.Next(1, 10));
  }
}

void PrintArray(double[] array) // метод печати массива
{
  Console.WriteLine();
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]}| ");
  }
  Console.WriteLine(" ");
}

double Max(double[] array)
{
  double Max = array [0];
  for (int i = 1; i < array.Length; i++)
  {

    if (array[i] > Max) Max = array[i];
  }
  return Max;
}

double Min(double[] array)
{
  double Min = array [0];
  for (int i = 1; i < array.Length; i++)
  {

    if (array[i] < Min) Min = array[i];
  }
  return Min;
}






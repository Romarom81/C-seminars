// Прога принимает на ввод число N,
// Выдает таблицу кубов чисел от 1 до N;
Console.WriteLine ("Введите любое целое число до 100");
int number = Convert.ToInt32 (Console.ReadLine ());
void Triple ()
{
  Console.WriteLine ($"Таблица возведения чисел от 1 до {number} в куб:");
  for (int i = 1; i <= number; i++)
  {
     Console.WriteLine ($" {i} * {i} * {i}  = " + (Math.Pow (i,3)));
  }
}
Triple ();
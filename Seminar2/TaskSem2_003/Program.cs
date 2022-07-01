// Программа принимает на ввод 2 числа
// выводит , является ли второе число кратно первому.
// Если не кратно, то программа выводит остаток от деления:
Console.WriteLine ("Введите первое число:");
int FirstnNumber = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите второе число, которое меньше первого:");
int SecondNumber = Convert.ToInt32 (Console.ReadLine());
int number = 0;

     
Console.WriteLine ("Решение:");
void Multiple (int CNumber)
{
  if (FirstnNumber < SecondNumber) 
   {
       Console.WriteLine ("Вы ввели неверно, попробуйте ещё раз внимательно!");
   }
  else 
   { 
        int div = FirstnNumber%SecondNumber;
        if (div == 0)
        {
            Console.WriteLine ( SecondNumber + "  КРАТНО  " + FirstnNumber);
        }
        else
        {
        Console.Write (FirstnNumber + "  НЕ КРАТНО  " + SecondNumber + "  , остаток от делениня:" );
        Console.WriteLine (div);
        }
    }    
}
Multiple (number);
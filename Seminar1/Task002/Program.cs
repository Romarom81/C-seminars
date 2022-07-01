// Прога получает на ввод 2 числа и проверяет , является ли первое квадратом второго.
Console.Write ("Введите первое число:");
int numberA = Convert.ToInt32(Console.ReadLine ());
Console.Write ("Введите второе число:");
int numberB = Convert.ToInt32(Console.ReadLine ());
if (numberA == numberB*numberB)
{
   Console.WriteLine ($"Число {numberA} является квадратом {numberB}");
}
else
{
    Console.WriteLine ($"Число {numberA} не является квадратом {numberB}");
}
// (Задача 6) Программа, которая на вход принимает число и сообщает четное ли число или нет:
Console.Clear();
Console.Write ("Введите целое число:");
int number = Convert.ToInt16 (Console.ReadLine ());
if (number%2 == 0)
{
    Console.Write ("Вы ввели четное число!");
}
else
{
    Console.Write ("Вы ввели нечетное число!");
}

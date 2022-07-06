// (задача 2) Прога, которая на вход принимает 2 числа, а на выходе выдает наибольшее:
Console.WriteLine ("Введите первое число:");
int number_one = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите второе число:");
int number_two = Convert.ToInt32 (Console.ReadLine());
if (number_one>number_two)
{
    Console.Write ("Наибольшее из введенных чисел:");
    Console.Write (number_one);
}
else
{
    Console.Write ("Наибольшее из введенных чисел:");
    Console.Write (number_two);
}

// (Задача 8) Программа, которая на ввод принимает число N, а выводит все чётные числа от 1 до N:
Console.Write ("Введите целое число N:");
int number = Convert.ToInt32 (Console.ReadLine());
int count = 1;
Console.Write ("Список четных чисел от 1 до N:");
while (count<=number) 
{
    if (count%2 == 0) Console.Write (count + " ");
    count++;
}

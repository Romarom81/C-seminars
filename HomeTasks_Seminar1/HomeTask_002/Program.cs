//  (Задача 4) программа, которая принимает 3 числа и выдает максимальное:
Console.WriteLine ("Введите первое число:");
int number_one = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите второе число:");
int number_two = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите третье число:");
int number_three = Convert.ToInt32 (Console.ReadLine());
int currentNumber =0;
if (number_one>currentNumber) currentNumber = number_one;
if (number_two>currentNumber) currentNumber = number_two;
if (number_three>currentNumber) currentNumber = number_three;

Console.WriteLine ("Наибольшее из трех введённых чисел:");
Console. Write (currentNumber);
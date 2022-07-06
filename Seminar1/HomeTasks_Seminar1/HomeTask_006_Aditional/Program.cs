// (Задача 2) даны два числа (a,b), при этом a<b. выводим на экран сколько раз Число а поместиться в числе b:
Console.WriteLine ("Введите целое число A:");
int numberA = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите целое число B, больше чем A:");
int numberB = Convert.ToInt32 (Console.ReadLine());
if (numberA>numberB) Console.WriteLine ("Внимательнее пожалуйста! Число В должно быть больше числа А!");
Console.WriteLine ("Столько чисел А вмещает число В:");
int count =  1;

while (numberB-numberA >= numberA)
{
    numberB = numberB-numberA;
    count++;
}
 Console.WriteLine (count);
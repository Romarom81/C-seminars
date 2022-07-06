// (Задача 1) Пользователь вводит число (Если>0), то программа выводит такое количесто единиц:
Console.WriteLine ("Введите любое целое число:");
int number = Convert.ToInt32 (Console.ReadLine());
int count = 1;
if (number==0) Console.Write ("Кроме нуля!!");
while ( count<=number)
{
    Console.Write ("1"+" ");
    count ++;
}

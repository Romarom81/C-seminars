// Прога, которая принимает некое число (N), а выдает целые числа от -N до N.
Console.Write ("Введите число N:");
int number = Convert.ToInt32 (Console.ReadLine());
number = Math.Abs (number);
int count = -number;
while (count<=number)
{
    Console.Write (count+" ");
    count++;
}
Console.WriteLine ();

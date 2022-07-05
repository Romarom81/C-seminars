// На вход число, на выходе квадраты чисел от 1 до N:
Console.WriteLine("введите целое число отличное от нуля:");
int num = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ($"Список квадратов чисел от 1 до {num}:");
void Power ()
{
    if (num==0) Console.WriteLine(" вы ошибочно ввели 0, повторите попытку");
    int count = 1;
    while (count<num)
    {
        Console.WriteLine (Math.Pow (count,2));
        count++;
    }
}
Power ();
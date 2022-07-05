// Прога, выдает диапазон координат по номеру честверти
Console.Write ("Введите номер четверти системы координат:");
int num = Convert.ToInt32 (Console.ReadLine());

void Position ()
{
    if ( num == 1) Console.WriteLine ("Диапазон координат четверти 1 : 0 < x < infinity, 0 < y < infinity");
    else if ( num == 2) Console.WriteLine ("Диапазон координат четверти 2 :  0 > x > infinity, 0 < y < infinity");
    else if ( num == 3) Console.WriteLine ("Диапазон координат четверти 3 : 0 > x > infinity, 0 > y > infinity");
    else if ( num == 4) Console.WriteLine ("Диапазон координат четверти 3 : 0 < x < infinity, 0 > y > infinity");
}
Position ();
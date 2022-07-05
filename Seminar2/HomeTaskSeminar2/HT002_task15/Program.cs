// Прога, приниимает на вход цифру, которая обозначает день недели и
// проверяет является ли этот день выходным;

Console.Write ("Введите цифру от 1 до 7:  ");
int number = Convert.ToInt32 (Console.ReadLine());
void Day ()
{
   if (number == 1) Console.Write ("Понедельник ");
   else if (number == 2) Console.Write ("Вторник ");
   else if (number == 3) Console.Write ("Среда ");
   else if (number == 4) Console.Write ("Четверг ");
   else if (number == 5) Console.Write ("Пятница ");
   else if (number == 6) Console.Write ("Суббота ");
   else if (number == 7) Console.Write ("Восскресенье ");

if ( number >7 || number < 1) Console.WriteLine (" Ввели неверное число, повторите попытку");
else if ( number == 7 || number == 6) Console.Write (" - выходной)");
else 
{
    Console.Write (" - будний день(");
}
}
Day();


   


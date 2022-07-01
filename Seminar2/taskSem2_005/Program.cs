// Прога, котороя принимает 2 числа и проверяет,
// является ли одно квадратом другого?

Console.WriteLine (" Привет дружище,введи первое целое число:");
int num1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine (" Dведи второе целое число:");
int num2 = Convert.ToInt32 (Console.ReadLine());
void Quat (int TempNum1,int TempNum2)
{
   int CurrNum1 = num1*num1;
   int CurrNum2 = num2*num2;
    if (CurrNum1 == num2)
    {
        Console.WriteLine ($"Число {num2} является квадратом {num1}");
    }
    if ( CurrNum2 == num1)
    {
         Console.WriteLine ($"Число {num1} является квадратом {num2}");
    }
    else
    {
         Console.WriteLine ("Ни одно из чисел не является квадратом другого");
    }
}
Quat (num1,num2);
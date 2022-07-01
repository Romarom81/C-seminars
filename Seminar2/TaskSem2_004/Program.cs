// Программа, которая принимает число и проверяет кратно ли оно одновременно 7 и 23
Console.Write ("привет дружище, введи число:");
int num = Convert.ToInt16 (Console.ReadLine());

void TwoTriple (int arg1)
{
    int one = arg1%7;
    int two = arg1%23;
if (one == 0 & two == 0)
 {
      Console.WriteLine ("Введенное Вами число кратно 7 и 23! Ураа");
 }
 else
 {
      Console.WriteLine ("Введённое Вами число Не кратно 7 и 23((");
 }
}
TwoTriple (num);
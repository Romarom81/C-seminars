void Zadacha2 ()
{
// Напишите программу, которая принимает на вход число
//  и выдаёт сумму цифр в числе.
Console.WriteLine ("Введите целое число :");
int numA = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ($" Сумма цифр в числе {numA} равна {Summary (numA)}");
}
Zadacha2 ();
int Summary (int A)
{
   int sum = 0;
   while (0 < A%10)
   {
    sum = sum + A%10;
    A = A/10;
   }
   return sum;
}
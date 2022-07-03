// Прога, которая определяет возраст человека на 1 июля 2022 года:
Console.WriteLine ("Введите дату своего рождения:  ");
Console.Write ("число ");
int date = Convert.ToInt16 (Console.ReadLine());
Console.Write ("месяц ");
int Month = Convert.ToInt16 (Console.ReadLine());
Console.Write ("год ");
int Year = Convert.ToInt16 (Console.ReadLine());
void Age (int A, int B, int C)
{
 int CurrentDay = (2022*365) + 183;
 int AgeDay = (Year*365)+(Month*31)+date;
 int Age = (CurrentDay-AgeDay)/365;
 Console.Write ("Ваш возраст составляет ");
 if (Age%2==0) 
 {
    Console.Write (Age);
    Console.WriteLine ("  лет");
 }
 else
 {
    Console.Write (Age);
    Console.WriteLine ("  год");
 }
 }
 Age (date,Month,Year);

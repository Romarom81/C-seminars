void Zadazha1()
{
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
Console.WriteLine ("Введите целое число А:");
int numA = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите целое число B:");
int numB = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ($"Результат возведения числа {numA} в степень {numB}: { Multy (numA,numB) } ");
}
Zadazha1 ();

int Multy (int CurrentnumA,int CurrentnumB)
{
    int result = 1;
   for (int i = 1; i <= CurrentnumB; i++)
   {
     result = result*CurrentnumA;
       
   }
   return result;
   
}

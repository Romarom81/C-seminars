//  Задача 1. Рассчитать значение y при заданном x по формуле
Random Ten = new Random ();
int x = Ten.Next (-10,11);
Console.WriteLine (x);
Console.WriteLine ();
void First ()
{
    double result = 0;
    double sinX = Math.Sin (x);
    double X1 = x * x;
    double sinX1 = Math.Sin (X1);
    if (x > 0)
    {
       result = sinX * sinX;
    }
    else
    {
        result = 1 - 2*sinX1;
    }
   Console.WriteLine ("Результаты решения задачи:");
   Console.WriteLine (result);
}
First ();
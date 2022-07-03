// Прога,считает объем депозита через N месяцев.
Console.WriteLine("Введите количество месяцев для расчета размера депозита и прибыли");
int month = Convert.ToInt32 (Console.ReadLine());
int input = 1000; // можно задать ввод любой суммы через консоль.

void Profit (double charge)
{
    int count = 0;
    double total = input;
    double dif = 0 ;
    while (count<month)
    {
        
        total = total + ((total/100)*1.5);
        dif =  total - input;
        count++;
    }
    
    Console.Write ("Размер депозита через   ");
    Console.Write (month);
    Console.Write ( "  месяцев составит:");
    Console.WriteLine (Math.Round (total,1));
    Console.Write ("Прибыль Ваша составит:");
    Console.WriteLine (Math.Round (dif,1));
 }
 Profit (input);
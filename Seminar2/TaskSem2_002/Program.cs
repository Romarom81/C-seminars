// Написать программу, которая выводит 
//случайное трехзначное число и
// удаляет вторую цифру этого числа:

Random ThreeHoudreed = new Random ();
int Randnumber = ThreeHoudreed.Next (100,1000);
Console.WriteLine (Randnumber);
void DeleteTwoDigit (int Randnumber) // метод работы с численным типом данных
{
    int First = Randnumber/100;
    int Second = Randnumber%100/10;
    int Third = Randnumber%10;
    int result = First*10 + Third;
    Console.Write(result );
}
DeleteTwoDigit (Randnumber);

// вариант решения со строчным типом данных:



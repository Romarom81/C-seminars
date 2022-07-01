// Напишите программу, которая выводит случайниые числа из отрезка [10,99]
// и показывает наибольшую цифру из составляющих этого цисла
Random rand = new Random ();
int number = rand.Next (10,100);


void Zadacha2 (int currentNumber)
{
Console.WriteLine (currentNumber);
// if (number/10 > number%10) Console.WriteLine (number/10);
// else Console.WriteLine (number%10);
// Еслди в цикле одно действие, то { } можно не ставить, два и более -обязательно.
// в программировании необходимо стримиться к сокращению повторений 
// математических действий внутри циклов путём вводом переменной, которая 1 раз вычисляется:
int digitFirst = currentNumber/10;
int digitSecond = currentNumber%10;

if (digitFirst> digitSecond) Console.WriteLine (digitFirst);
else if (digitSecond < digitFirst) Console.WriteLine (digitSecond);
else Console.WriteLine ("две цифры равны");
}

Zadacha2 (number); // вызов  метода, который сверху написали void Zadacha2


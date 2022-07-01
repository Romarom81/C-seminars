// Программа вычесления функции возведения числв в квадрат:
Console.WriteLine ("Введите любое целое число:");
int number = Convert.ToInt32( Console.ReadLine ());

OurPower (number); //вызов метода
OurPower (number+number);
OurPower (36);
OurPower (number+number+number);
OurPower (124);

void OurPower (int currentNumber) 
{
     Console.WriteLine(currentNumber * currentNumber);
}

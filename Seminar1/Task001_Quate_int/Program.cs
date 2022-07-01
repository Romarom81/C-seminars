// Возведение числа в квадрат
// Цикл
// Ветвление
// Сначала указываем <тип данных> <имя переменной> = <значение> 
// <тип данных> <имя переменной>
//int number = 5;// integer - тип переменной, < number> - имя переменной
//Console.WriteLine (number*number);- вариант 1
// Console.WriteLine (Math.Pow (number, 2)); -вариант 2
Console.WriteLine ("Введите число:");
int number = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine (number*number);
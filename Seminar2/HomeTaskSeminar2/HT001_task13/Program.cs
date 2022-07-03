// Прога, которая выводит третью цифру заданного числа, 
// или сообщает что её нет.
Console.Clear ();
Console.Write("Введите целое число:");
string number = Console.ReadLine();

if  (number.Length > 2)
{
    Console.Write (" Третья цифра введенного числа -  ");
    Console.WriteLine (number[2]);
}
else
{
    Console.Write (" В веденном вами числе менее 3х цифр, попробуйте ещё раз..  ");
}

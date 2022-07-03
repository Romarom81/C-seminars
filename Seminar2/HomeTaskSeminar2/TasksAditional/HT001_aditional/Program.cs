//Прога, которая определяет ,
// является ли треугольник со сторонами a,b,c равнобедренным.
Console.WriteLine ("Привет,введите три длины сторон треугольника:");
Console.Write ("Сторона А:");
int A = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Сторона В:");
int B = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Сторона С:");
int C = Convert.ToInt32 (Console.ReadLine());
void Side ()
{
    if (A == B & B == C & C == A )
    {
        Console.WriteLine ("Данный треугольник является равносторонним");
    }
    else if (A == B || B == C || C == A )
    {
         Console.WriteLine ("Данный треугольник является равнобедренным");
    }
    else 
    {
         Console.WriteLine ("Данный треугольник НЕ является равнобедренным!");
    }
}
Side ();
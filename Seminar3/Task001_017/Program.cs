// Напишите прогу, которая принимает на вход координаты точки (x;y) и
// определяет в какой области системы координат находится точка
Console.Write ("Введите координату точки по оси х:");
int x = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите координату точки по оси y:");
int y = Convert.ToInt32 (Console.ReadLine());
void Quater ()
{
    if (x > 0 & y > 0) Console.WriteLine ("Точка находится в 1 четверти");
    else if (x < 0 & y > 0) Console.WriteLine ("Точка находится во 2 четверти");
    else if (x < 0 & y < 0) Console.WriteLine ("Точка находится в 3 четверти");
    else if (x > 0 & y < 0) Console.WriteLine ("Точка находится в 4 четверти");
    else Console.WriteLine ("Точка на оси координат расположена");
}
Quater ();
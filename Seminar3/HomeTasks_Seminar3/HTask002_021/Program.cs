// Прога, которая принимает на вход 3 2 точки A и B,
// b находит расстояние между ними в трехмерном простанстве
Console.Write ("Введите координату x точки А:");
int A_x1 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите координату y точки А:");
int A_y1 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите координату z точки А:");
int A_z1 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите координату x точки B:");
int B_x2 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите координату y точки B:");
int B_y2 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите координату z точки B:");
int B_z2 = Convert.ToInt32 (Console.ReadLine());
void LongLine ()
{
    int diffX = B_x2 - A_x1;
    int diffY = B_y2 - A_y1;
    int diffZ = B_z2 - A_z1;
    double lengthLine = Math.Sqrt(diffX * diffX + diffY * diffY + diffZ * diffZ);
    Console.Write("Длина отрезка между точками A и B равна:");
    Console.WriteLine (Math.Round (lengthLine, 2));
}
LongLine ();
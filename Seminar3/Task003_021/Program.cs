// Задание на картинке
Console.Write ("Введите координату x точки А:");
int A_x1 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите координату y точки А:");
int A_y1 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите координату x точки B:");
int B_x2 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите координату y точки B:");
int B_y2 = Convert.ToInt32 (Console.ReadLine());
int diffX = B_x2 - A_x1;
int diffY = B_y2 - A_y1;
double lengthLine = Math.Sqrt (diffX*diffX + diffY*diffY );
Console.Write ("Длина отрезка между точками A и B равна:");
Console.WriteLine (lengthLine);

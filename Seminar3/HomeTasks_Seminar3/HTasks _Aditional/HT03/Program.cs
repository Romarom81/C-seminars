// Задача 3. Дано трёхзначное число N. Определить, есть ли среди его цифр 4 или 7.
Console.WriteLine("Задача 3. Дано трёхзначное число N. Определить, есть ли среди его цифр 4 или 7.");
Console.Write("Рандомное число N = ");
Random Three = new Random();
int number = Three.Next(101, 1000);
Console.WriteLine(number);
Console.WriteLine();
Console.Write("Ответ: ");
void Choice()
{
    int A = number / 100;
    int B = number % 100 / 10;
    int С = number % 10;
    if (A == 7 | A == 4 | B == 7 | B == 4 | С == 7 | С == 4)
    {
        if (A == 4 | B == 4 | С == 4)
        {
            if (A == 7 | B == 7 | С == 7)
            {
                Console.Write($"Число {number} содержит цифры 4 и 7");
            }
            else
            {
                Console.Write($" Число содержит только цифру 4 ");
            }
        }
        else 
        {
            Console.Write("Число содержит только цифру 7");
        }
    }
    else
    {
        Console.Write($"Число {number} не содержит цифр 4 и 7");
    }
}
Choice();

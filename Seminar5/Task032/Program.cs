
void Zadacha32 ()
{//Напишите программу замены элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.[-4, -8, 8, 2] -> [4, 8, -8, -2]
 int size = 12;
    int[] array = new int[size];
    FillArray (array,-10,10);
    PrintArray(array);
    Console.WriteLine();
    ChangeZnak (array);
    Console.Write ("Массив с противоположным знаком = ");
    PrintArray(array);
    Console.WriteLine();
}
 
Zadacha32();

void FillArray(int [] array,int startnumber =0,int finishnumber =0) // заполение массива в заданном дипазоне числ
{
    finishnumber++;
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
      array [i] = random.Next(startnumber, finishnumber);
    }
    
}
void PrintArray(int[] array) // метод печати массива
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}   ");
    }
    Console.WriteLine(" ");
}
void ChangeZnak (int [] array) // метод меняет знак числа
{
    for (int i = 0; i < array.Length; i++)
    {
       array[i] = array[i]*-1;
    }
}



void Zadacha31()
{
    //Задайте массив из 12 элементов, заполненный
    // случайными числами из промежутка [-9, 9]. Найдите сумму
    //отрицательных и положительных элементов массива.
   //Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
   //положительных чисел равна 29, сумма отрицательных равна-20.

    int size = 12;
    int[] array = new int[size];
    FillArray (array,-9,9);
    PrintArray(array);
    Console.WriteLine();
    Console.Write ("Сумма положительных элементовмассива = "+ SumPositive (array));
    Console.WriteLine();
    Console.Write ("Сумма отрицательных элементовмассива = "+ SumNegative (array));
    Console.WriteLine();  
    Console.WriteLine(); 
}
 
Zadacha31();

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
int SumPositive (int [] array) // метод находит сумму положительных чисел
{
    int sumPositive =0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0) sumPositive += array[i];
    }
    return sumPositive;

}
int SumNegative (int [] array) // метод находит сумму отрицательных чисел
{
    int sumNegative =0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<0) sumNegative += array[i];
    }
    return sumNegative;
}



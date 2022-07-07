// Задача 4. Дан массив длиной 10 элементов. Заполнить его последовательно числами от 1 до 10.
int[] array = new int[10];
int count = 1;
for (int i = 0; i < 10; i++)
{
    array [i] = count;
    Console.Write ($"{count} ");
    count++;
}

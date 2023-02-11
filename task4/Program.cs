// Дан список некоторых целых чисел, найдите значение 20 в нем и, если оно присутствует, замените его на 200. Обновите список только при первом вхождении числа 20.
int[] arr = new int[10];
for (int i = 0; i < 10; i++){
    arr[i] = new Random().Next(10,25);
    Console.Write(arr[i] + " ");
}
for (int i = 0; i < 10; i++)
{
    if(arr[i] == 20)
    {
        arr[i] = 200;
        break;
    }
}
Console.WriteLine("");
foreach(int el in arr)
{
    Console.Write(el + " ");
}
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("Задан массив:");

int sum = 0;
int[] arr = new int[10];
for (int i = 0; i < 10; i++){
    arr[i] = new Random().Next(0,10);
    Console.Write(arr[i] + " ");
    if(i % 2 != 0){
        sum = sum + arr[i];
    }
}
Console.WriteLine("");
Console.WriteLine("Сумма чисел одномерного массива, стоящих на нечетной позиции, равна " + sum);
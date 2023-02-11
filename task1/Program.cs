// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine("Задан массив:");

int count = 0;
int[] arr = new int[10];
for (int i = 0; i < 10; i++){
    arr[i] = new Random().Next(100,1000);
    Console.Write(arr[i] + " ");
    if(arr[i] % 2 == 0){
        count++;
    }
}
Console.WriteLine("");
Console.WriteLine("Количество четных чисел в этом массиве равно " + count);
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] arr = new double[10];
for (int i = 0; i < 10; i++){
    arr[i] = new Random().Next(-9,10);
    Console.Write(arr[i] + " ");
} 
Console.WriteLine("");

double min = arr[0];
double max = arr[0];
for (int i = 1; i < arr.Length; i++){
    if (arr[i] > max){
        max = arr[i];
    }
    else if(arr[i] < min){
        min = arr[i];
    }
}
Console.Write($"Разница между максимальным и минимальным элементами равна {max - min}");
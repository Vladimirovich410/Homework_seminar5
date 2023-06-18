// Задача 1 (34): Задайте массив заполненный
// случайными положительными трёхзначными
// числами. Напишите программу, которая 
// покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// Console.WriteLine("Задайте размер массива");
// int length = Convert.ToInt32(Console.ReadLine());

// int [] array = new int [length];

// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(100, 1000);
//     Console.Write(array[i]+" ");
//     if(array[i]%2 == 0) count++;
// }

// Console.WriteLine();
// Console.WriteLine($"Количество чётных чисел в массиве {count}");


// Задача 2 (36): Задайте одномерный массив, 
// заполненный случайными числами. Найдите 
// сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// Console.WriteLine("Задайте размер массива");
// int length = Convert.ToInt32(Console.ReadLine());

// int [] array = new int [length];
// int i = 0;
// int sum = 0;
// for (i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(1, 100);
//     if(i%2 != 0)
//     {
//         sum = sum + array[i];
//     }
//     Console.Write(array[i]+" ");
// }
// Console.WriteLine();
// Console.WriteLine(sum);


// Задача 3 (38): Задайте массив вещественных чисел.
// Найдите разницу между максимальным и 
// минимальным элементами массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.WriteLine("Задайте размер массива");
int length = Convert.ToInt32(Console.ReadLine());

double [] array = new double [length];

double diff = 0;
double max = double.MinValue;
double min = double.MaxValue;
for (int i = 0; i < array.Length; i++)
{
    array[i] = (Math.Round(new Random().NextDouble(),2)) + new Random().Next(1,100);
    Console.Write(array[i]+" ");
    if(array[i] > max) max = array[i];
    if(array[i] < min) min = array[i];
    diff = max - min;
}

Console.WriteLine();
Console.WriteLine("Максимальный элемент массива "+max);
Console.WriteLine("Минимальный элемент массива "+min);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива {diff}");


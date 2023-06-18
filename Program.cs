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


// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. Найдите 
// сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.WriteLine("Задайте размер массива");
int length = Convert.ToInt32(Console.ReadLine());

int [] array = new int [length];
int i = 0;
int sum = 0;
for (i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 100);
    if(i%2 != 0)
    {
        sum = sum + array[i];
    }
    Console.Write(array[i]+" ");
}
Console.WriteLine();


Console.WriteLine(sum);





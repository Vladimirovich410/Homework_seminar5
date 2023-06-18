// Задача 1 (34): Задайте массив заполненный
// случайными положительными трёхзначными
// числами. Напишите программу, которая 
// покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


Console.WriteLine("Задайте размер массива");
int length = Convert.ToInt32(Console.ReadLine());

int [] array = new int [length];

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i]+" ");
    if(array[i]%2 == 0) count++;
}

Console.WriteLine();
Console.WriteLine($"Количество чётных чисел в массиве {count}");

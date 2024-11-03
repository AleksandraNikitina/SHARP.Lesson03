// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

using System.Transactions;

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.Write("]");
}

bool IsEven(int num)
{
    if (num % 2 != 0)
    {
        return false;
    }
    else
    {
        return true;
    }
}

int CountEvenNums(int[] arr)
{
    int count = 0;
    foreach (int e in arr)
    {
        if(IsEven(e))
        {
            count++;
        }        
    }
    return count;
}

Console.Write("Enter array size: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArrayRndInt(size, 100, 1000);
PrintArray(arr);
int result = CountEvenNums(arr);
Console.Write($" => {result}");

// Create array of N random integer numbers. 
// Determine the quantity of numbers that have "1" as last digit and that are divisible by 7.

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

int CountNumsLastADevB(int[] array, int aLast, int bDev)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 10 == aLast && array[i] % bDev == 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Enter array size: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArrayRndInt(n, 1, 100);
PrintArray(arr);

int result = CountNumsLastADevB(arr, 1, 7);
Console.Write($" => {result}");
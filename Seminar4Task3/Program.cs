// Fill from console array with N (not more than 8) numbers.
// Create integer number, digit of this number are elements of array. 
// The first digit of number is the 0th array element, 
// // the last digit of number is the last array element.  
// Example:
// [1,5,3,4,6,3] => 153463

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

int ArrayToNumber(int[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        res = res*10 + array[i];
    }
    return res;
}

Console.Write("Enter array size: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 1 || n > 8)
{
    Console.WriteLine("Enter error");
    return;
}

int[] arr = CreateArrayRndInt(n, 0, 10);
PrintArray(arr);

// int result = ArrayToNumber(arr);
// Console.Write($" => {result}");

Console.Write($" => {ArrayToNumber(arr)}");
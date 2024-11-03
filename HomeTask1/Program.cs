// Программа, которая бесконечно запрашивает целые числа с консоли.
// Программа завершается при вводе числа, сумма цифр которого четная, или вводе символа "q". 

using System.Globalization;

int SumOfDigits(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
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

string returnSymbol = "q";
while (true)
{
    Console.Write("Enter integer number or 'q' to exit: ");
    string enter = Console.ReadLine();

    if (enter == returnSymbol)
    {
        return;
    }

    int number = Convert.ToInt32(enter);
    int sumgidits = SumOfDigits(number);
    if(IsEven(sumgidits))
    {
        return;
    }
}

// Задайте значение M и N. Напишите программу, которая выведет все натуральные числа
// в промежутке от М до N.

void PrintNaturalNumber (int M, int N)
{
    if (M <= N)
    {
        Console.WriteLine(M);
        PrintNaturalNumber(M + 1, N);
    }
}

Console.WriteLine("Введите число М: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

PrintNaturalNumber(M, N);
// Задайте значения M и N. Напишите программу которая найдет сумму
// натуральных элементов в промежутке от М до N.

int SumElements (int M, int N)
{
    int Sum = M;
    if (M != N)
    {
        Sum += SumElements(M + 1, N);
    }
    return Sum;
}

Console.WriteLine("Введите число М: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int result = SumElements(M, N);
Console.WriteLine($"result = {result}");
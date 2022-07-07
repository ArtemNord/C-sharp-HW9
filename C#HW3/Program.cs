// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два не отрицательных числа M и N.

int Akkerman(int N, int M)
{
    if (N == 0)
    {
        return M + 1;
    }
    if (M == 0 && N > 0)
    {
        return Akkerman(N - 1, 1);
    }
    return Akkerman(N - 1, Akkerman(N, M - 1));
}

int result = Akkerman(3,2);

Console.WriteLine(result);
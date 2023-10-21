// Программа принимает на вход 3 числа и выдает максимальное из этих чисел

int A = 100;
int B = 700;
int C = 1600;

int max = A;

if (max < B)
    {
    max = B;
    }
if (max < C)
    {
    max = C;
    }
Console.Write(max);

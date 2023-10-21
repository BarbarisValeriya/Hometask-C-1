// Напишите программу, которая на вход принимает число N, а на выходе показывает все ЧЕТНЫЕ числа от 1 до N

int N = 10;
int start = 1;
int count = start;

while (count <= N)
    {
    Console.Write(count % 2 == 0 + ", ");
    count ++;
    }



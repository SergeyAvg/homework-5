int N = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[N];

for (int i = 0; i < N; i++)
{
    mas[i] = new Random().Next(0, 1000);
    Console.Write(mas[i] + " ");
}

int count = 0;

for (int i = 0; i < N; i++)
{
    if (mas[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine(count);
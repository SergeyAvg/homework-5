int N = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[N];

for (int i = 0; i < N; i++)
{
    mas[i] = new Random().Next(1, 30);
    Console.Write(mas[i] + " ");
}

int sumEven = 0;
for (int i = 0; i < N; i++)
{
    if(i % 2 == 0)
    {
        if (mas[i] % 1 == 0)
        {
            sumEven = sumEven + mas[i];
        }
    }
}

Console.WriteLine(sumEven);
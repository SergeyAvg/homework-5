int N = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[N];

for (int i = 0; i < N; i++)
{
    mas[i] = new Random().Next(0, 100);
    Console.Write(mas[i] + " ");
}

int min = mas[i];
int max = mas[N];

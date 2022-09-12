int N = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[N];
for ( int index = 0; i < N; i++)
{
    mas[index] = new Random().Next(0, 100);
    Console.Write(mas[index] + " ");
}

int min = mas[0];
int max = mas[N];
difference = max - min;
Console.WriteLine(difference);
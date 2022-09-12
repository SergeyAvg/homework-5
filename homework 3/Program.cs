int N = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[N];
for ( int i = 0; i < N; i++)
{
    mas[i] = new Random().Next(0, 100);
    Console.Write(mas[i] + " ");
}

int min = mas[0];
int max = min;
for (int i = 1; i < N; i++)
{
    if(mas[i] > max) 
    {
        max = mas[i];
    }
    if(mas[i] < min) 
    {
        min = mas[i];
    }
}

int difference = max - min;
Console.WriteLine(difference);
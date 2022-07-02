int i = 1;
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Четные числа в диапозоне от 1 до N ");
while (i<=N)
{   int number = i/2;
    if (i % 2 == 0)
    {
        Console.Write(i);

    }
    else
    {
        Console.WriteLine("   ");
    }

    i++;
}



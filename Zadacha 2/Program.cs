Console.WriteLine("Введите первое число");
double num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
double num2 = Convert.ToInt32(Console.ReadLine());
if(num1>num2)
{
    double max = num1;
    Console.Write("Максимальное число");
    Console.WriteLine(max);
    double min = num2;
    Console.Write("Минимальное число");
    Console.WriteLine(min);
}
else
{
    double max = num2;
    Console.Write("Максимальное число");
    Console.WriteLine(max);
    double min = num1;
    Console.Write("Минимальное число");
    Console.WriteLine(min);
}






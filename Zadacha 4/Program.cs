Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int num3 = Convert.ToInt32(Console.ReadLine());

int max1 = num1;

if(max1<num2)
{
    int max2 = num2;
    if(max2<num3)
    {
        int max3 = num3;
       Console.Write("Максимальное число из трех ");
       Console.WriteLine(max3); 
    }
    else
    { 
        Console.Write("Максимальное число из трех ");
        Console.WriteLine(max2);

    }
   
}
else
{  
    if(max1<num3)
    {
        Console.Write("Максимальное число из трех");
        Console.WriteLine(num3);
    }    

    else
    {
        Console.Write("Максимальное число из трех ");
        Console.WriteLine(max1);
    }

}


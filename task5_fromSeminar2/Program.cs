int sumNumber(int Number)
{
    int Sum = 0;
    while (Number > 0)
    {
        Sum += Number % 10;
        Number /= 10;
    }
    return Sum;
}

Console.Clear();
Console.WriteLine("Введи первое число:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введи второе число:");
int num2 = int.Parse(Console.ReadLine());
int sum1 = sumNumber(num1);
int sum2 = sumNumber(num2);
Console.WriteLine((sum1 == sum2) ? $"Суммы чисел {num1} и {num2} равны {sum1}." : $"Суммы чисел {num1}({sum1}) и {num2}({sum2}) не равны.");
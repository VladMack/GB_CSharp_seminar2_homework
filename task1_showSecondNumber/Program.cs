Console.Clear();
Console.WriteLine("Введи трёхзначное число:");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"{num} -> {(num/10)%10}");
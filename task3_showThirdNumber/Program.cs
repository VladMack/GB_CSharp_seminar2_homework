Console.Clear();
Console.WriteLine("Введи число:");
int num = int.Parse(Console.ReadLine());
string numS = num.ToString();
Console.WriteLine((num / 100 >= 1) ? $"{num} -> {numS[2].ToString()}" : $"{num} -> третьей цифры нет.");
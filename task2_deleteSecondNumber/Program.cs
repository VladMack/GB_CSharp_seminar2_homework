Console.Clear();
int num = new Random().Next(100, 1000);
string numS = num.ToString();
string result = numS[0].ToString() + numS[2].ToString();
Console.WriteLine($"{num} -> {result}");
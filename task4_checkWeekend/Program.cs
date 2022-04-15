Console.Clear();
//решил добавить название дня недели:
string[] week = new[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
Console.WriteLine("Введи номер дня недели:");
int num = int.Parse(Console.ReadLine());
Console.WriteLine((num > 0 && num <= 7) ? (num == 6 | num == 7) ? $"{num}. {week[num - 1]} - выходной." : $"{num}. {week[num - 1]} - не выходной." : $"Нет такого дня недели.");
//Лабораторная работа 2.2, Номер: 11, сложность: продвинутая;
Console.Write("Введите трехзначное число: ");
int x = int.Parse(Console.ReadLine());
int x1 = (x / 100 % 10);
int x2 = (x / 10 % 10);
int x3 = (x % 10);
if (x1 == x2 && x2 == x3 && x3 == x1) Console.WriteLine("Все цифры одинаковы");
else if ((x1 == x2) || (x2 == x3) || (x1 == x3)) Console.WriteLine("Одинаковые цифры есть");
else Console.WriteLine("Одинаковых цифр нет");
// Напишите программу, которая выводит случайное число трехзначное число
// и удаляет вторую цифру этого числа.
// 456 - 46
// 782 - 72
// 918 - 98

Console.Clear();

string ExtractNum(int num1)
{
int a = num1 / 100;
int c = num1 % 10;

string ac = "Результат удаления второй цифры числа: " + (a * 10 + c);
return ac;
}

int value = new Random().Next(100,1000);

Console.WriteLine("Случайное число: " + value);
Console.WriteLine(ExtractNum(value));


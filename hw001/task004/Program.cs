// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();

Console.WriteLine("Сейчас мы будем показывать все четные числа от 1 до N");
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Все четные числа от 1 до " + N + ":");

int index = 2;

if (N >= 2)
{
  while (index <= N)
  {
    if (index % 2 == 0)
    {
      Console.Write(" " + index);
    }
    index += 2;
  }
}
else
{
  Console.Write(" нет");
}
Console.WriteLine();
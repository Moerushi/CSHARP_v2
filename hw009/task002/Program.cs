// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// (границы включены в подсчет)

// Подзадачи:
// 1. Задать числа M и N
// 2. Провести расчет от M и N
int CalculateSum(int min, int max)
{
  if (min == max) return max;
  if (min > max) return 0;
  else return min + CalculateSum(min + 1, max);
}
// 3. Вывести результат

// Решение:
int n = 4;
int m = 8;
Console.WriteLine($"Sum of all elements between {n} and {m} is {CalculateSum(n, m)}.");
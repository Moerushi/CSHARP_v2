// Сложная задача, можно пропустить
// *Задача 68: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Подзадачи:
// 1. Задать значения m и n
int min = 2;
int max = 3;
// 2. Высчитать функцию Аккермана с помощью рекурсии
int AckermannFunction(int n, int m)
{
  if (n == 0) return m + 1;
  if (n != 0 && m == 0) return AckermannFunction(n - 1, 1);
  if (n > 0 && m > 0) return AckermannFunction(n - 1, AckermannFunction(n, m - 1));
  return AckermannFunction(n, m);
}
// 3. Вывести результат 
void PrintAccermanFunction(int min, int max)
{
  for (int i = min; i <= max; i++)
  {
    for (int j = min; j <= max; j++)
    {
     Console.WriteLine($" Ackermann function ({i},{j}) = {AckermannFunction(i, j)}"); 
    }
  }
}

// Решение:
PrintAccermanFunction(min, max);



// Задача 3: Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного треугольника
// Дополнительно: Сохранить треугольник в файл.

// Подзадачи:
// 1. Получить число строк от пользователя c проверкой на корректность
int GetIntNumber(string text)
{
  int value = 0;
  bool flag = false;
  while(!flag)
  {
  Console.WriteLine(text);
  flag = int.TryParse(Console.ReadLine(), out value);
  }
  return value;
}
// 2. Построить треугольник
// 3. Вывести треугольник
void PrintDimArray(int[,] array)
{
  Console.WriteLine(" ");
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine(" ");
  }
}
// 4. Сохранить треугольник в файл


// Решение: 
int n = GetIntNumber("Input number of lines your want to print:");
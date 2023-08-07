// Задача 3: Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного треугольника

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
// 2. Заполнить треугольник
void FillTriangle(int[,]array, int row)
{
  for (int i = 0; i < row; i++)
  {
    array[i, 0] = 1;
    array[i, i] = 1;
  }
  for (int i = 2; i < row; i++)
  {
    for (int j = 1; j <= i; j++)
    {
      array[i, j] = array[i - 1, j - 1] + array[i - 1, j];
    }
  }
}
// 3. Вывести треугольник
void PrintTriangle(int row, int[,]array)
{
  const int cellWidth = 3;
  int col = cellWidth * row;
  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j <= i; j++)
    {
      Console.SetCursorPosition(col, i + 1);
      if (array[i, j] != 0) Console.Write($"{array[i, j],cellWidth}");
      col += cellWidth * 2;
    }
    col = cellWidth * row - cellWidth * (i + 1);
    Console.WriteLine();
  }
}
// Решение: 

int row = GetIntNumber("Input number of rows: ");
int[,] triangle = new int[row, row];
Console.Clear();
FillTriangle(triangle, row);
PrintTriangle(row, triangle);

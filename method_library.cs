// НАЧАЛО

// Получение числа от пользователя с проверкой на ввод именно числа
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

// Создание матрицы
int[,] CreateTwoDimArray(int row, int column)
{
  return new int[row, column];
}

// Заполнение матрицы случайными числами
void FillTwoDimArray(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      matr[i, j] = new Random().Next(1, 10);
    }
  }
}

// Печать матрицы
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

// КОНЕЦ
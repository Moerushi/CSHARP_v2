// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// Подзадачи:
// 1. Запросить у пользователя данные:
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
// 2. Создать матрицу
int[,] CreateTwoDimArray(int row, int column)
{
  return new int[row, column];
}
// 3. Заполнить матрицу
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
// 4. Замена столбцов и строк (через создание еще одного массива)
void ChangeRowsWithColumns(int[,] arrayStart, int[,] arrayFinish)
{
  for (int i = 0; i < arrayStart.GetLength(0); i++)
  {
    for (int j = 0; j < arrayStart.GetLength(1); j++)
    {
      arrayFinish[j, i] = arrayStart[i, j];
    }
  }
}
// 5. Вывести матрицу
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

// Решение:
int rows = GetIntNumber("Input number of rows");
int columns = GetIntNumber("Input number of columns");
int[,] twoDimentionalArrayStart = CreateTwoDimArray(rows, columns);
int[,] twoDimentionalArrayFinal = CreateTwoDimArray(columns, rows);
FillTwoDimArray(twoDimentionalArrayStart);
PrintDimArray(twoDimentionalArrayStart);
ChangeRowsWithColumns(twoDimentionalArrayStart, twoDimentionalArrayFinal);
PrintDimArray(twoDimentionalArrayFinal);
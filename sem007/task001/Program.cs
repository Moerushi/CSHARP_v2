// Задача 1: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

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
// 4. Обменять первую и последнюю строку
void ChangeLines(int[,] array)
{
  int temp = 0;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    temp = array[0, i];
    array[0, i] = array[array.GetLength(0)-1, i];
    array[array.GetLength(0)-1, i] = temp;
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
int[,] twoDimentionalArray = CreateTwoDimArray(rows, columns);
FillTwoDimArray(twoDimentionalArray);
PrintDimArray(twoDimentionalArray);
ChangeLines(twoDimentionalArray);
PrintDimArray(twoDimentionalArray);
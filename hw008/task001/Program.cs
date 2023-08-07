// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по УБЫВАНИЮ элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Подзадачи:
// 1. Создать массив
int[,] CreateTwoDimArray(int row, int column)
{
  return new int[row, column];
}
// 2. Заполнить массив случайными числами от 1 до 9
void FillTwoDimArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 10);
    }
  }
}
// 3. Распечатать массив (изначальный и итоговый)
void PrintDimArray(int[,] array)
{
  Console.WriteLine(" ");
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($" {array[i, j]} ");
    }
    Console.WriteLine(" ");
  }
}
// 4. Провести сортировку по строкам (по убыванию)
void SortDimArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int n = 0; n < array.GetLength(1)-1; n++)
    { 
    for (int j = 0; j < array.GetLength(1)-1; j++)
    {
      if (array[i, j] < array[i, j + 1])
      {
        int temp = array[i, j];
        array[i, j] = array[i, j + 1];
        array[i, j + 1] = temp;
      }
    }
    }
  }
}

// Решение:
int rows = new Random().Next(2, 10);
int columns = new Random().Next(2, 10);
int[,] userArray = CreateTwoDimArray(rows, columns);
FillTwoDimArray(userArray);
PrintDimArray(userArray);
SortDimArray(userArray);
PrintDimArray(userArray);
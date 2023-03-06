// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Подзадачи:
// 1. Создать матрицу
int[,] CreateTwoDimArray(int row, int column)
{
  return new int[row, column];
}
// 2. Заполнить матрицу
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
// 3. Напечатать матрицу для проверки
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
// 4. Расчет среднего арифметического
void CalculateArithmeticMean(int[,] array)
{
  double result = 0;
  for (int j = 0; j < array.GetLength(1); j++)
  {
    for (int i = 0; i < array.GetLength(0); i++)
    {
      result += array[i, j];
    }
    result = Math.Round(result / (array.GetLength(0)), 2);
    Console.WriteLine($"Arithmetic mean of {j + 1} column is {result}.");
    result = 0;
  }
}

// Решение:
int rows = 3;
int columns = 4;
int[,] userTwoDimArray = CreateTwoDimArray(rows, columns);
FillTwoDimArray(userTwoDimArray);
PrintDimArray(userTwoDimArray);
CalculateArithmeticMean(userTwoDimArray);
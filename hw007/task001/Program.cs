// Задача 47. Задайте двумерный массив размером m×n,
//  заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Подзадачи:
// 1. Создать пустой массив по заданным параметрам m = 3, n = 4
double[,] CreateTwoDimArray(int row = 3, int column = 4)
{
  return new double[row, column];
}
// 2. Создание отрицательного числа
bool DoNegative()
{
  int number = new Random().Next(100);
  if (number > 50) return true;
  else return false;
}
// 3. Заполнить матрицу
void FillTwoDimArray(double[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      bool k = DoNegative();
      if (k)
      {
        matr[i, j] = Math.Round(new Random().NextDouble() * 10 * -1, 1);
        if (matr[i, j] == 0)
        {
          matr[i, j] = 0;
        }
      }
      else
      {
        matr[i, j] = Math.Round(new Random().NextDouble() * 10, 1);
      }
    }
  }
}
// 4. Напечатать матрицу для проверки
void PrintDimArray(double[,] array)
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

// Решение:
double[,] newDimArray = CreateTwoDimArray();
FillTwoDimArray(newDimArray);
PrintDimArray(newDimArray);
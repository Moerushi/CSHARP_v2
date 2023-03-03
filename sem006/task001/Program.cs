// Перемножить матрицы.

// Подзадачи:
// 1. Задать матрицу
int[,] matrixA = new int[3, 6];
int[,] matrixB = new int[6, 4];
// 2. Заполнить числами (рандомными от 1 до 10)
void FillMatrix(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      matr[i, j] = new Random().Next(1, 10);
    }
  }
}
// 3. Печать матрицы
void PrintMatrix(int[,] matr, string text)
{
  Console.WriteLine(text);
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      Console.Write($"{matr[i, j]} ");
    }
    Console.WriteLine(" ");
  }
  Console.WriteLine(" ");
}
// 4. Перемножить
int[,] MultMatrix(int[,] firstMatr, int[,] secondMatr)
{
  int[,] multMatr = new int[firstMatr.GetLength(0), secondMatr.GetLength(1)];
  for (int i = 0; i < multMatr.GetLength(0); i++)
  {
    for (int j = 0; j < multMatr.GetLength(1); j++)
    {
      for (int n = 0; n < firstMatr.GetLength(1); n++)
      {
        multMatr[i, j] = multMatr[i, j] + firstMatr[i, n] * secondMatr[n, j];
      }
    }
  }
  return multMatr;
}
// 5. Проверка валидности матриц
void CheckPosibility(int[,] firstMatrix, int[,] secondMatrix)
{
  int[,] resultMatrix = MultMatrix(matrixA, matrixB);
  
  if (firstMatrix.GetLength(1) == secondMatrix.GetLength(0))
  {
    PrintMatrix(resultMatrix, "Multiplied matrix: ");
  }
  else
  {
    Console.WriteLine("This matrices can NOT be multiplied.");
  }
}
// Решение:

FillMatrix(matrixA);
FillMatrix(matrixB);
PrintMatrix(matrixA, "First matrix: ");
PrintMatrix(matrixB, "Second matrix: ");
CheckPosibility(matrixA, matrixB);
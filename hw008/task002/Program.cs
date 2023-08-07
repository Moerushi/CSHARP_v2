// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 0 строка

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
// 3. Посчитать сумму элементов в каждой строке
int[] SumLineCalculations(int[,] array)
{
  int[] sumInLine = new int[array.GetLength(0)];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      sumInLine[i] = sumInLine[i] + array[i, j];
    }
  }
  return sumInLine;
}
// 4. Поиск минимального среди сумм строк массива
string FindMinInArray(int[] array)
{
  int minIndex = 0;
  int minSum = array[minIndex];
  string sumIndices = string.Empty;
  for (int i = 1; i < array.Length; i++)
  {
    if (array[i] == minSum)
    {
      sumIndices = sumIndices + ", " + Convert.ToString(i + 1);
    }
    else if (array[i] < minSum)
    {
      minSum = array[i];
      minIndex = i;
      sumIndices = Convert.ToString(minIndex + 1);
    }
    else if (minSum == array[0] && array[i] == minSum)
    {
      sumIndices = sumIndices + ", " + Convert.ToString(i + 1);
    }
    else if (minSum == array[0])
    {
      sumIndices = Convert.ToString(minIndex + 1);
    }
  }
  return sumIndices;
}
// 5. Распечатать массив с результатом по каждой строке
void PrintDimArray(int[,] array, int[] sumArray)
{
  Console.WriteLine(" ");
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($" {array[i, j]} ");
    }
    Console.Write($"= {sumArray[i]} ({i + 1} line)");
    Console.WriteLine();
  }
}

// Решение:
int rows = new Random().Next(2, 10);
int columns = new Random().Next(2, 10);
int[,] userArray = CreateTwoDimArray(rows, columns);
FillTwoDimArray(userArray);
int[] sumArray = SumLineCalculations(userArray);
PrintDimArray(userArray, sumArray);
string min = FindMinInArray(sumArray);
Console.WriteLine($"Min sum of elements is in line(s) {min}.");
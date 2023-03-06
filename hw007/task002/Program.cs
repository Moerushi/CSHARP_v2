// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

// Подзадачи:
// 1. Создать массив
int[,] CreateTwoDimArray(int row, int column)
{
  return new int[row, column];
}
// 2. Заполнить массив
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
// 3. Получить число от пользователя
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
// 4. Напечатать матрицу для проверки
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
// 5. Проверить и вывести результат
void CheckUserDataPrint(int[,] array, int row, int column)
{
  if (row <= array.GetLength(0) && column <= array.GetLength(1))
  {
  Console.WriteLine($"Number in [{row},{column}] is {array[row-1,column-1]}.");
  }
  else
  {
  Console.WriteLine($"There is no data in [{row},{column}].");
  }
}

// Решение:
int rows = new Random().Next(2,11);
int columns = new Random().Next(2,11);
int[,] newDimArray = CreateTwoDimArray(rows,columns);
FillTwoDimArray(newDimArray);
PrintDimArray(newDimArray);
int userCheckRow = GetIntNumber("Input row to check: ");
int userCheckColumn = GetIntNumber("Input column to check: ");
CheckUserDataPrint(newDimArray, userCheckRow, userCheckColumn);
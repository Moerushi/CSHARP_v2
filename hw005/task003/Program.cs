// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// Подзадачи:
// 1. Создать массив вещественных чисел double
double[] CreateDoubleArray(int size)
{
  return new double[size];
}
// 2. Заполнить массив
void FillRandomDoubleArray(double[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = Math.Round(new Random().NextDouble() * 100, 0);
  }
}
// 3. Напечатать массив для последующей проверки
void PrintArray(double[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    if (i != array.Length - 1)
    {
      Console.Write($"{array[i]}, ");
    }
    else
    {
      Console.WriteLine($"{array[i]}");
    }
  }
}
// 4. Найти максимальный и минимальный элемент
double[] FindMaxMinNumber(double[] array)
{
  double[] maxMinNumbers = new double[2];
  // Минимальный с индексом 0
  maxMinNumbers[0] = array[0];
  // Максимальный с индексом 1
  maxMinNumbers[1] = array[0];
  for (int i = 1; i < array.Length; i++)
  {
    if (array[i] > maxMinNumbers[1])
    {
      maxMinNumbers[1] = array[i];
    }
    if (array[i] < maxMinNumbers[0])
    {
      maxMinNumbers[0] = array[i];
    }
  }
  return maxMinNumbers;
}
// 5. Высчитать разницу между максимальным и минимальным
double CountDifference(double[] array)
{
  double difference = array[1] - array[0];
  return difference;
}
// 6. Вывести результат

// Решение:
int size = 5;
double[] numbers = CreateDoubleArray(size);
FillRandomDoubleArray(numbers);
PrintArray(numbers);
double[] minMax = FindMaxMinNumber(numbers);
double result = CountDifference(minMax);
Console.WriteLine($"Difference between max ({minMax[1]}) and min ({minMax[0]}) number in array is {result}.");
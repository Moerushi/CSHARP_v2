using static Shared;

// Задайте массив из 12 элементов, заполненный случайными 
// числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма 
// положительных чисел равна 29, сумма отрицательных равна -20.

// Подзадачи:
// 1. Создать массив из 12 элементов
// 2. Заполнить массив случайными числами
// 3. Вывести массив для последующей проверки
// 4. Провести расчет
int[] Calculations(int[] array)
{
  int[] result = new int[2];
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > 0)
    {
      result[0] = result[0] + array[i];
    }
    else if (array[i] < 0)
    {
      result[1] = result[1] + array[i];
    }
  }
  return result;
}
// 5. Вывести результат
void PrintResult(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > 0)
    {
      Console.WriteLine($"Sum of positive numbers is  {array[i]}");
    }
    else
    {
      Console.WriteLine($"Sum of negative numbers is {array[i]}");
    }
  }
}

// Решение: 
int size = 12;
int[] numbers = CreateIntArray(size);
int minBondary = -9;
int maxBondary = 9;
FillRandomIntArray(numbers, minBondary, maxBondary);
PrintArray(numbers);
int[] answer = Calculations(numbers);
PrintResult(answer);

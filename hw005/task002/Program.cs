using static Shared;

// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Подзадачи:
// 1. Создать массив
// 2. Заполнить массив случайными числами [-100, 101]
// 3. Посчитать сумму элементов
int CountEvenSum(int[]array)
{
  int sum = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (i%2!=0)
    {
      sum = sum + array [i];
    }
  }

  return sum;
}
// 4. Вывести результат

// Решение:
int size = 4;
int[] numbers = CreateIntArray(size);
FillRandomIntArray(numbers,-100,101);
PrintArray(numbers);
Console.WriteLine($"Sum of numbers under odd index in array is {CountEvenSum(numbers)}.");
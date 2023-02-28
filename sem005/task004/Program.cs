using static Shared;

// Задайте одномерный массив из 123 случайных чисел. Найдите КОЛИЧЕСТВО элементов массива, значения 
// которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// Подзадачи:
// 1. Создать массив из 123 элементов
// 2. Заполнить массив случайными числами от 1 до 123
// 3. Проверить каждый массив на наличие условия: числа лежат в отрезке [10,99]
int NumbersSelection(int[]array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] >= 10 && array[i]<=99)
    {
      count++;
    }
  }
  return count;
}
// 4. Вывести результат

// Решение:
int size = 123;
int[] numbers = CreateIntArray(size);
FillRandomIntArray(numbers,1,123);
PrintArray(numbers);
Console.WriteLine($"Quantity of numbers between 10 and 99 is {NumbersSelection(numbers)}");
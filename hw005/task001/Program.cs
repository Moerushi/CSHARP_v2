using static Shared;

// Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет КОЛИЧЕСТВО чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// Подзадачи:
// 1. Создать массив из N элементов
// 2. Заполнить случайными положительными трехзначными числами 
// 3. Выполнить проверку на наличие четных чисел
int CheckNumberCount(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0)
    {
      count++;
    }
  }
  return count;
}
// 4. Вывести результат

// Решение:
int size = 5;
int[] numbers = CreateIntArray(size);
FillRandomIntArray(numbers, 100, 1000);
PrintArray(numbers);
int result = CheckNumberCount(numbers);
Console.WriteLine($"Quantity of even numbers in random array is {result}.");
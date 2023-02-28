// Напишите программу, которая выводит случайное
// число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

// Подзадачи:
// 1. Сформировать случайное число
int GenerateNumber()
{
  return new Random().Next(10, 100);
}
// 2. Создать массив из 2 элементов
int[] CreateArray()
{
  return new int[2];
}
// 3. Разложить значение на 2 числа
void ExtractNumbers(int[] array, int number)
{
  array[0] = number / 10;
  array[1] = number % 10;
}
// 4. Сравнить 2 числа
int CompareNumbers(int[] array)
{
  int max = 0;
  if (array[0] > array[1])
  {
    max = array[0];
  }
  else
  {
    max = array[1];
  }
  return max;
}
// 5. Вывести результат
void PrintResult(int number, int randNum)
{
  Console.WriteLine($"Maximum number of {randNum} is {number}.");
}

// Решение:

int randomNumber = GenerateNumber();
int[] numbers = CreateArray();
ExtractNumbers(numbers, randomNumber);
int maxNumber = CompareNumbers(numbers);
PrintResult(maxNumber, randomNumber);
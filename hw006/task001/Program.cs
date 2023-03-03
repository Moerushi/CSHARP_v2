// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Подзадачи:
// 1. Попросить ввести количество чисел для ввода
int GetIntNumber(string text)
{
  Console.WriteLine(text);
  return Convert.ToInt32(Console.ReadLine());
}
// 2. Попросить пользователя заполнить массив
int[] UserNumbers(int sizeNum)
{
  int[] numbers = new int[sizeNum];
  for (int i = 0; i < sizeNum; i++)
  {
    numbers[i] = GetIntNumber($"Input {i + 1} number: ");
  }
  return numbers;
}
// 3. Проверка числа на условие задачи
int CheckAndCount(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > 0)
    {
      count++;
    }
  }
  return count;
}
// 4. Вывод результата

// Решение:
int size = GetIntNumber("Input quantity of numbers: ");
int[] userNumbers = UserNumbers(size);
Console.WriteLine($"Quanity of numbers among yours that is more than zero is {CheckAndCount(userNumbers)}.");
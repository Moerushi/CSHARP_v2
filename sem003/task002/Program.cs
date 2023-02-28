// Задача: сколько раз какое число встречается в массиве

// 1 3 1 2 1 2 4 5 1 2 5 4
// 1 - 4р
// 2 - 3р
// 3 - 1р
// 4 - 2р
// 5 - 2р

// Подзадачи:
// 1. Получить число, обозначающее длинну массива
int getNumber(string text)
{
  Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}
// 2. Создать массив
int[] createArray(int size)
{
  return new int[size];
}
// 3. Распечатать исходный массив
string printArray(int[] array)
{
  string result = String.Empty;
  int length = array.Length;
  int index = 0;
  while (index < length)
  {
    result = result + " " + array[index];
    index++;
  }
  return result;
}
// 4. Заполнить массив (случайно числами от 1 до числа пользователя)
void fillArrayByUser(int[] array, int randNum)
{
  int size = array.Length;
  int index = 0;
  while (index < size)
  {
    array[index] = new Random().Next(randNum);
    index++;
  }
}
// 5.1 Определить повторяющиеся элементы в массиве, посчитать и вывести их
// void determineUniqueNumbersOne(int[] array, int randSize)
// {
//   int countUnique = 0;
//   bool[] uniqueNumbers = new bool[randSize];
//   for (int i = 0; i < array.Length; i++)
//   {
//     int currentValue = array[i];
//     if (!uniqueNumbers[currentValue])
//     {
//       for (int j = 0; j < array.Length; j++)
//       {
//         if (array[i] == array[j])
//         {
//           countUnique++;
//         }
//       }
//       Console.WriteLine($"{array[i]} is reapited {countUnique} time(s).");
//       countUnique = 0;
//       uniqueNumbers[currentValue] = true;
//     }
//   }
// }
// 5.2 Определить повторяющиеся элементы в массиве, посчитать и вывести их
// (оптимальный вариант без перебора по несколько раз)
void determineUniqueNumbersTwo(int[] array, int randSize)
{
  int[] counter = new int[randSize];
  for (int i = 0; i < array.Length; i++)
  {
    counter[array[i]]++;
  }
  for (int i = 0; i < array.Length; i++)
  {
    if (counter[i] != 0)
    {
    Console.WriteLine($"{i} is reapited {counter[i]} time(s).");
    }
  }
}
// Решение: 
int size = getNumber("Input size of array: ");
int randomSize = getNumber("Input upper range of random numbers: ");
int[] numbers = createArray(size);
fillArrayByUser(numbers, randomSize);
Console.WriteLine(printArray(numbers));
determineUniqueNumbersTwo(numbers, randomSize);
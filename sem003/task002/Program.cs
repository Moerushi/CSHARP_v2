// Задача: сколько раз какое число встречается

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
// 3. Распечатать массив
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
// 4. Заполнить массив (случайно числами от 1 до 5)
void fillArrayByUser(int[] array)
{
  int size = array.Length;
  int index = 0;
  while (index < size)
  {
    array[index] = new Random().Next(1, 6);
    index++;
  }
}
// 5. Создать массив уникальных значений
// 5. Определить повторяющиеся элементы в массиве
void determineUniqueNumbers(int[] initialArray, int[] uniqueArray)
{
  int index = 0;
  int size = initialArray.Length;
  int sizeUniqueArray = uniqueArray.Length;
  int j = 0;
  uniqueArray[index] = initialArray[index];

  while (index < size)
  {
    if(uniqueArray[index] == initialArray[index-1])
    {
      sizeUniqueArray++;
      uniqueArray[index] = initialArray[index-1];
    }
      index++;
  }
}
// 6. Посчитать повторяющие элементы в массиве


// Решение: 
int size = getNumber("Input size of array: ");
int[] numbers = createArray(size);
fillArrayByUser(numbers);
Console.WriteLine(printArray(numbers));
int[] uniqueNumbers = createArray(1);
Console.WriteLine(printArray(uniqueNumbers));
determineUniqueNumbers(numbers, uniqueNumbers);

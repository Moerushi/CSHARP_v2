// Реализовать перемешивание массива

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
// 4. Заполнить массив (случайно)
void fillArrayRandom(int[] array)
{
  int size = array.Length;
  int index = 0;
  while (index < size)
  {
    array[index] = new Random().Next(1, 100);
    index++;
  }
}
// 5. Перемешивание (случайно)
void shuffleArray(int[] array)
{
  int size = array.Length;
  int index = 0;
  int temp = 0;
  while (index < size)
  {
    int indexRandom = new Random().Next(0,size);
    temp = array[index];
    array[index] = array[indexRandom];
    array[indexRandom] = temp;
    index++;
  }
}

// Решение: 
int size = getNumber("Input size of array: ");
int[] numbers = createArray(size);
fillArrayRandom(numbers);
Console.WriteLine(printArray(numbers));
shuffleArray(numbers);
Console.WriteLine(printArray(numbers));
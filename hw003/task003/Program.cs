// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Подзадачи:
// 1. Запросить ввод числа
int GetNumber(string text)
{
  Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}
// 2. Создать массив
int[] CreateArray(int size)
{
  return new int[size];
}
// 3. Заполнить массив
void FillArray(int[] array)
{
  int index = 0;
  int size = array.Length;
  while (index < size)
  {
    array[index] = (int)Math.Pow(index, 3);
    index++;
  }
}
// 4. Напечатать массив
void PrintArray(int[] array)
{
  int index = 0;
  int size = array.Length;
  while (index < size)
  {
    if (index != 0)
    {
      Console.WriteLine($"Cube of number {index} is {array[index]}");
    }
    index++;
  }
}

// Решение:
int size = GetNumber("Input quantity of cubes: ");
int[] cubesArray = CreateArray(size + 1);
FillArray(cubesArray);
PrintArray(cubesArray);
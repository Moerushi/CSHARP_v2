// Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Подзадачи:
// 1. Принять число от пользователя
int GetUserNumber(string text)

{
  Console.WriteLine(text);
  return Convert.ToInt32(Console.ReadLine());
}
// 2. Определить длину числа
int UserNumberSize(int number)
{
  int size;
  return size = (int)Math.Log10(number) + 1;
}
// 3. Создать массив по длине числа
int[] CreateArray(int length)
{
  return new int[length];
}
// 4. Разбить число на части и заполнить массив
void DevideUserNumber(int[] array, int number)
{
  int size = array.Length;
  for (int index = 0; index < array.Length; index++)
  {
    int numberPosition = (int)Math.Pow(10, index);
    array[index] = (number / numberPosition) % 10;
  }
}
// 5. Провести расчет
int CalculationSum (int[]array)
{
  int result = 0;
  for (int index = 0; index<array.Length; index++)
  {
    result = result + array[index];
  }
  return result;
}
// 6. Вывести результат
void ResultOutput(int number)
{
  Console.WriteLine("Answer: " + number);
}

// Решение:
int userNumber = GetUserNumber("Input number: ");
int numberSize = UserNumberSize(userNumber);
int[] numberComponents = CreateArray(numberSize);
DevideUserNumber(numberComponents, userNumber);
int answer = CalculationSum(numberComponents);
ResultOutput(answer);

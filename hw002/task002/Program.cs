// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Подзадачи:
// 1. Задать число пользователю
int getNumber(string text)
{
  Console.WriteLine(text);
  return Convert.ToInt32(Console.ReadLine());
}
// 2. Поиск длины числа и нахождение 3его знака
string findSolution(int number)
{
  string result = string.Empty;
  if (number > 99)
  {
    int size = (int)Math.Log10(number) + 1;
    int numberPosition = (int)Math.Pow(10, size - 3);
    result = "Third digit is " + (number / numberPosition) % 10;
  }
  else
  {
    result = "There is no third digit.";
  }
  return result;
}

int userNumber = getNumber("Insert your number: ");
Console.WriteLine(findSolution(userNumber));
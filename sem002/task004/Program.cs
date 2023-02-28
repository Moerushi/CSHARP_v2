// Напишите программу, которая принимает на вход два числа
// и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

// Подзадачи:
// 1. Получение чисел от пользователя
int GetNumber(string text)
{
  Console.WriteLine(text);
  return Convert.ToInt32(Console.ReadLine());
}
// 2. Сравнение двух чисел
string Comparison(int number1, int number2)
{
  string result = string.Empty;
  if (Math.Pow(number1, 2) == number2)
  {
    result = $"{number2} is square number of {number1}.";
  }
  else if (number1 == Math.Pow(number2, 2))
  {
    result = $"{number1} is square number of {number2}.";
  }
  else
  {
    result = $"{number2} is square number of {number1}.";
  }
  return result;
}

// Решение:
int firstNumber = GetNumber("Input first number: ");
int secondNumber = GetNumber("Input second number: ");
Console.WriteLine(Comparison(firstNumber, secondNumber));
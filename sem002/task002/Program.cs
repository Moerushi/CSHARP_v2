// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

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
  if (number1 % number2 == 0)
  {
    result = $"{number1} is divided by {number2} without remainder.";
  }
  else
  {
    result = $"{number1} is not divided by {number2} without remainder. Remainder is {number1 % number2}.";
  }
  return result;
}

// Решение:
int firstNumber = GetNumber("Input first number: ");
int secondNumber = GetNumber("Input second number: ");
Console.WriteLine(Comparison(firstNumber, secondNumber));
// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Подзадачи:
// 1. Ввод числа
int getNumber(string text)
{
  int randomNumber = new Random().Next(1, 1100);
  Console.WriteLine(text + randomNumber);
  return randomNumber;
}
// 2. Расчет
string secondNumberExtraction(int secondNumber)
{
  string result = String.Empty;
  if (secondNumber > 99 && secondNumber < 1000)
  {
    result = "Second digit is " + ((secondNumber / 10) % 10);
  }
  else
  {
    result = "Error: number is out of range"; ;
  }
  return result;
}

// Решение:
int userNumber = getNumber("Your number: ");
Console.WriteLine(secondNumberExtraction(userNumber));
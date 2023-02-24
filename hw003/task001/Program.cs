// Программа проверяет пятизначное число на палиндромом.

// Подзадачи:
// 1. Получить число (случайное в заданном диапазоне)
int GetNumber(string text)
{
  int randomNumber = new Random().Next(9999, 100000);
  Console.WriteLine("Your number: " + randomNumber);
  return randomNumber;
}
// 2. Сделать расчет
bool Palindrome(int number)
{
  int firstDigit = number / 10000;
  int secondDigit = number / 1000 % 10;
  int forthDigit = number / 10 % 10;
  int fifthDigit = number / 1 % 10;
  // string result = string.Empty;
  bool result = true;
  if (firstDigit == fifthDigit && secondDigit == forthDigit)
  {
    //  result = "Number " + number + " is a palindrome.";
    result = true;
  }
  else
  {
    //  result = "Number " + number + " is not a palindrome.";
    result = false;
  }
  return result;
}
// 3. Вывести результат
string PrintAnswer(bool check)
{
  string answer = string.Empty;
  if (check == true)
  {
    answer = "Your number is palindrome.";
  }
  else
  {
    answer = "Your number is NOT palindrome.";
  }
  return answer;
}

// Решение:
int randomNumber = GetNumber("Your number: ");
Console.WriteLine(PrintAnswer(Palindrome(randomNumber)));
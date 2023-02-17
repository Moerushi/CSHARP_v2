// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Подзадачи:
// 1. Создать массив с заданными данными
string[] weekHoliday = 
{
      "working day.", 
      "working day.", 
      "working day.",
      "working day.",
      "working day.", 
      "holiday.", 
      "holiday."
};

// 2. Получить число от пользователя
int getNumber(string text)
{
  Console.WriteLine(text);
  return Convert.ToInt32(Console.ReadLine());
}

// 3. Сделать расчет
string getAnswer(int number)
{
  string answer = string.Empty;
  if (number >= 1 && number <= 7)
  {
    answer = number + " of the week is " + weekHoliday[number - 1];
  }
  else
  {
    answer = "There is no such day";
  }
  return answer;
}
// Решение:

int userNumber = getNumber("Input your number of weekday: ");
Console.WriteLine(getAnswer(userNumber));
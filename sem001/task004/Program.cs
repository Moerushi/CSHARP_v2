// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

// Решение:

string[] weekDays = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
Console.Write("Введите номер дня недели: ");
int userDay = Convert.ToInt32(Console.ReadLine());
if (userDay < 7 && userDay > 0)
{
for (int index = 0; index - 1 < userDay; index++)
{
  if (userDay == index)
  {
    Console.WriteLine(weekDays[index - 1]);
  }
}
}
else
{
 Console.WriteLine("Нет такого дня недели!");
}
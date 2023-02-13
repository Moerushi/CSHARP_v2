Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
  int result = (number / 10) % 10;
  Console.WriteLine("Вторая цифра в Вашем числе: " + result);
}
else
{
  Console.WriteLine("Некорректное число");
}
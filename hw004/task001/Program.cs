// Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// нельзя использовать Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

//Подзадачи:
// 1. Ввод первого числа от пользователя
int GetNumberA(string text)
{
  Console.WriteLine(text);
  return Convert.ToInt32(Console.ReadLine());
}
// 2. Ввод степени от пользователя
int GetDegree(string text)
{
  Console.WriteLine(text);
  return Convert.ToInt32(Console.ReadLine());
}
// 3. Расчет
int Calculation(int number, int degree)
{
  int result = 1;
  for (int index = 0; index < degree; index++)
  {
    result = result * number;
  }
  return result;
}
// 4. Вывод числа
void ResultOutput(int number)
{
  Console.WriteLine("Answer: " + number);
}

//Решение:
int numberA = GetNumberA("Input number A: ");
int degreeNumber = GetDegree("Input degree of number A: ");
int result = Calculation(numberA, degreeNumber);
ResultOutput(result);

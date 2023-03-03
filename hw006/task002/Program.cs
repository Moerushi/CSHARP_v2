// Задача 43: Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Подзадачи:
// 1. Получение числа от пользователя:
double GetIntNumber(string text)
  {
    Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
  }
// 2. Создание массива (для ввода данных)
double[] CreateIntArray()
  {
    return new double[4];
  }
// 3. Получение данных от пользователя через заполнение массивов
void FillByUserNumbersArray(string[]text, double[]numbers)
{
  Console.WriteLine("Input variables: ");
  for (int i = 0; i < text.Length; i++)
  {
  numbers[i] = GetIntNumber(text[i]);
  }
}
// 4. Расчет X
double CalculationX(double[]array)
{
  double result = Math.Round(Convert.ToDouble((array[2]-array[0])/(array[1]-array[3])),1);
  return result;
}
// 5. Расчет Y
double CalculationY(double num, double[] array)
{
  double result = Math.Round(Convert.ToDouble(array[1]*num+array[0]),1);
  return result;
}
// 6. Вывод результата

// Решение:
Console.WriteLine ("Let's find piercing point of a two lines determined by following equations: ");
Console.WriteLine ("y = k1 * x + b1 and y = k2 * x + b2.");
string[] variables = new string[4] {"b1 = ","k1 = ","b2 = ","k2 = "};
double [] userNumbers = CreateIntArray();
FillByUserNumbersArray (variables, userNumbers);
double piercingX = CalculationX(userNumbers);
double piercingY = CalculationY(piercingX, userNumbers);
Console.WriteLine ($"Piercing point is ({piercingX}, {piercingY}).");
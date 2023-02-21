// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Подзадачи:
// 1. Создать массив
double[] createArray(int size)
{
  return new double[size];
}
// 2. Заполнить координаты точек, попросив пользователя
void fillArrayByUser(double[] array)
{
  int size = array.Length;
  int index = 0;
  while (index < size)
  {
    if (index == 0)
    {
      Console.Write("X = ");
      array[index] = Convert.ToDouble(Console.ReadLine());
    }
    else if (index == 1)
    {
      Console.Write("Y = ");
      array[index] = Convert.ToDouble(Console.ReadLine());
    }
    else if (index == 2)
    {
      Console.Write("Z = ");
      array[index] = Convert.ToDouble(Console.ReadLine());
    }
    index++;
  }
}
// 3. Высчитать результат
double distanceResult(double[] array1, double[] array2)
{
  return Math.Round(Math.Sqrt(Math.Pow(array2[0] - array1[0], 2) + Math.Pow(array2[1] - array1[1], 2) + Math.Pow(array2[2] - array1[2], 2)), 2);
}

// Решение:

double[] firstCoordinates = createArray(3);
double[] secondCoordinates = createArray(3);
Console.WriteLine("Input first coordinate: ");
fillArrayByUser(firstCoordinates);
Console.WriteLine("Input second coordinate: ");
fillArrayByUser(secondCoordinates);
Console.WriteLine($"Distance between two coordinates is {distanceResult(firstCoordinates, secondCoordinates)}");
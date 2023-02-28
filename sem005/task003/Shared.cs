public class Shared
{
  // Получение числа от пользователя
  public static int GetIntNumber(string text)
  {
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
  }

  // Создание пустого массива из N элементов по типу int
  public static int[] CreateIntArray(int size)
  {
    return new int[size];
  }

  // Заполнение массива случайными числами в заданном 
  // пользователем диапазоне по типу массива int
  public static void FillRandomIntArray(int[] array, int minBondary, int maxBondary)
  {
    for (int i = 0; i < array.Length; i++)
    {
      array[i] = new Random().Next(minBondary, maxBondary + 1);
    }
  }

  // Печать массива
  public static void PrintArray(int[] array)
  {
    for (int i = 0; i < array.Length; i++)
    {
      if (i != array.Length - 1)
      {
        Console.Write($"{array[i]}, ");
      }
      else
      {
        Console.WriteLine($"{array[i]}");
      }
    }
  }

}

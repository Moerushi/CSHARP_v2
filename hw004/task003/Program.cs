// Напишите метод, который задаёт массив из N элементов и выводит их на экран. 
// (дополнительно: считать эти данные из файла)
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Подзадачи:
// 1. Получить число от пользователя
int GetUserNumber(string text)

{
  Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}
// 2. Создать массив из рандомных чисел
int[] CreateArray(int length)
{
  return new int[length];
}
// 3. Заполнить массив случайными числами
void FillArrayWithRandomNumbers(int[] array)
{
  for (int index = 0; index < array.Length; index++)
  {
    array[index] = new Random().Next(1, 100);
  }
}
// 4. Преобразование в строку из массива
string ConvertToString(int[] array)
{
  string oneLine = string.Empty;
  for (int index = 0; index < array.Length; index++)
  {
    if (index == 0)
    {
      oneLine = $"{array[index]}";
    }
    else
    {
      oneLine = oneLine + ", " + array[index];
    }

  }
  return oneLine;
}
// 4. Проверка и создание нового файла в директории
void FillFile(string path, string msg)
{
    System.IO.File.WriteAllText(path, msg);
}
// 6. Извлечение данных
string ExctractText(string path)
{
  return File.ReadAllText(path);
}
// 7. Вывод результата на экран
void ResultOutput(string msg)
{
  Console.WriteLine($"Your array - [{msg}]");
}

//Решение:
int userNumber = GetUserNumber("Input number of elements: ");
int[] workingNumbers = CreateArray(userNumber);
FillArrayWithRandomNumbers(workingNumbers);
string file = "accumulate_file.txt";
string finalText = ConvertToString(workingNumbers);
FillFile(file, finalText);
string answer = ExctractText(file);
ResultOutput(answer);
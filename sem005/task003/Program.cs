using static Shared;

// Задача 3: Задайте массив. 
// Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// Подзадачи: 
// 1. Создать массив из заданного числа элементов
// 2. Заполнить массив
// 3. Запросить у пользователя число с проверкой
// 4. Проверить массив
bool CheckNumber(int[]array, int checkNumber)
{
  bool result = false;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] == checkNumber || array[i] == checkNumber*-1)
    {
     result = true;
    }
  }
  return result;
}
// 5. Выбор текста в зависимости от результата
string ResultMessage (bool var)
{
  string result = string.Empty;
  if (var)
  {
    result = "There is your number in array.";
  }
  else
  {
    result = "There is NO your number in array.";
  }
return result;
}
// 6. Вывести результат

// Решение:
int size = 5;
int[]numbers = CreateIntArray(size);
FillRandomIntArray(numbers, 1,100);
PrintArray(numbers);
int userNumber = GetIntNumber("Let's check your number: ");
bool result = CheckNumber(numbers, userNumber);
Console.WriteLine(ResultMessage(result));

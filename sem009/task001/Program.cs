// В неком городе (на плоскости) открыты магазины в количестве N. 
// Необходимо отметить магазины (M), которые нужно закрыть по наименьшему удалению от 
// одного из магазинов при этом M < N.

int[,] GetPoint2dList(int count, int minValue, int maxValue)
{
  int[,] table = new int[count, 2];

  for (int i = 0; i < count; i++)
  {
    int x = Random.Shared.Next(minValue, maxValue);
    int y = Random.Shared.Next(minValue, maxValue);
    table[i, 0] = x;
    table[i, 1] = y;
  }
  return table;
}

char[,] GetMap(int mapSize, int[,] points2d)
{
  char[,] map = new char[mapSize, mapSize];
  int count = points2d.GetLength(0);
  for (int i = 0; i < count; i++)
  {
    int x = points2d[i, 0];
    int y = points2d[i, 1];
    map[x, y] = 'x';
  }

  return map;
}

string MapPrinter(char[,] map)
{
  int size = map.GetLength(0);
  string result = String.Empty;

  for (int i = 0; i < size; i++)
  {
    for (int j = 0; j < size; j++)
    {
      if (map[i, j] == 'x') result += $"x";
      else result += $" ";
    }
    result += "\n";
  }
  return result;
}

int mapSize = 20;
int pointCount = 10;
int[,] point2dList = GetPoint2dList(pointCount, 0, mapSize);

char[,] map = GetMap(mapSize, point2dList);
string m = MapPrinter(map);
System.Console.WriteLine(m);
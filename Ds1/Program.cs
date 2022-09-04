Console.Clear();

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

if (m < 1 || n < 1)
{
    Console.Write("!! Размер строк или столбцов двумерного массива не может быть меньше 1 !!");
    return;
}
int[,] numbers = new int[m, n];

void RandomNumbersArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int count = array.Length;
            Console.Write(array[i, j]);
            if (j < n - 1)
            {
                Console.Write(", ");
            }
        }
        Console.Write(" ]");
        Console.WriteLine();
    }
}

void SortingArrayLines(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int с = 0; с < array.GetLength(1) - 1; с++)
      {
        if (array[i, с] < array[i, с + 1])
        {
          int temp = array[i, с + 1];
          array[i, с + 1] = array[i, с];
          array[i, с] = temp;
        }
      }
    }
  }
}

Console.WriteLine("Результат формирования двумерного массива: ");
RandomNumbersArray(numbers);
WriteArray(numbers);

Console.WriteLine("Результат сортировки двумерного массива по строкам: ");
SortingArrayLines(numbers);
WriteArray(numbers);
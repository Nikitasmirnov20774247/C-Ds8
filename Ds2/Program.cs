Console.Clear();

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

if (m < 1 || n < 1 || m == n)
{
    Console.Write("!! Размер строк и столбцов двумерного прямоугольного массива не может быть меньше 1 или равным друг другу !!");
    return;
}
int[,] array = new int[m, n];

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

int SumLineNumbers(int[,] array, int i)
{
    int sum = array[i,0];
    for (int j = 1; j < n; j++)
    {
        sum += array[i,j];
    }
    return sum;
}

Console.WriteLine();
Console.WriteLine("Результат формирования прямоугольного двумерного массива: ");
Console.WriteLine();
RandomNumbersArray(array);
WriteArray(array);

int sumLineMin = 0;
int sumLine = SumLineNumbers(array, 0);
for (int i = 1; i < m; i++)
{
    int tempSumLine = SumLineNumbers(array, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        sumLineMin = i;
    }
}

Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов - {sumLineMin + 1} (sum = {sumLine})");
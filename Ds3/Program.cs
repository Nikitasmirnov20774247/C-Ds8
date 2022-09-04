Console.Clear();

Console.Write("Введите количество строк первой матрицы: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов первой матрицы: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.Write("Введите количество строк второй матрицы: ");
int s = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов второй матрицы: ");
int c = int.Parse(Console.ReadLine());

if (n < 1 || m < 1 || s < 1 || c < 1)
{
    Console.Write("!! Размер строк и столбцов матриц не может быть меньше 1 !!");
    return;
}

int[,] matrix1 = new int[m, n];
int[,] matrix2 = new int[s, c];
int[,] matrix3 = new int[m, c];


void MultiplyMatrix(int[,] martrix1, int[,] martrix2, int[,] martrix3)
{
    for (int i = 0; i < martrix3.GetLength(0); i++)
    {
        for (int j = 0; j < martrix3.GetLength(1); j++)
        {
        int sum = 0;
        for (int c = 0; c < martrix1.GetLength(1); c++)
        {
            sum += martrix1[i, c] * martrix2[c, j];
        }
        martrix3[i, j] = sum;
        }
    }
}

void RandomNumbersArray(int[,] martrix)
{
    for (int i = 0; i < martrix.GetLength(0); i++)
    {
        for (int j = 0; j < martrix.GetLength(1); j++)
        {
            martrix[i, j] = new Random().Next(10);
        }
    }
}

void WriteArray(int[,] martrix)
{
    for (int i = 0; i < martrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < martrix.GetLength(1); j++)
        {
            int count = martrix.Length;
            Console.Write(martrix[i, j]);
            if (j < n - 1)
            {
                Console.Write(", ");
            }
        }
        Console.Write(" ]");
        Console.WriteLine();
    }
}

Console.WriteLine();
Console.WriteLine("Результат формирования матрицы 1: ");
RandomNumbersArray(matrix1);
WriteArray(matrix1);

Console.WriteLine();
Console.WriteLine("Результат формирования матрицы 2: ");
RandomNumbersArray(matrix2);
WriteArray(matrix2);

if (n != s)
{
    Console.WriteLine();
    Console.Write("!! Произведение матриц возможно только в том случае, если число столбцов 1-й матрицы равно числу строк 2-й матрицы !!");
    return;
}

Console.WriteLine();
Console.WriteLine("Результат перемножения двух матриц: ");
MultiplyMatrix(matrix1, matrix2, matrix3);
WriteArray(matrix3);
int [,] array = CreateArray();
FillArray(array, -100, 100);
PrintArray(array);

int[,] CreateArray()
{
    System.Console.WriteLine("Enter m and n, where m is the number of rows and n is the number of collumns");
    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[m, n];
    return array;
}
void FillArray(int[,] a, int min, int max)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = new Random().Next(min, max + 1);
        }
    }
}
void PrintArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            System.Console.Write($"{a[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
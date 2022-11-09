double[,] array = new double[3, 4];
FillArray(array, 0, 10);
System.Console.WriteLine("The array is:");
Print2DArray(array);
PrintArray(ArrayAMean(array));

void FillArray(double[,] a, int min, int max)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = new Random().Next(min, max + 1);
        }
    }
}
void Print2DArray(double[,] a)
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
double[] ArrayAMean(double[,] a)
{
    double sum;
    double[] holder = new double[a.GetLength(1)];
    for (int j = 0; j < a.GetLength(1); j++)
    {
        sum = 0;
        for (int i = 0; i < a.GetLength(0); i++)
        {
            sum += a[i, j];
        }
        holder[j] = sum / a.GetLength(0);
    }
    return holder;
}
void PrintArray(double[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        System.Console.WriteLine($"The arithmetic mean of the {i + 1} column is {a[i]:f1}");
    }
}
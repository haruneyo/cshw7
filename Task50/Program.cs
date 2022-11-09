int[,] array = new int[5, 5];
FillArray(array, -10, 10);
System.Console.WriteLine("The array is:");
PrintArray(array);
System.Console.WriteLine("Please enter the index (rows, columns):");
System.Console.WriteLine(ArrayValueOfIndex(array)); // Returns the value of the given index, if applicable
System.Console.WriteLine("Please enter the value:");
System.Console.WriteLine(ArrayIndexOfValue(array)); // Returns the index of the given value, if applicable

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
string ArrayValueOfIndex(int[,] a)
{
    string value = "This index does not exist in the current array";
    int row = Convert.ToInt32(Console.ReadLine());
    int col = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if (row == i && col == j) value = $"{a[i, j]}";
        }
    }
    return value;
}
string ArrayIndexOfValue(int[,] a)
{
    string index = "This value does not exist in the current array";
    int value = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if (value == a[i, j])
            {
                index = $"The index of the number {value} is {(i, j)}";
                goto Flag;
            }
            
        }
    }
    Flag: 
    return index;
}
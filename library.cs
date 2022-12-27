
public static class library
{
    /// <summary>
    /// Метод генерирует случайное число от 1 до 10 
    /// </summary>
    /// <returns></returns>
    public static int RandomNumbers_1()
    {
        int RandomNumbers = new Random().Next(1, 10);
        return RandomNumbers;
    }

    public static int[,] CrtTwoDimArr(int x, int y)
    {
        return new int[x, y];
    }

    public static void PrintTwoDimArr(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    public static void FillTwoDimArr(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = new Random().Next(1, 10);
            }
        }
    }
}
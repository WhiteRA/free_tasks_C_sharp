
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
}
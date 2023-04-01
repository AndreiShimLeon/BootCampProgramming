/// <summary>
/// Это класс, отвечающий за создание массива
/// </summary>


public static class ArrayCreator
{
    /// <summary>
    /// Метод создания массива
    /// </summary>
    /// <param name="n">Количество элементов</param>
    /// <returns>Новый массив</returns>

    public static int[] Create(this int n)
    {
        return new int[n];
    }

    /// <summary>
    /// Переводит массив в строку
    /// </summary>
    /// <param name="array">Количество элементов</param>
    /// <returns>Строку с представлением массива</returns>

    public static string ConvertToStringAndPrintToTerminal(this int[] array)
    {
        string str = $"[{String.Join(',', array)}]";
        Console.WriteLine(str);
        return str;
    }
    /// <summary>
    /// Заполняет массив
    /// </summary>
    /// <param name="array">Массив</param>
    /// <param name="min">Нижняя граница генератора случайных чисел</param>
    /// <param name="max">Верхняя граница генератора случайных чисел</param>
    /// <returns>Строку с представлением массива</returns>

    public static int[] Fill(this int[] array, int min = 0, int max = 10, int seed = 0)
    {
        Random random = seed == 0 ? 
            random = new Random() : 
            random = new Random(seed);

        return array.Select(item => random.Next(min, max)).ToArray();
    }
}

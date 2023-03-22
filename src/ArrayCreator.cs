/// <summary>
///  The class responsible for creating the array
/// </summary>
public static class StringArrayCreator
{
    /// <summary>
    ///  Array creation method.
    /// </summary>
    /// <param name="n">Amount of elements.</param>
    /// <returns>New array.</returns>
    public static string[] Create(this int n)
    {
        return new string[n];
    }

    /// <summary>
    ///  Prints array content.
    /// </summary>
    /// <param name="arr">Array to print.</param>
    /// <returns>The array received for printing</returns>
    public static string[] Print(this string[] arr)
    {
        Console.WriteLine("[ {0} ]", string.Join(", ", arr));

        return arr;
    }


    /// <summary>
    /// Fill array with random words.
    /// </summary>
    /// <param name="arr">Array to fill.</param>
    /// <param name="minStrLen">Min length of string.</param>
    /// <param name="maxStrLen">Max length of string.</param>
    /// <param name="seek">Getting the same sequence of random values</param>
    /// <returns>The array received for filling</returns>
    public static string[] FillWithRandomStrings(this string[] arr, int minStrLen = 1, int maxStrLen = 9, int seek = 0)
    {
        Random rnd = new Random(seek);

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = GenerateString(rnd, rnd.Next(minStrLen, maxStrLen + 1));
        }

        return arr;
    }

    /// <summary>
    /// Generates random string.
    /// </summary>
    /// <param name="rnd">Object of Random.</param>
    /// <param name="len">Desired length of string.</param>
    /// <returns>Random string of desired length.</returns>
    private static string GenerateString(Random rnd, int len)
    {
        char[] letters = new char[len];

        for (int i = 0; i < len; i++)
        {
            letters[i] = GenerateChar(rnd);
        }

        return new string(letters);
    }

    /// <summary>
    /// Generates random char.
    /// </summary>
    /// <param name="rnd">Object of Random.</param>
    /// <returns>Random char.</returns>
    private static char GenerateChar(Random rnd)
    {
        return (char)(rnd.Next('A', 'Z' + 1));
    }
}
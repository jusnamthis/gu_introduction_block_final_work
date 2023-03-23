using static StringArrayCreator;

/// <summary>
/// A class for working with string arrays.
/// </summary>
public static class StringArrayWorker
{
    /// <summary>
    /// Find words less than length.
    /// </summary>
    /// <param name="arr">The array to search in.</param>
    /// <param name="maxLen">Max length of word to look for.</param>
    /// <returns>A new array containing elements satisfying the condition.</returns>
    public static string[] GetValuesLessThanLength(this string[] arr, int maxLen)
    {
        (bool[], int) markedArrAndElemsThatSatisfyCondition = GetMarkedArrayOfElemsThatMeetsTheConditionAndElemsAmount(arr, maxLen);
        var markedArr = markedArrAndElemsThatSatisfyCondition.Item1;
        var suitableElemsAmount = markedArrAndElemsThatSatisfyCondition.Item2;

        string[] satisfyingElems = suitableElemsAmount.Create();
        var satisfyingCounter = 0;

        for (int i = 0; i < markedArr.Length; i++)
        {
            if (markedArr[i])
            {
                satisfyingElems[satisfyingCounter++] = arr[i];
            }
        }

        return satisfyingElems;
    }

    /// <summary>
    /// Сreates an array of bool elements of the same length as the passed array, marks the elements satisfying the condition as true and counts their number.
    /// </summary>
    /// <param name="arr">The array to search in.</param>
    /// <param name="condition">The length of words</param>
    /// <returns>The length of the words satisfying the condition.</returns>
    private static (bool[], int) GetMarkedArrayOfElemsThatMeetsTheConditionAndElemsAmount(string[] arr, int condition)
    {
        var markedArr = new bool[arr.Length];
        var passed = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= condition)
            {
                markedArr[i] = true;
                passed++;
            }
            else
            {
                markedArr[i] = false;
            }
        }

        return (markedArr, passed);
    }
}
namespace Arrays;

internal class Assignment2
{
    public void ReverseArray()
    {
        int[] array1 = { 1, 2, 3, 4, 5 };
        string joined = string.Join(", ", ReverseArray(array1));
        Console.WriteLine(joined);
    }

    public IEnumerable<int> ReverseArray(int[] inputArray)
    {
        return inputArray.Reverse();
    }
}

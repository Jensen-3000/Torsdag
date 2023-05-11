namespace Arrays;

internal class Assignment3
{
    public int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    public int[] MinMax(int[] minMax)
    {
        int[] newMinMax = new int[2];

        newMinMax[0] = minMax.Min();
        newMinMax[1] = minMax.Max();

        return newMinMax;
    }

    public void MinMax()
    {
        int[] minmax = MinMax(array);

        foreach (var item in minmax)
        {
            Console.WriteLine(item);
        }
    }
}

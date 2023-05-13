namespace Arrays;

internal class Assignment4
{
    // 1
    float[] floats = { 3.14f, 2.718f, 1.618f, 0.577f };

    // 2
    public float GetFloats(float[] floatNumbers)
    {
        return floatNumbers.Average();
    }

    public void DisplayFloats()
    {
        Console.WriteLine(GetFloats(floats));
    }

}

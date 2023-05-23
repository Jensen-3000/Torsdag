internal class UtilHelper
{
    public void DisplaySeparator(string text)
    {
        Console.WriteLine();
        Console.Write(new string('-', 10));
        Console.Write(text);
        Console.WriteLine(new string('-', 10));
    }
    public void DisplaySeparator()
    {
        Console.WriteLine(new string('-', 40));
    }

    public void DisplayTextWithColor(string text)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(text);
        Console.ResetColor();
    }

    public void DisplayAnimals<T>(IEnumerable<T> data, string text)
    {
        DisplayTextWithColor(text);
        foreach (T item in data)
        {
            Console.WriteLine($"  {item}");
        }
    }
    public void DisplaySingleAnimal<T>(T data, string text)
    {
        DisplayTextWithColor(text);
        Console.WriteLine($"  {data}");
    }
}

namespace Tirsdag;

internal class UtilHelper
{
    public void DisplaySeparator(string text)
    {
        Console.WriteLine();
        Console.Write(new string('-', 10));
        Console.Write(text);
        Console.WriteLine(new string('-', 10));
    }
}

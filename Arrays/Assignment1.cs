namespace Arrays;

// Assignment 1: Array Initialization and Iteration

// Declare and initialize an array of integers with the numbers 1 to 10.
// Write a for loop to iterate over the array and print each element to the console.

internal class Assignment1
{

    int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    string joinedString;

    public void ArrayForeach()
    {
        foreach (int i in array)
        {
            Console.WriteLine(i);
        }

    }
    public void ArrayStringJoin()
    {
        joinedString = string.Join(", ", array);
        Console.WriteLine(joinedString);
    }

    
}

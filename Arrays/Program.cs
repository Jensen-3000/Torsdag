using Arrays;
using System.Runtime.InteropServices;


void DisplaySeparator()
{
    Console.WriteLine(new string('-', 40));
}

#region Assignment 1
Console.WriteLine("Assignment 1: Array Initialization and Iteration...\n");
Assignment1 assignment1 = new Assignment1();

assignment1.ArrayForeach();
assignment1.ArrayStringJoin();
#endregion

DisplaySeparator();

#region Assignment 2
Console.WriteLine("Assignment 2: Array Reversal...\n");
Assignment2 assignment2 = new Assignment2();

assignment2.ReverseArray();
#endregion


DisplaySeparator();

#region Assignment 3
Console.WriteLine("Assignment 3: Find the Maximum and Minimum...\n");
Assignment3 assignment3 = new Assignment3();

assignment3.MinMax();
#endregion

#region Assignment 4
DisplaySeparator();
Console.WriteLine("Assignment 4: Array Average");
Assignment4 assignment4 = new Assignment4();

assignment4.DisplayFloats();
#endregion
using System.Text;

namespace Tirsdag;

internal class Methods
{
    public void CreateManyAnimals(Database database)
    {
        List<Animal> animalList = new List<Animal>()
        {
            new Animal { Age = 5, Color = "red", Firstname = "Fluffy", Lastname = "McWigglesworth"},
            new Animal { Age = 25, Color = "blue", Firstname = "Sir", Lastname = "Pawsalot" },
            new Animal { Age = 25, Color = "yellow", Firstname = "Professor", Lastname = "Quackerton" },
            new Animal { Age = 55, Color = "orange", Firstname = "Duchess", Lastname = "Floofy" },
            new Animal { Age = 95, Color = "red", Firstname = "Captain", Lastname = "Bumblebee"},
        };

        foreach (Animal item in animalList)
        {
            database.Create(item);
        }
    }

    public void ReadAnimalObj(Database database)
    {
        int id = 5;
        Animal animal = new Animal { Id = id };

        animal = database.Read(animal);

        if (animal != null)
            Console.WriteLine(animal);
        else
            Console.WriteLine($"Kunne ikke finde Animal med Id: {id}");
    }

    public void ReadAllCRUD(Database database)
    {
        List<Animal> animals = database.ReadAll();
        foreach (var item in animals)
        {
            Console.WriteLine(item);
        }
    }

    public void DeleteCRUD(Database database)
    {
        int entryToDel = 5;
        bool delSuccess = database.Delete(entryToDel);
        if (delSuccess)
            Console.WriteLine($"Slettet Animal med Id: {entryToDel}");
        else
            Console.WriteLine($"Animal med Id: {entryToDel}, kunne ikke findes");
    }

    public void ReadOverloadFirstAndLastName(Database database)
    {
        string firstname = "Sir";
        string lastname = "Pawsalot";

        Animal animal = database.Read(firstname, lastname);
        if (animal != null)
            Console.WriteLine(animal);
        else
            Console.WriteLine($"Kunne ikke finde animal med navn: {firstname} {lastname}...");
    }

    public void ReadOverloadAge(Database database)
    {
        int age = 55;

        Animal animal = database.Read(age);
        if (animal != null)
            Console.WriteLine(animal);
        else
            Console.WriteLine($"Kunne ikke finde animal med alder: {age}...");
    }

    /// <summary>
    /// Combines first and lastnames, by splitting each name into 2 halves
    /// and mixing them together into 1 string
    /// </summary>
    /// <param name="firstname">The inputToBeReversed</param>
    /// <param name="lastname">The lastname</param>
    /// <returns>A combined name, by mixing half a inputToBeReversed with half a lastname</returns>
    /// <remarks>First version, that goes into more detail what is happening, 
    /// I've made a 2nd version, which barely contains any code compared to this: 
    /// <see cref="MixedNamesVersion2"/></remarks>
    public string MixedNamesVersion1(string firstname, string lastname)
    {
        // Finds the midwaypoint of the names by dividing by 2
        int firstnameMidIndex = firstname.Length / 2;
        int lastnameMidIndex = lastname.Length / 2;

        // Uses substring and sets the startindex to 0
        // and its length to the midwaypoint of the names
        string firstnameFirstHalf = firstname.Substring(0, firstnameMidIndex);
        string firstnameSecondHalf = firstname.Substring(firstnameMidIndex);

        string lastnameFirstHalf = lastname.Substring(0, lastnameMidIndex);
        string lastnameSecondHalf = lastname.Substring(lastnameMidIndex);

        // Use stringbuilder to append the parts of the names to a string.
        // Using stringbuilder doesnt create a new string for each time we append
        // as it is mutable aka can be changed after being instantiated
        StringBuilder mixedName = new();

        mixedName.Append(firstnameFirstHalf);
        mixedName.Append(lastnameFirstHalf);
        mixedName.Append(firstnameSecondHalf);
        mixedName.Append(lastnameSecondHalf);

        // Gotta tostring as we're returning a string (public string ...)
        // and not the stringbuilder
        return mixedName.ToString();
    }

    /// <summary>
    /// Combines first and lastnames, by splitting each name into 2 halves
    /// and mixing them together into 1 string
    /// </summary>
    /// <param name="firstname">The inputToBeReversed</param>
    /// <param name="lastname">The lastname</param>
    /// <returns>A combined name, by mixing half a inputToBeReversed with half a lastname</returns>
    /// <remarks>While this doesnt use stringbuilder and substring, it ends up doing the same</remarks>
    public string MixedNamesVersion2(string firstname, string lastname)
    {
        // Finds the midwaypoint of the names by dividing by 2
        int firstnameMidIndex = firstname.Length / 2;
        int lastnameMidIndex = lastname.Length / 2;

        // Uses range instead of substring. 
        // VS suggested this, so we learned something new today \o/
        return firstname[..firstnameMidIndex] +
               lastname[..lastnameMidIndex] +
               firstname[firstnameMidIndex..] +
               lastname[lastnameMidIndex..];
    }

    /// <summary>
    /// Separates characters from a string, based on a specified starting position
    /// and amount of characters that needs to be returned
    /// </summary>
    /// <param name="input">Input string which characters need to be separated</param>
    /// <param name="startPosition">Starting position of the input string</param>
    /// <param name="numCharReturnedAfterStartPos">Number of characters to be returned after the start position</param>
    /// <returns>A string of separated characters</returns>
    public string SeparateString(string input, int startPosition, int numCharReturnedAfterStartPos)
    {
        string output = "";
        // i is set to where in the string we start
        // and continue as long as the condition, i is less than startPos + numChar
        // i++ increment i by 1 for each loop
        for (int i = startPosition; i < startPosition + numCharReturnedAfterStartPos; i++)
        {
            // Stops the loop if we reach the end of string input
            if (i >= input.Length)
                break;

            // for each loop, 1 character is added to the string output
            output += input[i];
        }
        return output;
    }

    /// <summary>
    /// Takes a string text and reverses it
    /// </summary>
    /// <param name="inputToBeReversed">The text to be reversed</param>
    /// <returns>A reversed text</returns>
    public string ReversedText(string inputToBeReversed)
    {
        string text = "";
        // Sets i to length -1, this is because index starts on 0
        // The condition is set to end when i reaches 0
        // Instead of i++, we count down with i--
        for (int i = inputToBeReversed.Length -1; i >= 0; i--)
        {
            text += inputToBeReversed[i];
        }
        return text;
    }
}

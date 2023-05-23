using Torsdag;
using Torsdag.Interfaces;

namespace Week1Torsdag;
public class Program
{
    public static void Main(string[] args)
    {
        //person = new Animal(); // Overskriver person med Animal
        IPerson person = new Person();
        IPerson animal = new Animal();

        person.Name = "John";
        animal.Name = "Fnullergøj";

        List<IPerson> list = new List<IPerson>
        {
            person,
            animal
        };


        foreach (IPerson item in list) // IPerson definere typen list
        {
            item.Create();
            DisplayName(item);
            DisplaySeparator();
        }

        DisplayNameWithToStringOverload();
        DisplaySeparator();


        SetAndDisplayPerson();

        #region Various display methods
        void DisplayName(IPerson name)
        {
            Console.WriteLine($"And my name is {name.Name}.");
        }

        void DisplayNameWithToStringOverload() // Overload fidnes kun i Person.cs
        {
            Console.WriteLine(person);
            Console.WriteLine(animal);
        }

        void DisplaySeparator()
        {
            Console.WriteLine(new string('=', 40));
        }

        void SetAndDisplayPerson()
        {
            // Sets Person Name to "John Doe" and changes the default Age from 50 to 25.
            Person person = new Person();
            person.Name = "John Doe";
            person.Age = 25;
            Console.WriteLine(person);
        }
        #endregion


        DisplaySeparator();

        string[] people = { "John Doe", "Jane Doe", "Frank Smith" };
        Console.WriteLine(people[1]);

        foreach (var item1 in people)
        {
            Console.Write($"{item1} ");
        }
        Console.WriteLine();

        DisplaySeparator();

        people = new string[] { "Green", "Yellow", "Red" };
        Console.WriteLine(people[1]);

        foreach (var item2 in people)
        {
            Console.WriteLine(string.Join(", ", item2));
        }
    }
}



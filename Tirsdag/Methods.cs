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
}

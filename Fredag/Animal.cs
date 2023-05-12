namespace Fredag;

internal class Animal : IPerson
{
    public int Id { get; set; }
    public string Color { get; set; }
    public int Age { get; set; }
    public string Name { get; set; }

    public void Create()
    {
        Console.WriteLine("This is an Animal");
    }

    public List<Animal> AnimalListMethod()
    {
        List<Animal> animalList = new List<Animal>()
        {
            new Animal { Id = 1, Age = 5, Color = "red", Name = "Hansi" },
            new Animal { Id = 2, Age = 15, Color = "blue", Name = "Bo" },
            new Animal { Id = 3, Age = 25, Color = "yellow", Name = "Søren" },
            new Animal { Id = 4, Age = 95, Color = "red", Name = "Søren" },
        };
        return animalList;
    }

    public void FindAnimalBlueColor(List<Animal> animals)
    {
        foreach (var item in animals)
        {
            if (item.Color == "blue")
            {
                Console.WriteLine($"{item}");
            }
        }
    }

    public List<Animal> FindNameAndAddToList(List<Animal> listoOfAnimals)
    {
        List<Animal> animalsNewList = new List<Animal>();
        foreach (var animal in listoOfAnimals)
        {
            if (animal.Name == "Søren")
            {
                animalsNewList.Add(animal);
            }
        }
        return animalsNewList;
    }

    public List<Animal> FindNameAndAddToListLINQ(List<Animal> listoOfAnimals)
    {
        return listoOfAnimals.Where(animal => animal.Name == "Søren").ToList();
    }


    public override string ToString()
    {
        //return string.Join(", ", Id, Name, Age, Color);
        return string.Join("\n", $"Id: {Id}\n- Name: {Name} \n- Age: {Age} \n- Color: {Color}");
    }
}

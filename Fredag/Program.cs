using Fredag;
using Fredag.Count;
using Fredag.FirstOrDefault;
using Fredag.MinMax;
using Fredag.Select;

void DisplaySeparator()
{
    Console.WriteLine(new string('-', 40));
}

void DisplayTextWithColor(string text)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(text);
    Console.ResetColor();
}

void DisplayAnimalsUsingIEnumAnimal(IEnumerable<Animal> animals, string text)
{
    DisplayTextWithColor(text);
    foreach (Animal animal in animals)
    {
        Console.WriteLine($"  {animal}");
    }
}

void DisplayAnimalsUsingIEnumString(IEnumerable<string> animals, string text)
{
    DisplayTextWithColor(text);
    foreach (string animal in animals)
    {
        Console.WriteLine($"  {animal}");
    }
}


void DisplaySingleAnimal(Animal animal, string text)
{
    DisplayTextWithColor(text);
    Console.WriteLine($"  {animal}");
}

void DisplayInt(int animal, string text)
{
    DisplayTextWithColor(text);
    Console.WriteLine($"  {animal}");
}


Animal animal = new Animal();
List<Animal> animalList = animal.AnimalListMethod();

// Find Animal color
DisplayTextWithColor("Find animal whose color is blue. Not using returns.");
animal.FindAnimalBlueColor(animalList);

DisplaySeparator();

// Find Animal named Søren
void DisplayFindAnimalNamedSoren()
{
    DisplayTextWithColor("Find animals named Søren using if's");
    List<Animal> animalsNamedSoren = animal.FindNameAndAddToList(animalList);
    foreach (Animal animal in animalsNamedSoren)
    {
        Console.WriteLine($"  {animal}");
    }
}

DisplayFindAnimalNamedSoren();

DisplaySeparator();

// Find Animal named Søren, hardcoded
void DisplayFindAnimalsNamedSorenLINQ()
{
    DisplayTextWithColor("Find animals named Søren using LINQ");
    foreach (Animal animal in animal.FindNameAndAddToListLINQ(animalList))
    {
        Console.WriteLine($"  {animal}");
    }
}
DisplayFindAnimalsNamedSorenLINQ();

DisplaySeparator();

// Find animals above 50, hardcoded
void DisplayFindAnimalsAboveage50LINQ()
{
    DisplayTextWithColor("Find animals above age 50");
    foreach (Animal animal in animal.FindAnimalsAboveAge50LINQ(animalList))
    {
        Console.WriteLine($"  {animal}");
    }
}
DisplayFindAnimalsAboveage50LINQ();

DisplaySeparator();


MinLINQ minLINQ = new MinLINQ();
// Find minimum age from the list of animals
void DisplayFindMinAnimalAge()
{
    DisplayTextWithColor("Find Minimum age from a list of animals");
    foreach (Animal animal in minLINQ.FindMinAnimalAge(animalList))
    {
        Console.WriteLine($"  {animal}");
    }
}

DisplayFindMinAnimalAge();
DisplaySeparator();



// Find max age from the list of animals
MaxLINQ maxLINQ = new MaxLINQ();
DisplayAnimalsUsingIEnumAnimal(maxLINQ.FindOldestAnimalFromList(animalList), "Find Maximum age from a list of animals");
DisplaySeparator();

// Finds and returns the first animal, passed into the parameter
FirstOrDefaultLINQ firstOrDefaultLINQ = new FirstOrDefaultLINQ();
string searchedName = "Gert";
DisplaySingleAnimal(firstOrDefaultLINQ.FindFirstAnimalNamed(animalList, searchedName), $"Finds the first animal named {searchedName}");
searchedName = "Søren";
DisplaySingleAnimal(firstOrDefaultLINQ.FindFirstAnimalNamed(animalList, searchedName), $"Finds the first animal named {searchedName}");
DisplaySeparator();

// Counts the amount of animals in a list
CountLINQ countLINQ = new CountLINQ();
DisplayInt(countLINQ.CountAnimalsInList(animalList), "Counts the number of animals in the list: animalList");
DisplayInt(countLINQ.CountAnimalsInList(animal.FindAnimalsAboveAge50LINQ(animalList)), "Counts the number of animals in the list: FindAnimalsAboveAge50LINQ");
DisplaySeparator();

// Only Selects all colors and displays them
SelectLINQ selectLINQ = new();
DisplayAnimalsUsingIEnumString(selectLINQ.SelectAnimalColors(animalList), "Selects all colors from the list");
DisplaySeparator();


// Lærer shenanigans
// LINQ (Language INtergrated Query) - SQL
// FirstOrDefault()
// Where()
// Max()
// Count()
// if you have to much time... Select(new //anonymous), Include()

// Collection.LINQ_Method(() => if sætning)

//var temp = animalList.FirstOrDefault<Animal>((kaffe) => kaffe.Id == 1);

//var temp = animalList.
//FirstOrDefault<Animal>(
//(kaffe) =>
//(kaffe.Id == 1) || (kaffe.Name == "Bo"));

// var temp = animalList.Where(
// (katte)=>
// (katte.Id == 3 || katte.Name == "Hansi")
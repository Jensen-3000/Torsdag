namespace Fredag.MinMax;

internal class MinLINQ
{

    public List<Animal> FindMinAnimalAge(List<Animal> animals)
    {
        var minAge = animals.Min<Animal>(animal => animal.Age);
        return animals.Where<Animal>(animal => animal.Age == minAge).ToList();
    }

}

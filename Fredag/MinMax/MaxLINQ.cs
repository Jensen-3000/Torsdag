namespace Fredag.MinMax;

internal class MaxLINQ
{
    public List<Animal> FindOldestAnimalFromList(List<Animal> animals)
    {
        int maxAge = animals.Max<Animal>(animal => animal.Age);
        return animals.Where<Animal>(animal => animal.Age == maxAge).ToList();
    }
}

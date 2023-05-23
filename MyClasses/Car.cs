namespace MyClasses;

public class Car
{
    public int Id { get; set; }
    public string Model { get; set; } // Ionic5
    public string Make { get; set; } // Nissan

    // Empty constructor
    public Car()
    {
        
    }

    // Overload, 2 params
    public Car(string make, string model)
    {
        Make = make;
        Model = model;
    }
}

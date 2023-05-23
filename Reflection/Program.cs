using MyClasses;
using System.Reflection;

namespace Week3Reflection;
public class Program
{
    public static void Main(string[] args)
    {
        #region Flemming lecture

        Car car = new()
        {
            Id = 1,
            Make = "Fiat",
            Model = "127"
            // Reflection
            // Definitions and metadata in mediate code
        };
        var carType = car.GetType();
        Console.WriteLine(carType);
        Console.WriteLine($"This is my class {carType.Name}");

        // insert skal kunne variere!!
        string s = "insert into car values('127', 'Fiat')"; // This is bad!!
                                                            // 1) Sql Injections
                                                            // 2) Errors because of inconsistants in db
                                                            // 3) Not future proof
        string sql = $"insert into {carType.Name} values ('127', 'Fiat')";
        Console.WriteLine($"Here is our query: {sql}");


        // Why no ()
        Bike bike = new Bike { Name = "Something", Id = 1, Description = "Mega sej" }; // Whats the difference from other instances

        var bikeType = bike.GetType();

        sql = $"insert into {bikeType.Name} values ('whatever')";
        Console.WriteLine($"Here is our query: {sql}");
        #endregion


        #region Reflection Bike method #Flemming Shenanigans
        void ReflectionBike()
        {
            // Reflection Properties
            PropertyInfo[] properties = bikeType.GetProperties();

            Console.WriteLine($"This is my property: {properties[0].Name}");

            // Version 1
            //foreach (PropertyInfo property in properties)
            //{
            //    Console.WriteLine(property.Name);
            //}

            Console.WriteLine();

            //sql = $"insert into {tt.Name} (Name) values ('data')";
            sql = $"insert into {bikeType.Name} (";
            foreach (PropertyInfo property in properties)
            {
                if (property.Name != "Id")
                {
                    sql += property.Name;
                }
                Console.WriteLine($"Test: {property.Name}");
            }

            sql += ") values (";

            foreach (PropertyInfo property in properties)
            {
                if (property.Name != "Id")
                {
                    // 'data'
                    sql += $"'{property.GetValue(bike)}',";
                }

            }
            // values ('something', 'something more',) -- trim my string..
            sql = sql.TrimEnd(',') + ")";


            Console.WriteLine(sql);
        }
        #endregion

        #region Freestyle 
        Console.WriteLine(new string('-', 40));

        // My own take on this
        // Method is separated into MyClasses, class library
        Methods methods = new Methods();

        List<Car> cars = new List<Car>
{
    // Uses empty ctor
    new Car { Make = "Toyota", Model = "Corolla" },
    new Car { Make = "Ford", Model = "Mustang" },
    // Uses ctor with make, model param
    new Car ( "Honda", "Civic" )
};

        Car car1 = new Car("Toyota", "Corolla");
        Type car1Type = car1.GetType();
        Bike bike1 = new Bike();
        bike1.Name = "NiceRide";
        bike1.Description = "Fast";


        // Takes 2 parameters, Type and obj
        Console.WriteLine(methods.ReflectionInsertInto(car1Type, car1));

        Console.WriteLine(new string('-', 40));

        // Takes 1 param, obj only
        // GetType() is run on the obj from inside the method
        Console.WriteLine(methods.ReflectionInsertInto(bike1));

        Console.WriteLine(new string('-', 40));

        foreach (var item in cars)
        {
            Console.WriteLine(methods.ReflectionInsertInto(item));
        }
        #endregion
    }
}

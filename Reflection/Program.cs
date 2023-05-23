using MyClasses;
using System.Reflection;

Car car = new()
{
    Id = 1,
    Make = "Fiat",
    Model = "127"
    // Reflection
    // Definitions and metadata in mediate code
};
var tt = car.GetType();
Console.WriteLine(tt);
Console.WriteLine($"This is my class {tt.Name}");

// insert skal kunne variere!!
string s = "insert into car values('127', 'Fiat')"; // This is bad!!
                                                    // 1) Sql Injections
                                                    // 2) Errors because of inconsistants in db
                                                    // 3) Not future proof
string sql = $"insert into {tt.Name} values ('127', 'Fiat')";
Console.WriteLine($"Here is our query: {sql}");


// Why no ()
Bike bike = new Bike { Name = "Something", Id = 1, Description = "Mega sej" }; // Whats the difference from other instances

tt = bike.GetType();

sql = $"insert into {tt.Name} values ('whatever')";
Console.WriteLine($"Here is our query: {sql}");



// Reflection Properties
PropertyInfo[] properties = tt.GetProperties();

Console.WriteLine($"This is my property: {properties[0].Name}");

// Version 1
//foreach (PropertyInfo property in properties)
//{
//    Console.WriteLine(property.Name);
//}

Console.WriteLine();

//sql = $"insert into {tt.Name} (Name) values ('data')";
sql = $"insert into {tt.Name} (";

foreach (PropertyInfo property in properties)
{
    // sql = sql + property.Name;
    if (property.Name != "Id")
    {
        sql += property.Name;
    }
    Console.WriteLine($"Test: {property.Name}");
}

sql += ") values (";

foreach (PropertyInfo property in properties)
{
    // sql = sql + property.Name;
    if (property.Name != "Id")
    {
        // 'data'
        sql += $"'{property.GetValue(bike)}',";
    }

}
sql = sql.TrimEnd(',');
// values ('something', 'something more',) -- trim my string..
sql += ")";


Console.WriteLine(sql);
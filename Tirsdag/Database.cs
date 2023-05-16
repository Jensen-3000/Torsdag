using Microsoft.Data.SqlClient;

namespace Tirsdag;

internal class Database
{
    // public string ConnectionString { get; set; } = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = TEC; Integrated Security = True; Connect Timeout = 30; Encrypt=False;Trust Server Certificate=False;Application Intent = ReadWrite; Multi Subnet Failover=False";
    // public string ConnectionString { get; set; } = @"Server=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

    public string ConnectionString { get; set; } = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=H1Db;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

    public void Create(Animal animal)
    {
        string query = "INSERT INTO animal (color, firstname, lastname, age) values(@color, @firstname, @lastname, @age)";
        using SqlConnection con = new(ConnectionString);
        using SqlCommand cmd = new(query, con);

        cmd.Parameters.AddWithValue("@color", animal.Color);
        cmd.Parameters.AddWithValue("@firstname", animal.Firstname);
        cmd.Parameters.AddWithValue("@lastname", animal.Lastname);
        cmd.Parameters.AddWithValue("@age", animal.Age);

        con.Open();
        cmd.ExecuteNonQuery();
    }

    public bool Delete(int id)
    {
        string query = "DELETE FROM animal WHERE id = @id";
        using SqlConnection con = new(ConnectionString);
        using SqlCommand cmd = new(query, con);

        cmd.Parameters.AddWithValue("@id", id);

        con.Open();
        int numberOfRowsAffected = cmd.ExecuteNonQuery();
        
        return numberOfRowsAffected > 0;
    }

    public Animal Read(Animal animal)
    {
        string query = "SELECT * FROM animal WHERE id = @id";
        using SqlConnection con = new(ConnectionString);
        using SqlCommand cmd = new(query, con);

        cmd.Parameters.AddWithValue("@id", animal.Id);

        con.Open();

        using SqlDataReader reader = cmd.ExecuteReader();

        if (reader.HasRows)
        {
            while (reader.Read())
            {
                animal.Color = reader.GetString(reader.GetOrdinal("color"));
                animal.Firstname = reader.GetString(reader.GetOrdinal("firstname"));
                animal.Lastname = reader.GetString(reader.GetOrdinal("lastname"));
                animal.Age = reader.GetInt32(reader.GetOrdinal("age"));
            };
            return animal;
        }
        return null;
    }

    public Animal Read(string firstname, string lastname)
    {
        string query = "SELECT * FROM animal WHERE firstname = @firstname AND lastname = @lastname";
        using SqlConnection con = new(ConnectionString);
        using SqlCommand cmd = new(query, con);

        cmd.Parameters.AddWithValue("@firstname", firstname);
        cmd.Parameters.AddWithValue("@lastname", lastname);

        con.Open();

        using SqlDataReader reader = cmd.ExecuteReader();

        if (reader.HasRows)
        {
            while (reader.Read())
            {
                Animal animal = new()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("id")),
                    Color = reader.GetString(reader.GetOrdinal("color")),
                    Firstname = reader.GetString(reader.GetOrdinal("firstname")),
                    Lastname = reader.GetString(reader.GetOrdinal("lastname")),
                    Age = reader.GetInt32(reader.GetOrdinal("age"))
                };
                return animal;
            }
        }
        return null;
    }

    public Animal Read(int age)
    {
        string query = "SELECT * FROM animal WHERE age = @age";
        using SqlConnection con = new(ConnectionString);
        using SqlCommand cmd = new(query, con);

        cmd.Parameters.AddWithValue("@age", age);

        con.Open();

        using SqlDataReader reader = cmd.ExecuteReader();

        if (reader.HasRows)
        {
            while (reader.Read())
            {
                Animal animal = new()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("id")),
                    Color = reader.GetString(reader.GetOrdinal("color")),
                    Firstname = reader.GetString(reader.GetOrdinal("firstname")),
                    Lastname = reader.GetString(reader.GetOrdinal("lastname")),
                    Age = reader.GetInt32(reader.GetOrdinal("age"))
                };
                return animal;
            }
        }
        return null;
    }

    public List<Animal> ReadAll()
    {
        string query = "SELECT * FROM animal";
        using SqlConnection con = new(ConnectionString);
        using SqlCommand cmd = new(query, con);

        List<Animal> animals = new();

        con.Open();
        using SqlDataReader reader = cmd.ExecuteReader();

        if (reader.HasRows)
        {
            while (reader.Read())
            {
                Animal animal = new()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("id")),
                    Color = reader.GetString(reader.GetOrdinal("color")),
                    Firstname = reader.GetString(reader.GetOrdinal("firstname")),
                    Lastname = reader.GetString(reader.GetOrdinal("lastname")),
                    Age = reader.GetInt32(reader.GetOrdinal("age"))
                };
                animals.Add(animal);
            }
        }
        return animals;
    }
}

using System.Reflection;

namespace MyClasses;

public class Methods
{
    public string ReflectionInsertInto(Type type, object obj)
    {
        PropertyInfo[] properties = type.GetProperties();

        string table = type.Name;
        string columns = "";
        string values = "";

        foreach (var property in properties)
        {
            if (property.Name != "Id")
            {
                columns += $"{property.Name}, ";
                values += $"'{property.GetValue(obj)}', ";
            }
        }
        columns = columns.TrimEnd(',', ' ');
        values = values.TrimEnd(',', ' ');

        string sql = $"INSERT INTO {table} ({columns}) VALUES ({values})";
        // Maybe use ToLower() as the table names could be a different case, compared to the Db
        return sql;
    }

    public string ReflectionInsertInto(object obj)
    {
        var type = obj.GetType();
        PropertyInfo[] properties = type.GetProperties();

        string table = type.Name;
        string columns = "";
        string values = "";

        foreach (var property in properties)
        {
            if (property.Name != "Id")
            {
                columns += $"{property.Name}, ";
                values += $"'{property.GetValue(obj)}', ";
            }
        }
        columns = columns.TrimEnd(',', ' ');
        values = values.TrimEnd(',', ' ');

        string sql = $"INSERT INTO {table} ({columns}) VALUES ({values})";
        // Maybe use ToLower() as the table names could be a different case, compared to the Db
        return sql;
    }
}

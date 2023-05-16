﻿using Tirsdag;

Database database = new Database();
Methods methods = new Methods();
UtilHelper helper = new UtilHelper();

#region Flemming Shenanigans
//database.Create();

//string query = "insert into animal values('orange', '', 'Gert', 'Johnson', 24)";
//database.Create(query);


//Animal animal001 = new Animal();
//animal001.Age = 33;

//Animal animal002 = new Animal()
//{
//    Age = 33,
//    Name = "",
//    Color = "Black",
//    Firstname = "White Lady",
//    Lastname = "Baroness"
//};

//query = $"insert into animal values('{animal002.Color}', '', '{animal002.Firstname}', '{animal002.Lastname}',{animal002.Age})";
//database.Create(query);

//Animal animal003 = new Animal()
//{
//    Age = 99,
//    Color = "",
//    Firstname = "White Lady",
//    Lastname = "Baroness"
//};

//database.Create(animal002);
#endregion


// methods.CreateManyAnimals(database);
helper.DisplaySeparator("ReadAll");
methods.ReadAllCRUD(database);

helper.DisplaySeparator("Delete");
methods.DeleteCRUD(database);

helper.DisplaySeparator("Read overload med animal obj");
methods.ReadAnimalObj(database);

helper.DisplaySeparator("Read overload med first og lastname");
methods.ReadOverloadFirstAndLastName(database);

helper.DisplaySeparator("Read overload med age");
methods.ReadOverloadAge(database);

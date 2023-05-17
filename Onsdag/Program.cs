// Onsdags sjov med Jan's tal systemer

using Onsdag;

char ch = '0';

int chTal = (int)ch;
// int strTal = (int)"7"

double talD = 123.56;
// Programmøren tager ansvaret fra compileren, ved cast
// Mister nøjagtighed, mister decimaldel
int talI = (int)talD;



//Console.WriteLine($"Karakteren {ch} har værdien {(int)ch}");

// Ascii tree
//for (int i = 0; i < 256; i++)
//{

//    // Console.Write($"{(char)i} : {i}");
//    Console.Write($"{i} : {(char)i} ");
//    if (i % 16 == 0)
//    {
//        Console.WriteLine();
//    }
//}


//int tal1 = 7230;
//int tal2 = tal1 % 10;
//int tal3 = tal2+0x30;


//Console.WriteLine(tal3);


TalConverter converter = new TalConverter();

converter.SetInt(7913);

Console.WriteLine(converter.GetInt());

string decimalString = converter.GetDecimalString();

Console.WriteLine(decimalString);

using Mandag;

UtilHelper utilHelper = new UtilHelper();

// Box 1 bruger tom Constructor
Box box1 = new Box();
box1.Højde = 1;
box1.Længde = 2;
box1.Bredde = 3;
box1.BoxType = BoxType.MellemBox;

// Box 2 bruger Constructor med params
Box box2 = new Box(4, 5, 6, BoxType.LilleBox);

// Boxe ligges sammen via overload af + (Kan ses ved at holde musen over + tegnet)
Box box3 = box1 + box2;


// Box 1
// Override af ToString som udskrive Højde, Bredde, Længde og BoxType
Console.WriteLine(box1.ToString());

// Udskriver Volumen/Rumfang af boxene via GetVolume metoden
Console.WriteLine($"Volume er: {box1.GetVolume()}");
utilHelper.DisplaySeparator();


// Box 2
Console.WriteLine(box2.ToString());
Console.WriteLine($"Volume er: {box2.GetVolume()}");
utilHelper.DisplaySeparator();


// Box 3 = Box 1 + Box 2
Console.WriteLine(box3.ToString());
Console.WriteLine($"Volume er: {box3.GetVolume():N2}"); // N2 laver kun 2 decimaler
utilHelper.DisplaySeparator();


#region Random Number gen og metoder
// Random number gen
Random random = new Random();
// Laver en random box med random tal og random boxtype
// Laver pt. kun hele tal
Box CreateRandomBox(Random random)
{
    Box randomBox = new Box();
    randomBox.Længde = random.Next(1, 10);
    randomBox.Højde = random.Next(1, 10);
    randomBox.Bredde = random.Next(1, 10);
    randomBox.BoxType = BoxType.LilleBox;
    randomBox.BoxType = (BoxType)random.Next(0, 2);
    return randomBox;
}

// Udskriver box i string og volume
void DisplayBox(Box box, int i)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Random Box: #{i}");
    Console.ResetColor();
    Console.WriteLine($"{box}");
    Console.WriteLine($"Volume er: {box.GetVolume():N2}");
}

//Box box10 = CreateRandomBox(random);
//Box box11 = CreateRandomBox(random);
//Box box12 = box10 + box11;

//DisplayBox(box10);
//DisplayBox(box11);
//DisplayBox(box12);

//utilHelper.DisplaySeparator();

while (true)
{
    utilHelper.DisplaySeparator();
    Console.WriteLine("Tryk på tilfælding tast for en Random Box \nTryk 0 for at afslutte.");
    // Alt andet end 0, giver en ny random box
    ConsoleKeyInfo keyInfo = Console.ReadKey();
    if (keyInfo.Key == ConsoleKey.D0)
    {
        return;
    }

    Console.Clear();
    // Skal være 2
    int boxesToGenerate = 2;    
    int count = 0;
    List<Box> boxesList = new List<Box>();

    // Looper 2 gange og laver 2 random boxes
    for (int i = 0; i < boxesToGenerate; i++)
    {
        count = i + 1;
        Box newBox = CreateRandomBox(random);
        boxesList.Add(newBox);
        DisplayBox(newBox, count);
    }

    // Combiner 2 boxe
    Box comboBox = boxesList[0] + boxesList[1];
    // count er hardcoded, da den looper og kun displayer 3 max.
    DisplayBox(comboBox, 3);
}
#endregion
namespace Mandag;

internal class Box
{
    // Properties
    public double Højde { get; set; }
    public double Bredde { get; set; }
    public double Længde { get; set; }
    public BoxType BoxType { get; set; }

    // Constructor uden params
    public Box()
    {

    }

    // Constructor med params
    public Box(double højde, double bredde, double længde, BoxType boxtype)
    {
        Højde = højde;
        Bredde = bredde;
        Længde = længde;
        BoxType = boxtype;
    }

    // Override af ToString
    // N2 laver max 2 decimaler
    public override string ToString()
    {
        return $"Box: Højde = {Højde:N2}, Bredde = {Bredde:N2}, Længde = {Længde:N2}, Type = {BoxType}";
    }

    // Retunere volume/rumfang af en Box 
    public double GetVolume()
    {
        return Højde * Bredde * Længde;
    }

    // Overload af + tegnet, hvor der ligges to Box Objecter sammen
    // og retunere 1 ny Box
    // Bruger if/else, 2 lillebox = mellembox, ellers stor box
    public static Box operator +(Box box1, Box box2)
    {
        BoxType newBox;

        if (box1.BoxType == BoxType.LilleBox && box2.BoxType == BoxType.LilleBox)
        {
            newBox = BoxType.MellemBox;
        }
        else
        {
            newBox = BoxType.StorBox;
        }

        return new Box(
            (box1.Højde + box2.Højde) * 0.95,
            (box1.Bredde + box2.Bredde) * 0.95,
            (box1.Længde + box2.Længde) * 0.95,
            newBox
            );
    }
}

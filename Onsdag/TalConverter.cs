namespace Onsdag;

internal class TalConverter
{
    int Number;

    public void SetInt(int number)
    {
        Number = number;
    }

    public int GetInt()
    {
        return Number;
    }

    //int tal1 = 7230;
    //int tal2 = tal1 % 10;
    //int tal3 = tal2+0x30;

    public string GetDecimalString()
    {
        int temp = Number;
        string decimalStr = "";

        while (temp > 0) // Kører indtil tallet bliver divideret/er nul
        {
            int rest = temp % 10; // Finder rest ved hjælp af modulus / Mindst betydne ciffer
            char ch = (char)(rest + 0x30); // Rest laves om til char, ved hjælp af hex/ascii table
            decimalStr = ch + decimalStr; // char bliver tilføjet til en string
            temp /= 10; // nummeret bliver divideret med 10
        }
        return decimalStr;
    }

    public string GetBinaryString()
    {
        int temp = Number;
        string binaryStr = "";

        while (temp > 0)
        {
            int rest = temp % 2;
            char ch = (char)(rest + 0x30);
            binaryStr = ch + binaryStr;
            temp /= 2;
        }
        return binaryStr;
    }
}

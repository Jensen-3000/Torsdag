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

    public string GetHexString()
    {
        int temp = Number;
        string hexStr = "";

        while (temp > 0)
        {
            int rest = temp % 16;
            char ch;
            if (rest < 10)
            {
                ch = (char)(rest + 0x30); // Hex 0x30 = 48 
            }
            else
            {
                ch = (char)(rest + 0x37); // 0x37 = 55
            }

            hexStr = ch + hexStr;
            temp /= 16;
        }
        return hexStr;
    }


    public void SetDecimalString(string str)
    {
        int temp = 0;

        foreach (char ch in str)
        {
            int intchar = ch - 0x30;
            temp = temp * 10 + intchar;
        }

        Number = temp;
    }

    public void SetBinaryString(string str)
    {
        int temp = 0;

        foreach (char ch in str)
        {
            int intchar = ch - 0x30;
            temp = temp * 2 + intchar;
        }

        Number = temp;
    }

    public void SetHexString(string str)
    {
        int temp = 0;
        int intchar = 0;
        foreach (char ch in str)
        {
            if (ch >= '0' || ch <= '9')
            {
                intchar = ch - 0x30;
            }
            if (ch >= 'A' || ch <= 'F')
            {
                intchar = ch - 0x37;
            }
            temp = temp * 16 + intchar;
        }

        Number = temp;
    }
}

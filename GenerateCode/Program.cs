using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int numberOfCode = 1000;
        int codeLength = 8;

        List<string> generatedCodes = GenerateUniqueCodes(numberOfCode, codeLength);

        foreach (var code in generatedCodes)
        {
            Console.WriteLine("Kampanya Kodu: " + code);
        }

        string userInput = Console.ReadLine();

        bool isValid = CheckCode(userInput, generatedCodes);

        if (isValid)
        {
            Console.WriteLine("Kod geçerli.");
        }
        else
        {
            Console.WriteLine("Kod geçerli değil.");
        }

        Console.ReadKey();  
    }

    static List<string> GenerateUniqueCodes(int numberOfCodes, int codeLength)
    {
        string characters = "ACDEFGHKLMNPRTXYZ234579";
        List<string> codes = new List<string>();

        Random random = new Random();

        while (codes.Count < numberOfCodes)
        {
            char[] codeArray = new char[codeLength];
            for (int i = 0; i < codeLength; i++)
            {
                codeArray[i] = characters[random.Next(characters.Length)];
            }

            string code = new string(codeArray);

            if (!codes.Contains(code))
            {
                codes.Add(code);
            }
        }

        return codes;
    }

    static bool CheckCode(string userInput, List<string> generatedCode)
    {
        if (generatedCode.Contains(userInput))
            return true;
        else
            return false;
    }
}

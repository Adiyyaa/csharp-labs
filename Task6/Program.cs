
using System;
using System.Text;

class Program
{
    static string ReplaceMultipleSpaces(string text)
    {
        StringBuilder result = new StringBuilder();
        bool previousWasSpace = false;

        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];

            if (ch == ' ')
            {
                if (!previousWasSpace)
                {
                    result.Append(ch);
                }

                previousWasSpace = true;
            }
            else
            {
                result.Append(ch);
                previousWasSpace = false;
            }
        }

        return result.ToString();
    }

    static void Main()
    {
        string text;

        do
        {
            Console.Write("Жолды енгізіңіз: ");
            text = Console.ReadLine() ?? "";
        }
        while (text.Length == 0);

        string result = ReplaceMultipleSpaces(text);

        Console.WriteLine("Бастапқы жол: [" + text + "]");
        Console.WriteLine("Нәтиже:        [" + result + "]");
    }
}

using System;
using System.Linq;
using System.Text;

class XORStringWithEncryptionKey
{
    static void Main()
    {
        string text = "Ever wonder about what he's doing.How it all turned to lies.Sometimes I think that it's better to never ask why";
        string key = "pink";

        Console.WriteLine(EncryptOrDecrypt(text, key));
    }

    private static string EncryptOrDecrypt(string text, string key)
    {
        var result = new StringBuilder();
        for (int i = 0; i < text.Length; i++)
        {
            char character = text[i];
            uint charCode = (uint)character;
            int keyPosition = i % key.Length; 
            char keyChar = key[keyPosition];
            uint keyCode = (uint)keyChar;

            // perform XOR on the two character codes
            uint combinedCode = charCode ^ keyCode;

            // cast back to a char
            char combinedChar = (char)combinedCode;

            // add to the result
            result.Append(combinedChar);
        }
        return result.ToString();
    }
}
    
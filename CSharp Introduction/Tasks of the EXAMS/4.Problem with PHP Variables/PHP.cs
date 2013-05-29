using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class PHP
{
    static void Main()
    {
        StringBuilder phpText = new StringBuilder();

        while (true)
        {
            string line = Console.ReadLine().Trim();
            phpText.AppendLine(line);
            if (line == "?>") break;
        }
        phpText.ToString();

        StringBuilder variableConteiner = new StringBuilder();
        List<string> variables = new List<string>();

        GetVariables(phpText, variableConteiner, variables);

        Console.WriteLine(variables.Count);
        variables.Sort(StringComparer.Ordinal);
       foreach (string variable in variables)
       {
                Console.WriteLine(variable);
       }
    }

    private static List<string> GetVariables(StringBuilder phpText, StringBuilder variableConteiner, List<string> variables)
    {
        bool multiLineComment = false;
        bool oneLineComment = false;
        bool isVariable = false;

        for (int i = 0; i < phpText.Length; i++)
        {
            char ch = phpText[i];
            if (ch == '$')
            {
                isVariable = true;
            }
            if ((ch == '/') && (phpText[i + 1] == '*'))
            {
                multiLineComment = true;
            }
            if (ch == '#')
            {
                oneLineComment = true;
            }
            if ((ch == '/')&&(phpText[i+1]=='/'))
            {
                oneLineComment = true;
            }
            if (isVariable)
            {
                if (IsCorrectName(ch))
                {
                    variableConteiner.Append(phpText[ch + 1]);
                }
                else
                {
                    string newVariable = variableConteiner.ToString();
                    if (newVariable.Length > 0 && !variables.Contains(newVariable))
                    {
                        variables.Add(newVariable);
                    }
                    isVariable = false;
                    continue;
                }
            }
            if (multiLineComment)
            {
                if ((ch == '*') && (ch == '/'))
                {
                    multiLineComment = false;
                    i++;
                }
                else
                {
                    continue;
                }
            }
            if (oneLineComment)
            {
                if ((ch == '/') && (ch == 'n'))
                {
                    oneLineComment = false;
                    i++;
                }
                else
                {
                    continue;
                }
            }
        }
        return variables;
    }

    private static bool IsCorrectName(char letter)
    {
        if (letter >= 'a' && letter <= 'z') return true;
        if (letter >= 'A' && letter <= 'Z') return true;
        if (letter >= '0' && letter <= '9') return true;
        if (letter == '_') return true;
        return false;
    }
}


using System;

class StringSort
{
    static void Main()
    {
        string[] array = { "abc", "a", "absd", "qwerty", "qw", "hava", "jhktfds", "jhr", "ek", "e" };

        Array.Sort(array, (a, b) => (a.Length).CompareTo(b.Length));

        foreach (string word in array)
        {
            Console.WriteLine("{0,6}",word);
        }
    }
}


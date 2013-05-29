using System;

class ASCII 
{
    static void Main()
    {
        string a = "\x004";
        string b = "\x209";
        string c = "\x234";
        string d = "\x135";
        
        Console.WriteLine((Object) a);
        Console.WriteLine((Object) b);
        Console.WriteLine((Object) c);
        Console.WriteLine((Object) d);
    }
}


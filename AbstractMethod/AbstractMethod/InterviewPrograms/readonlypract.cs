// C# program to illustrate
// how to create a readonly field
using System;

class GFG
{

    // readonly variables
    public readonly string str1;
    public readonly string str2;

    // Readonly variable
    // This variable is
    // initialized at declaration time
    public readonly string str3 = "gfg";
    public const string str4 = "constgfg4";
    public const string str5 = "constgfg5";
    
    // The values of the readonly
    // variables are assigned
    // Using constructor
    public GFG(string a, string b)
    {
        str1 = a;
        str2 = b;
        
        Console.WriteLine("Display value of string 1 {0}, "
                        + "and string 2 {1}", str1, str2);
    }
    public GFG(string a, string b,string c)
    {
        str1 = a;
        str2 = b;
        str3 = c;
        Console.WriteLine("Display value of string 1 {0}, "
                        + "and string 2 {1} and string 3 {2}", str1, str2, str3);
    }

    // Main method
   
}

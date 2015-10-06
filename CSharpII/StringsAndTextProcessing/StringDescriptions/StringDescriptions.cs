using System;
using System.Collections.Generic;



class StringDescriptions
{
    /*Describe the strings in C#. What is typical for the string data type?
    Describe the most important methods of the String class.*/

    
    static void Main()
    {
        // String description
        List<string> stringDefinitions = new List<string>()
            {
                "The string type represents a sequence of zero or more Unicode characters.\nstring is an alias for String in the .NET Framework.",
                "Although string is a reference type, the equality operators (== and !=) are\ndefined to compare the values of string objects, not references. This makes\ntesting for string equality more intuitive. The example bellow displays\n\"True\" and then \"False\" because the content of the strings are equivalent,\nbut a and b do not refer to the same string instance.", //example 1
                "The + operator concatenates strings:", //example 2
                "Strings are immutable--the contents of a string object cannot be changed after\nthe object is created, although the syntax makes it appear as if you can do this.\nFor example, when you write this code, the compiler actually creates a new string\nobject to hold the new sequence of characters, and that new object is assigned to b.\nThe string \"h\" is then eligible for garbage collection. ",//example 3
                "The [] operator can be used for readonly access to individual characters of a string:", //example 4
                "String literals are of type string and can be written in two forms, quoted and @-quoted.\nQuoted string literals are enclosed in double quotation marks (\"):",//example 5
                "String literals can contain any character literal. Escape sequences are included.\nThe following example uses escape sequence \\ for backslash, \\u0066 for the letter f,\nand\nfor newline.\nNOTE\nThe escape code \\udddd (where dddd is a four-digit number) represents the Unicode character U+dddd.\nEight-digit Unicode escape codes are also recognized:\\Udddddddd.",//example 6
                "Verbatim string literals start with @ and are also enclosed in double quotation marks.\nFor example:",
                "The advantage of verbatim strings is that escape sequences are not processed, which makes it easy to write, for example, a fully qualified file name:",
                "To include a double quotation mark in an @-quoted string, double it:",//example 7
                "Another use of the @ symbol is to use referenced (/reference) identifiers that are C# keywords.",
            };

        //Code examples
        List<string> codeExamples = new List<string>()
            {
                "No example",
                @"
        string a = ""hello"";
        string b = ""h"";
        // Append to contents of 'b'
        b += ""ello"";
        Console.WriteLine(a == b);
        Console.WriteLine((object)a == (object)b);",
                @"
        string a = ""good "" + ""morning"";",
                @"
        string b = ""h"";
        b += ""ello"";",
                @"
        string str = ""test"";
        char x = str[2];  // x = 's';",
                @"
        ""good morning""  // a string literal",
                @"
        string a = ""\\\u0066\n"";
        Console.WriteLine(a);",
                @"
        @""good morning""  // a string literal",
                @"
        @""c:\Docs\Source\a.txt""  // rather than ""c:\\Docs\\Source\\a.txt""",
                @"
        @""""""Ahoy!"""" cried the captain."" ",
                "No example"
            };

        int i = 0;
        while (i <= stringDefinitions.Count)
        {
            switch (i)
            {
                case 0:

                    PrintDescription();
                    Console.WriteLine(stringDefinitions[i]);
                    PrintCode();
                    Console.WriteLine(codeExamples[i]);
                    break;
                case 1:
                    PrintDescription();
                    Console.WriteLine(stringDefinitions[i]);
                    PrintCode();
                    Console.WriteLine(codeExamples[i]);
                    PrintExample();
                    TestingStringEquality();
                    ;
                    break;
                case 2:
                    PrintDescription();
                    Console.WriteLine(stringDefinitions[i]);
                    PrintCode();
                    Console.WriteLine(codeExamples[i]);
                    PrintExample();
                    ConatenateStrings();
                    ;
                    break;
                case 3:
                    PrintDescription();
                    Console.WriteLine(stringDefinitions[i]);
                    PrintCode();
                    Console.WriteLine(codeExamples[i]);
                    PrintExample();
                    ImmutableString();
                    ;
                    break;
                case 4:
                    PrintDescription();
                    Console.WriteLine(stringDefinitions[i]);
                    PrintCode();
                    Console.WriteLine(codeExamples[i]);
                    PrintExample();
                    ReadonlyAccess();
                    ;
                    break;
                case 5:
                    PrintDescription();
                    Console.WriteLine(stringDefinitions[i]);
                    PrintCode();
                    Console.WriteLine(codeExamples[i]);
                    PrintExample();
                    StringLiteral();
                    ;
                    break;
                case 6:
                    PrintDescription();
                    Console.WriteLine(stringDefinitions[i]);
                    PrintCode();
                    Console.WriteLine(codeExamples[i]);
                    PrintExample();
                    EscapingLiteral();
                    ;
                    break;
                case 7:
                    PrintDescription();
                    Console.WriteLine(stringDefinitions[i]);
                    PrintCode();
                    Console.WriteLine(codeExamples[i]);
                    PrintExample();
                    VerbatimStrings();
                    ;
                    break;
                case 8:
                    PrintDescription();
                    Console.WriteLine(stringDefinitions[i]);
                    PrintCode();
                    Console.WriteLine(codeExamples[i]);
                    PrintExample();
                    VerbatimPath();
                    ;
                    break;
                case 9:
                    PrintDescription();
                    Console.WriteLine(stringDefinitions[i]);
                    PrintCode();
                    Console.WriteLine(codeExamples[i]);
                    PrintExample();
                    DoubleQuotation();
                    ;
                    break;
                case 10:
                    PrintDescription();
                    Console.WriteLine(stringDefinitions[i]);
                    PrintCode();
                    Console.WriteLine(codeExamples[i]);
                    PrintExample();
                    ;
                    break;
                default:
                    Console.WriteLine("More info on http://msdn.microsoft.com");
                    break;
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Press any key to continue!");
            Console.ReadKey();
            Console.Clear();
            i++;
        }
    }

    private static void PrintExample()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\n\n");
        Console.WriteLine("Result:");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine();
    }

    private static void PrintCode()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\n\n");
        Console.WriteLine("Code:");
        Console.ForegroundColor = ConsoleColor.Green;
    }

    private static void PrintDescription()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Description:");
        Console.ForegroundColor = ConsoleColor.Yellow;
    }

    private static void DoubleQuotation()
    {
        Console.WriteLine(@"""Ahoy!"" cried the captain.");
        Console.WriteLine();
    }

    private static void VerbatimPath()
    {
        Console.WriteLine(@"c:\Docs\Source\a.txt");
        Console.WriteLine();
    }

    private static void VerbatimStrings()
    {
        Console.WriteLine(@"good morning");
        Console.WriteLine();
    }

    private static void EscapingLiteral()
    {
        string a = "\\\u0066\n";
        Console.WriteLine(a);
    }

    private static void StringLiteral()
    {
        Console.WriteLine("good morning\n");
    }

    private static void ReadonlyAccess()
    {
        string str = "test";
        char x = str[2];
        Console.WriteLine(x);
        Console.WriteLine();
    }

    private static void ImmutableString()
    {
        string b = "h";
        b += "ello";
        Console.WriteLine(b);
        Console.WriteLine();
    }

    private static void ConatenateStrings()
    {
        string a = "good " + "morning";
        Console.WriteLine(a);
        Console.WriteLine();
    }

    private static void TestingStringEquality()
    {
        string a = "hello";
        string b = "h";
        // Append to contents of 'b'
        b += "ello";
        Console.WriteLine(a == b);
        Console.WriteLine((object)a == (object)b);
        Console.WriteLine();
    }
}

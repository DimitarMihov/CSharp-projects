using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security;


class ReadAndPrintFileOnTheConsole
{
    /*Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini),
     * reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…).
     * Be sure to catch all possible exceptions and print user-friendly error messages.*/

    static void Main()
    {
        Console.Write("Enter the file path: ");
        string filePath = Console.ReadLine();
        try
        {
            string fileContent = File.ReadAllText(filePath);
            Console.WriteLine(fileContent);
        }
        catch (ArgumentNullException)
        {

            Console.WriteLine("There is no file path defined!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("The file path is not correct!");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The specified path is invalid");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file specified in path was not found. ");
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occurred while opening the file.");
        }

        catch (UnauthorizedAccessException)
        {
            Console.WriteLine(@"
        'path' specified a file that is read-only.

        -or-

        This operation is not supported on the current platform.

        -or-

        'path' specified a directory.

        -or-

        The caller does not have the required permission.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine(@"'path' is in an invalid format.");
        }
        catch (SecurityException)
        {
            Console.WriteLine("The caller does not have the required permission. ");
        }
    }
}

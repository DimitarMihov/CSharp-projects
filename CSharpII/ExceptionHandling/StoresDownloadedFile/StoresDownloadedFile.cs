using System;
using System.Net;
using System.Net.Mime;
using System.IO;


class StoresDownloadedFile
{
    /*Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) 
     * and stores it the current directory. Find in Google how to download files in C#. 
     * Be sure to catch all exceptions and to free any used resources in the finally block.*/

    static void Main()
    {
        try
        {
            Console.Write("Enter the URL addres of file to download: ");
            string webAddress = Console.ReadLine();
            string fileName = Path.GetFileName(webAddress);
            Console.Write(@"Enter the path on the local machine to save file (X:\xxx\yyy\: ");
            string folders = Console.ReadLine();
            string filePath = folders + fileName;

            WebClient myWebClient = new WebClient();
            Console.WriteLine("Downloading file from {0}  ... \n\n", webAddress);
            myWebClient.DownloadFile(webAddress, filePath);
            Console.WriteLine("Succesfuly downloaded file from {0}", webAddress);
        }
        catch (WebException)
        {

            Console.WriteLine(@"
        The URI formed by combining BaseAddress and address is invalid.

        -or-

        ""filename"" is null or Empty.

        -or-

        The file does not exist.

        -or- An error occurred while downloading data. ");
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
        catch (NotSupportedException)
        {
            Console.WriteLine("The method has been called simultaneously on multiple threads.");
        }
        
    }
}

using System;
using System.IO;

class ReadTextInFile
{
    static void Main()
    {
        Console.Write("Enter file path: ");
        string filePath =Console.ReadLine();
        ReadAllText(filePath);
    }

    public static void ReadAllText (string filePath)
    {
        try
        {
            string fileContent = File.ReadAllText(filePath);
            Console.WriteLine("The content of the file is: ");
            Console.WriteLine(fileContent);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("No file path is given!");
        }
        catch (ArgumentException argumentEx)
        {
            Console.WriteLine("The entered file path is not correct!",argumentEx.Message);
        }
        catch (PathTooLongException)
        {
            Console.Write("The specified path, file name, or both exceed the system-defined maximum length.");
            Console.Write(" Paths must be less than 248 characters, and file names must be less than 260 characters.");
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine("Directory not found: " + ex.Message);
        }
        catch (IOException iOEx)
        {
            Console.WriteLine("The write operation could not " +
                         "be performed because the specified " +
                         "part of the file is locked.", iOEx.Message);
        }
        catch (UnauthorizedAccessException securityEx)
        {
            Console.WriteLine("The exception that is thrown when the operating system" +
                "denies access because of an I/O error or a specific" +
                "type of security error.", securityEx.Message);
        }
        catch (NotSupportedException notSupportEx)
        {
            Console.WriteLine("The path is in an invalid format.", notSupportEx.Message);
        }
    }
}
    


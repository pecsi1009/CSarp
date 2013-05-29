using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

class DownloadFileFromWeb
{
    static void Main()
    {
        Console.Write("Please enter URL address: ");
        string uRL = Console.ReadLine();
        Console.Write("Please enter file name: ");
        string file = Console.ReadLine();
        string fullAddress = uRL + "/" + file;
        WebClient webClient = new WebClient();
        try
        {
            webClient.DownloadFile(fullAddress, file);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("The address can not be null");
        }
        catch (WebException)
        {
            Console.WriteLine("Invalid address or empty file.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("This method does not support simultaneous downloads.");
        }
        finally
        {
            webClient.Dispose();
        }
    }
}


using System;

class CompanyItem
{
    static void Main()
    {
        Console.Write("Write company name:");
        string name = Console.ReadLine();
        Console.Write("Write phone number:");
        double phoneNumber = double.Parse(Console.ReadLine());
        Console.Write("Write fax number:");
        double faxNumber = double.Parse(Console.ReadLine());
        Console.Write("Write web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Write manager first name:");
        string firstName = Console.ReadLine();
        Console.Write("Write manager last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Write manager age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Write manager phone number: ");
        double managerPhone = double.Parse(Console.ReadLine());

        Console.WriteLine("Company name:{0}\n" + "Phone number:{1}\n" +
        "Fax number number:{2}\n" + "Web site:{3}\n" + "Manager first name:{4}\n" +
        "Manager last name{5}\n" + "Manager age:{6}\n" + "Manager phone number:{7}\n",
        name, phoneNumber, faxNumber, webSite, firstName, lastName, age, managerPhone);

    }
}


using System;

class BankAccount
{
    static void Main()
    {
        string firstName="Paloma";
        string middleName = "Andreeva";
        string lastName = "Peicheva";
        decimal balance = 35480.26254m;
        string bankName = "UBB";
        Object IBAN = "BG60UBBS61231048620418BGN";
        string BICcode = "CECBBGSF";
        long firstCard = 4234750000625807;
        long secondCard =5247560000426806;
        long thirdCard = 42447800000586803;

        Console.WriteLine("First name:{0}\nMiddle name:{1}\nLast name:{2}\nBalance:{3}\nBank name:{4}\nIBAN:{5}\nBIC code:{6}\nFirst card{7}\nSecond card{8}\nThird card{9}\n",
            firstName, middleName, lastName, balance, bankName, IBAN, BICcode, firstCard, secondCard, thirdCard);
     
    }
}


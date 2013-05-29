using System;

class NamesOfCards
{
    static void Main()
    {
        string cards = "", faceCards = "";

        for (int i = 1; i <= 13; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                switch (i)
                {
                    case 1:
                        cards = "Two";
                        break;
                    case 2:
                        cards = "Three";
                        break;
                    case 3:
                        cards = "Four";
                        break;
                    case 4:
                        cards = "Five";
                        break;
                    case 5:
                        cards = "Six";
                        break;
                    case 6:
                        cards = "Seven";
                        break;
                    case 7:
                        cards = "Eight";
                        break;
                    case 8:
                        cards = "Nine";
                        break;
                    case 9:
                        cards = "Ten";
                        break;
                    case 10:
                        cards = "Knave";
                        break;
                    case 11:
                        cards = "Queen";
                        break;
                    case 12:
                        cards = "King";
                        break;
                    case 13:
                        cards = "Ace";
                        break;
                }
                switch (j)
                {
                    case 1:
                        faceCards = "Club";
                        break;
                    case 2:
                        faceCards = "Diamon";
                        break;
                    case 3:
                        faceCards = "Heart";
                        break;
                    case 4:
                        faceCards = "Spade";
                        break;
                }
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("{0} Of {1}",cards,faceCards);
            }
        }
        Console.WriteLine("Let's play!");
    }
}



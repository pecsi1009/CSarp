/* 
    1.Define a class that holds information about a mobile phone device: model, manufacturer,
price, owner, battery characteristics (model, hours idle and hours talk) and display 
characteristics (size and number of colors). Define 3 separate classes (class GSM holding
instances of the classes Battery and Display).
     
    2.Define several constructors for the defined classes that take different sets of arguments
(the full information for the class or part of it). Assume that model and manufacturer are
mandatory (the others are optional). All unknown data fill with null.
     
    4.Add a method in the GSM class for displaying all information about it. Try to override ToString().
 
    5.Use properties to encapsulate the data fields inside the GSM, Battery and Display classes.
Ensure all fields hold correct data at any given time.
 
    6.Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.

    7.Write a class GSMTest to test the GSM class:
        *Create an array of few instances of the GSM class.
        *Display the information about the GSMs in the array.
        *Display the information about the static property IPhone4S.

    9.Add a property CallHistory in the GSM class to hold a list of the performed calls. Try to use the system
class List<Call>.
 
    11.Add a method that calculates the total price of the calls in the call history. Assume the price per minute
is fixed and is provided as a parameter.

    12.Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
        *Create an instance of the GSM class.
        *Add few calls.
        *Display the information about the calls.
        *Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
        *Remove the longest call from the history and calculate the total price again.
        *Finally clear the call history and print it.
 */

namespace DefineClases
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class GSM
    {
        // <field>
        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        public Battery Battery = new Battery();
        public Display Display = new Display();
        public Call Call = new Call();
        static public List<Call> callHistory = new List<Call>(); //(Task 9)
        static DateTime date = new DateTime(2013, 02, 24, 12, 28, 53);
        private static GSM IPhone4S = new GSM("IPhone4s","Apple",200,"Kiril"); //Add a static field IPhone4S in the GSM class.

        //<constuctor>
        public GSM(string model, string manufacturer, double price, string owner)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
        }

        //<properties>
        public string Model 
        {
            get {return this.model;}
            set
            {
                // <Ensure all fields hold correct data at any given time.>
                if (String.IsNullOrEmpty(value))
                {
                    Console.WriteLine("The model can not be empty");
                }
                if (value.Length > 20)
                {
                    throw new ArgumentException("The name of model must be short than 20characters");
                }
                if (value.Length < 1)
                {
                    throw new ArgumentException("The model's name must be long than 1 characters");
                }
                this.model = value;
            }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set {
                if (String.IsNullOrEmpty(value))
                {
                    Console.WriteLine("The model can not be empty");
                }
                if (value.Length > 20)
                {
                    throw new ArgumentException("The name of model must be short than 20characters");
                }
                if (value.Length < 1)
                {
                    throw new ArgumentException("The model's name must be long than 1 characters");
                }
                this.manufacturer = value;
            }
        }
        public double Price
        {
            get{ return this.price; }
            set {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The price must be bigger 0$");
                }
                this.price = value; }
        }
        public string Owner
        {
            get { return this.owner; }
            set {
                if (String.IsNullOrEmpty(value))
                {
                    Console.WriteLine("The model can not be empty");
                }
                if (value.Length > 20)
                {
                    throw new ArgumentException("The name of model must be short than 20characters");
                }
                if (value.Length < 1)
                {
                    throw new ArgumentException("The model's name must be long than 1 characters");
                }
                this.owner = value; 
            }
        }
        public static GSM iPhone4S
        {
            get { return IPhone4S; }
        }
        public static List<Call> CallHistory
        {
            get { return callHistory; }
            set { callHistory = value; }
        }
        public override string ToString()
        {
            return this.model + ", "+this.manufacturer+", "+this.price+","+this.owner;
        }

        //<methods - (4), (9)>
        public void PrintGSMParam(string model, string manufacturer, double price, string owner)
        {
            GSM myGsm = new GSM("5530", "Nokia", 100, "Petya");
            Console.WriteLine(myGsm.ToString());
        }
        public void AddCall(DateTime now, int number, int duration)
        {
            Call myCall = new Call(now, number, duration);
            callHistory.Add(myCall);
        }

        public void RemoveCall(int number)
        {
            for (int i = 0; i < callHistory.Count; i++)
            {
                if (callHistory[i].DialedNumber == number)
                {
                    callHistory.RemoveAt(i);
                    i--;
                }
            }
        }

        public void ClearHistory()
        {
            callHistory.Clear();
        }
        public double CalcPrice(double pricePerMin)
        {
            double wholeTime = 0;
            for (int i = 0; i < callHistory.Count; i++)
            {
                wholeTime = wholeTime + callHistory[i].Duration;
            }

            double price = pricePerMin * (wholeTime / 60);
            return price;
        }
    } 
}


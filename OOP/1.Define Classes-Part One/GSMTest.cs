/*
    7.Write a class GSMTest to test the GSM class:
        *Create an array of few instances of the GSM class.
        *Display the information about the GSMs in the array.
        *Display the information about the static property IPhone4S.
*/
using DefineClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    public class GSMTest
    {
        static void Main()
        {
            GSM[] gsm = new GSM[3];
            string[] models = { "5530", "U9", "GalaxyS" };
            string[] manufactirers = { "Nokia", "Motorola", "Samsung" };
            double[] prices = { 100, 250, 500 };
            string[] owners = { "Ivan", "Ganka", "Tosho" };

            for (int i = 0; i < gsm.Length; i++)
            {
                gsm[i] = new GSM(models[i], manufactirers[i], prices[i], owners[i]);
                Console.WriteLine(gsm[i].ToString());
            }
            Console.WriteLine(GSM.iPhone4S);
        }
    }
    

/* 
    8.Create a class Call to hold a call performed through a GSM. It should contain date, time, 
dialed phone number and duration (in seconds).
 
   10.Add methods in the GSM class for adding and deleting calls from the calls history. Add a method to clear
the call history.
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    public class Call
    {
        // <fields>
        private DateTime dateTime;
        private string phoneNumber;
        private long duration;

        // <constructor>
        public Call(DateTime dateTime, string phoneNumber, long duration)
        {
            this.dateTime = dateTime;
            this.phoneNumber = phoneNumber;
            this.duration = duration;
        }
        // <properties>
        public DateTime Datetime
        {
            get { return this.datetime; }
            set { this.datetime = value; }
        }

        public string Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        public long Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }

       
    }


 /*
    3.Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the
 batteries. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    //<enumeration>
    public enum BatteryType
    {
        LiIon, NiMH, NiCd
    }
    public class Battery
    {
        //  <field>
        private string batteryModel;
        private double hoursIdle;
        private double hoursTalk;
        private BatteryType type;    

        // <constructors>
        public Battery()
        {
            this.batteryModel = null;
            this.hoursIdle = 0;
            this.hoursTalk = 0;
        }
        public Battery(BatteryType type)
        {
            this.type = type;
        }
        // <property>
        public string BatteryModel
        {
            get{ return this.batteryModel; }
            set {
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
                this.batteryModel=value;
            }
        }
        public double HoursIdle
        {
            get { return this.hoursIdle; }
            set {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The price must be bigger than 0h");
                }
                this.hoursIdle = value;
            }
        }
        public double HoursTalk
        {
            get { return this.hoursTalk; }
            set {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The price must be bigger than 0h");
                }
                this.hoursTalk = value;
            }
        }
    }


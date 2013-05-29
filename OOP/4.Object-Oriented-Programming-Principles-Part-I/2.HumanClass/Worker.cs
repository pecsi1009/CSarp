/*==========================================================================
     Define class Worker derived from Human with new property WeekSalary 
 and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker
==============================================================================*/

namespace HumanClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Worker : Human
    {
        // fields
        private decimal weekSalary;
        private decimal workHoursPerDay;

        //constuctor for fields
        public Worker(string fName, string lName, decimal salaryForWeek, decimal dayWorkHours)
            :base(fName,lName)
        {
            this.weekSalary = salaryForWeek;
            this.workHoursPerDay = dayWorkHours;
        }
        //properties
        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set { this.weekSalary = value; }
        }
 
        public decimal WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set { this.workHoursPerDay = value; }
        }
        
        //methods
        public decimal MoneyPerHour()
        {
            int workDays = 5; //normally works days are 5 in week
            decimal earnedByHourMoney = (weekSalary / workDays) / workHoursPerDay; 
            return earnedByHourMoney;
        }
        public override string ToString()
        {
            string result = string.Format("Student Name: {0} {1}", this.firstName, this.lastName) + Environment.NewLine;
            result = result + string.Format("   Salary Per Hour: {0:F2}Lv.", this.MoneyPerHour());
            return result;
        }
    }
}

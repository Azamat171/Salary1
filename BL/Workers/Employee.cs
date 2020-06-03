using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Workers
{
    abstract class Employee
    {//родительский класс -- шаблон для наследников
        protected double salary;
        protected double workTime;
        protected double additionalFactor;
        //его конструктор
        public Employee(double salaryValue, double workTimeValue, double additionalFactorValue)
        {
            this.salary = salaryValue;
            this.workTime = workTimeValue;
            this.additionalFactor = additionalFactorValue;
        }               
    }
}

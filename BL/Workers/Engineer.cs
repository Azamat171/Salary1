using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Workers
{
    class Engineer : Employee, ISalaryGetter
    {//наследование конструктора
        public Engineer(double salaryValue, double workTimeValue, double additionalFactorValue) : base(salaryValue, workTimeValue, additionalFactorValue)
        {
        }
        //реализация интерфейса
        public double GetSalary()
        {
            return salary + workTime * additionalFactor;
        }
    }
}

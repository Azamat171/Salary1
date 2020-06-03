using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Workers
{
    class Worker : Employee, ISalaryGetter
    {//см. Engineer
        public Worker(double salaryValue, double workTimeValue, double additionalFactorValue) : base(salaryValue, workTimeValue, additionalFactorValue)
        {
        }

        public double GetSalary()
        {
            return salary * workTime + additionalFactor * 2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Workers
{
    class TypeParser
    { // класс определяющий, какого работника мы рассматрваем
        public static ISalaryGetter Parse(string type, double salaryValue, double workTimeValue, double additionalFactorValue) {
            ISalaryGetter employee = null;
            switch (type) {
                case "Engineer": employee = new Workers.Engineer(salaryValue, workTimeValue, additionalFactorValue); break;
                case "Manager": employee = new Workers.Manager(salaryValue, workTimeValue, additionalFactorValue); break;
                case "Worker": employee = new Workers.Worker(salaryValue, workTimeValue, additionalFactorValue); break;
            }
            return employee;
        }

        public static ISalaryGetter Parse(string type)
        {//для создания mock-объектов
            ISalaryGetter employee = null;
            switch (type)
            {
                case "Engineer": employee = new Workers.Engineer(1, 1, 1); break;
                case "Manager": employee = new Workers.Manager(1, 1, 1); break;
                case "Worker": employee = new Workers.Worker(1, 1, 1); break;
            }
            return employee;
        }
    }
}

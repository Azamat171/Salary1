using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Counter
    {
        Workers.ISalaryGetter countedObject; //(любой) объект у которого можно посчитать зарплату

        public Counter(string type, double salaryValue, double workTimeValue, double additionalFactorValue)
        {//Такой фокус позволяет провести инъекцию зависимостей и получить объект сразу при создании счётчика
            countedObject = Workers.TypeParser.Parse(type, salaryValue, workTimeValue, additionalFactorValue);
            if (countedObject == null) throw new ArgumentNullException();//пользователь дурак и не указал работника
        }

        public double CountSalary() {//просим объект посчитать зарплату
            return countedObject.GetSalary();
        }
    }
}

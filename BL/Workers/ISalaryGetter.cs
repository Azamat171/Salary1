using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Workers
{//интерфейс позволяющий всем классам, которые его реализуют, считать зарплату
    interface ISalaryGetter
    {
        double GetSalary();
    }
}

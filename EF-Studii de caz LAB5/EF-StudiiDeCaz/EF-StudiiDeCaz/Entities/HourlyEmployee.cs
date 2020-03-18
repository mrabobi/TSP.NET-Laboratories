using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_StudiiDeCaz.Entities
{
    public class HourlyEmployee : Employee
    {
        public decimal? Wage { get; set; }
    }
}

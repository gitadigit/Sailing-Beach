using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sailing.Core.DTOs
{
    public class BoatDto
    {

        public string CompanyName { get; set; }

        public string YearOfManufacture { get; set; }

        public int NumberOfPassenger { get; set; }

        public bool AfterSunset { get; set; }
    }
}

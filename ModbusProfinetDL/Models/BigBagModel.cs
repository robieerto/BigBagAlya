using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModbusProfinetDL.Models
{
    public class BigBagModel
    {
        public DateTime Cas { get; set; }
        public int Program { get; set; }
        public int Uzivatel { get; set; }
        public float Vaha { get; set; }
        public int Rok { get; set; }
        public int Mesiac { get; set; }
        public int Den { get; set; }
        public int Hodiny { get; set; }
        public int Minuty { get; set; }
    }
}

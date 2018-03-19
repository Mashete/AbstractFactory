using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class HotelCostero : Hotel
    {
        public HotelCostero(DateTime fechaInicio, DateTime fechaFin) : base(fechaInicio, fechaFin)
        {
        }

        public override void VamosAEsquiar()
        {
            Console.WriteLine("No hace tanto frio");
        }

        public override void VamosANadar()
        {
            Console.WriteLine("No hace tanto calor");
        }
    }
}

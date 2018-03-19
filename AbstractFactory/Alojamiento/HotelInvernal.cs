using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class HotelInvernal : Hotel
    {
        public HotelInvernal(DateTime fechaInicio, DateTime fechaFin) : base(fechaInicio, fechaFin)
        {
        }

        public override void VamosAEsquiar()
        {
            Console.WriteLine("Wiiiii!! A esquiar!!");
        }

        public override void VamosANadar()
        {
            Console.WriteLine("Hace mucho frio como para nadar...");
        }
    }
}

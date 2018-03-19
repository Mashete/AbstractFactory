using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class HotelVeraniego : Hotel
    {
        public HotelVeraniego(DateTime fechaInicio, DateTime fechaFin) : base(fechaInicio, fechaFin)
        {
        }

        public override void VamosAEsquiar()
        {
            Console.WriteLine("No se puede esquiar fuera de temporada");
        }

        public override void VamosANadar()
        {
            Console.WriteLine("Wiiiii!! A nadar!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Invierno : ITemporada
    {
        public Hotel CrearHotel()
        {
            return new HotelInvernal(new DateTime(2018, 6, 21), new DateTime(2018, 9, 21));
        }

        public Transporte CrearTransporte()
        {
            return new MotoNieve();
        }
    }
}

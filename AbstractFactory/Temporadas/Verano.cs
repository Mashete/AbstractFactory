using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Verano : ITemporada
    {
        public Hotel CrearHotel()
        {
            return new HotelVeraniego(new DateTime(2018, 12, 21), new DateTime(2019, 3, 21));
        }

        public Transporte CrearTransporte()
        {
            return new Auto();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class SemanaSanta : ITemporada
    {
        public Hotel CrearHotel()
        {
            return new HotelCostero(new DateTime(2018, 3, 25), new DateTime(2018, 3, 31));
        }

        public Transporte CrearTransporte()
        {
            return new Auto();
        }
    }
}
